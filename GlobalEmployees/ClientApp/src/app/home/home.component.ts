import { Component, OnInit } from '@angular/core';
import { EmployeesRequest } from '../models/request/employeesrequest';
import { EmployeesService } from '../services/employees.service';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.css']
})

export class HomeComponent implements OnInit
{
  employeesRequest: EmployeesRequest[];
  employeeValue: string;

  constructor(private employeesService: EmployeesService)
  {

  }

  ngOnInit()
  {
    
  }

  onEmployeeInput(event)
  {
    this.employeeValue = event.target.value;
  }

  GetAllEmployees()
  {
    if (this.employeeValue == null || this.employeeValue == "") {
      this.employeesService.GetAllEmployees().subscribe(
        (response: EmployeesRequest[]) => {
          this.employeesRequest = response;
        }
      );
    }
    else
    {
      this.employeesService.GetEmployeeById(this.employeeValue).subscribe(
        (response: EmployeesRequest[]) => {
          this.employeesRequest = response;
        }
      );
    }
  }
}
