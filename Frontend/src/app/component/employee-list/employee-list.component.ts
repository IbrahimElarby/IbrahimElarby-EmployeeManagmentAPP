import { Component, OnInit } from '@angular/core';
import { EmployeeService } from '../../services/employee.service';
import { IEmployee } from '../../Models/IEmployee';
import { MatDialog } from '@angular/material/dialog';
import { MatSnackBar } from '@angular/material/snack-bar';
import { DeleteConfirmationComponent } from '../delete-confirmation/delete-confirmation.component';
import { PageEvent } from '@angular/material/paginator';

@Component({
  selector: 'app-employee-list',
  templateUrl: './employee-list.component.html',
  styleUrl: './employee-list.component.css'
})
export class EmployeeListComponent implements OnInit {
  employees: IEmployee[] = [];
  displayedColumns: string[] = ['firstName', 'lastName', 'email', 'position', 'actions'];
  searchText = '';
  currentPage = 1;
pageSize = 10;
totalItems = 0;
searchTerm = '';
positionFilter = '';
  positions: string[] = [];

  constructor(
    private employeeService: EmployeeService,
    private dialog: MatDialog,
    private snackBar: MatSnackBar
  ) { }

  ngOnInit(): void {
    this.loadEmployees();
    this.loadPositions();
  }

  loadPositions(): void {
    this.employeeService.getPositions().subscribe({
      next: (positions) => this.positions = positions,
      error: (err) => console.error('Failed to load positions', err)
    });}

  loadEmployees(): void {
    this.employeeService.GetAllEmployees( this.currentPage,
      this.pageSize,
      this.searchTerm,
      this.positionFilter).subscribe({
      next: (data) => {this.employees = data.items ; this.totalItems = data.totalCount} ,
      error: (err) => this.showError('Failed to load employees')
    });
  }

  deleteEmployee(id: number): void {
    const dialogRef = this.dialog.open(DeleteConfirmationComponent);
    
    dialogRef.afterClosed().subscribe(result => {
      if (result) {
        this.employeeService.deleteEmployee(id).subscribe({
          next: () => {
            this.employees = this.employees.filter(e => e.id !== id);
            this.snackBar.open('Employee deleted successfully', 'Close', { duration: 3000 });
          },
          error: (err) => this.showError('Failed to delete employee')
        });
      }
    });
  }

  private showError(message: string): void {
    this.snackBar.open(message, 'Close', { duration: 3000, panelClass: ['error-snackbar'] });
  }

  // Handle page change
onPageChange(event: PageEvent): void {
  this.currentPage = event.pageIndex + 1;
  this.pageSize = event.pageSize;
  this.loadEmployees();
}

// Handle search
onSearch(): void {
  this.currentPage = 1;
  this.loadEmployees();
}
}