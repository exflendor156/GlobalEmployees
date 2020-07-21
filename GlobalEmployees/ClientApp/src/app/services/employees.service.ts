import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { EmployeesRequest } from '../models/request/employeesrequest';
import { Observable } from 'rxjs';

@Injectable()
export class EmployeesService {

  constructor(private httpClient: HttpClient)
  {

  }

  GetAllEmployees(): Observable<EmployeesRequest[]>
  {
    return this.httpClient.get<EmployeesRequest[]>("https://localhost:5001/api/Employees/GetEmployees");
  }
  GetEmployeeById(id: string): Observable<EmployeesRequest[]> {
    return this.httpClient.get<EmployeesRequest[]>("https://localhost:5001/api/Employees/GetEmployeeById/" + id);
  }
}
