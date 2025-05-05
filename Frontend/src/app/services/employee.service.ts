import { HttpClient, HttpParams } from '@angular/common/http';
import { inject, Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { IEmployee } from '../Models/IEmployee';
import { environment } from '../environments/environment.development';
import { ICreateEmployee } from '../Models/ICreateEmployee';
import { PagedResult } from '../Models/IPagedResult';

@Injectable({
  providedIn: 'root'
})
export class EmployeeService {

  private _httpClient = inject(HttpClient);
  constructor() { }

  
  GetAllEmployees(page: number, pageSize: number, searchTerm: string = '', positionFilter: string = ''): Observable<PagedResult<IEmployee>> {
    const params = new HttpParams()
      .set('pageNumber', page.toString())
      .set('pageSize', pageSize.toString())
      .set('searchTerm', searchTerm)
      .set('positionFilter', positionFilter);
  
    return this._httpClient.get<PagedResult<IEmployee>>(`${environment.baseURL}/Employee`, { params });
  }

  getPositions(): Observable<string[]> {
    return this._httpClient.get<string[]>(`${environment.baseURL}/Employee/positions`);
  }

  GetEmployeeById(id: number): Observable<IEmployee> {
    return this._httpClient.get<IEmployee>(
      `${environment.baseURL}/Employee/${id}`
    );
  }


  AddEmployee(EmployeeToAdd: ICreateEmployee) {
    return this._httpClient.post(
      `${environment.baseURL}/Employee`,
      EmployeeToAdd
    );
  }

  EditEmployee(EmployeeToEdit: IEmployee) {
    return this._httpClient.put(
      `${environment.baseURL}/Employee`,
      EmployeeToEdit
    );
  }
 
  deleteEmployee(EmployeeID:number) {
    return this._httpClient.delete(
      `${environment.baseURL}/Employee?id=${EmployeeID}`
    );
  }

}
