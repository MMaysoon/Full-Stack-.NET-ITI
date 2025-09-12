// 1-Create a class Employee with properties: firstName, lastName, age, salary.
export class Employee
{
    constructor(_firstName,_lastName,_age,_salary) 
    {
        this.firstName=_firstName;
        this.lastName=_lastName;
        this.age=_age
        this.salary=_salary  
    }


   // 2-Add a method to class  getFullName() that returns "FirstName LastName".
   getFullName()
   {
     return `${this.firstName} ${this.lastName}`
   }
}


// 3- out class Export an array departments with some department names (["IT","HR","Finance","Sales"]).
export let departments=["IT","HR","Finance","Sales"]