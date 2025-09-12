// 1- Import everything from both modules.
import {Employee,departments} from "./employee.js"
import {addEmployee,getEmployess,findEmplyeeByName,increaseSalary} from "./employeeOps.js"

// 2-Create a few employees, store them in an array.
let emp1 = new Employee("Maysoon", "Ahmed", 25, 5000);
let emp2 = new Employee("Omar", "Ali", 30, 7000);
let emp3 = new Employee("Sara", "Hassan", 28, 6000);

addEmployee(emp1)
addEmployee(emp2)
addEmployee(emp3)

// 3-Print all employees’ info on Document not console.
let container =document.getElementById("output");
getEmployess().forEach(e => 
{
    let p=document.createElement("p")
    p.textContent=`Name: ${e.getFullName()}, Age: ${e.age}, Salary: ${e.salary}`;
    container.appendChild(p)
});


//4.Increase Salary 
increaseSalary("Maysoon Ahmed",1000)
let result=document.createElement("p")
result.textContent=`Updated Salary for Maysoon Ahmed: ${findEmplyeeByName("Maysoon Ahmed").salary}`;
container.appendChild(result);

// 5.departments
const dep = document.createElement("p");
dep.textContent = `Departments: ${departments.join(", ")}`;
container.appendChild(dep);



