import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { EmployeeService } from '../../services/employee.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import { ICreateEmployee } from '../../Models/ICreateEmployee';

@Component({
  selector: 'app-add-employee',
  templateUrl: './add-employee.component.html',
  styleUrl: './add-employee.component.css'
})
export class AddEmployeeComponent implements OnInit {

  isSubmitting = false;
  positions: string[] = [];
  employeeForm = this.fb.group({
    firstName: ['', [Validators.required]],
    lastName: ['', [Validators.required]],
    email: ['', [Validators.required, Validators.email]],
    position: ['', [Validators.required]]
  });

  constructor(
    private fb: FormBuilder,
    private employeeService: EmployeeService,
    private snackBar: MatSnackBar,
    private router: Router
  ) { }
  ngOnInit(): void {
    this.loadPositions();
  }

  loadPositions(): void {
    this.employeeService.getPositions().subscribe({
      next: (positions) => this.positions = positions,
      error: (err) => console.error('Failed to load positions', err)
    });}
  onSubmit(): void {
    if (this.employeeForm.invalid || this.isSubmitting) return;
    
    this.isSubmitting = true;
    {
      const employee = {
        firstName: this.employeeForm.value.firstName!,
        lastName: this.employeeForm.value.lastName!,
        email: this.employeeForm.value.email!,
        position: this.employeeForm.value.position!
      } as ICreateEmployee;
      this.employeeService.AddEmployee(employee).subscribe({
        next: () => {
          this.snackBar.open('Employee created successfully', 'Close', { duration: 3000 });
          this.router.navigate(['/']);
        },
        error: (err) => {
          this.snackBar.open('Failed to create employee', 'Close', { duration: 3000 });
        }
      });
    }
  }
}
