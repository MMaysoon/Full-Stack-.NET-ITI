// 1-Import the Employee class.
import {Employee} from "./employee.js"

// 2- Create functions to:  Add employee(s) to an array.
let employess=[]

export function addEmployee(emp)
{
    employess.push(emp)
}

// 3-Find employee by name.
export function findEmplyeeByName(name)
{
    return employess.find(e=>e.getFullName()==name)
}

// 4-Increase salary for an employee.
export function increaseSalary(name,amount)
{
    const emp=findEmplyeeByName(name);

    if(emp)
    {
        emp.salary+=amount;
        return emp;
    }

    return null;
}


//5-GetEmployess
export function getEmployess()
{
    return employess;
}
