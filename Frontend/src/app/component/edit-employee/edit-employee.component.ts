import { Component, OnInit } from '@angular/core';
import { FormBuilder, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { EmployeeService } from '../../services/employee.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { IEmployee } from '../../Models/IEmployee';

@Component({
  selector: 'app-edit-employee',
  templateUrl: './edit-employee.component.html',
  styleUrl: './edit-employee.component.css'
})
export class EditEmployeeComponent implements OnInit {
  isSubmitting = false;
  positions: string[] = [];
  employeeId!: number;
  employeeForm = this.fb.group({
    firstName: ['', Validators.required],
    lastName: ['', Validators.required],
    email: ['', [Validators.required, Validators.email]],
    position: ['', Validators.required]
  });

  constructor(
    private fb: FormBuilder,
    private route: ActivatedRoute,
    private router: Router,
    private employeeService: EmployeeService,
    private snackBar: MatSnackBar
  ) {}

  ngOnInit(): void {
    this.employeeId = +this.route.snapshot.paramMap.get('id')!;
    this.loadEmployeeData();
  }

  loadEmployeeData(): void {
    this.employeeService.GetEmployeeById(this.employeeId).subscribe({
      next: (employee) => {
        this.employeeForm.patchValue({
          firstName: employee.firstName,
          lastName: employee.lastName,
          email: employee.email,
          position: employee.position
        });
      },
      error: () => {
        this.snackBar.open('Failed to load employee data', 'Close', { duration: 3000 });
        this.router.navigate(['/']);
      }
    });
  }

  onSubmit(): void {
    if (this.employeeForm.invalid || this.isSubmitting) return;
    this.isSubmitting= true;
    {
      const updatedEmployee = {
        ...this.employeeForm.value,
        id: this.employeeId
      } as IEmployee;

      this.employeeService.EditEmployee(updatedEmployee).subscribe({
        next: () => {
          this.snackBar.open('Employee updated successfully', 'Close', { duration: 3000 });
          this.router.navigate(['/']);
        },
        error: () => {
          this.snackBar.open('Failed to update employee', 'Close', { duration: 3000 });
        }
      });
    }
  }
}