import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { EmployeeListComponent } from './component/employee-list/employee-list.component';
import { AddEmployeeComponent } from './component/add-employee/add-employee.component';
import { EditEmployeeComponent } from './component/edit-employee/edit-employee.component';

const routes: Routes = [
  { path: '', component: EmployeeListComponent },
  { path: 'add', component: AddEmployeeComponent },  // Make sure this exists
  { path: 'edit/:id', component: EditEmployeeComponent },
  { path: '**', redirectTo: '' } 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
