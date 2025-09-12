// 1-using (Rest) to accept infinity number of argument
function printNames(...students) 
{
    students.forEach(s=> {
        console.log(s.name)
    });
}


//2-Using spread 

const students = [
  { id: 1, name: "Ali", grade: 80, city: "Cairo" },
  { id: 2, name: "Sara", grade: 92, city: "Alexandria" },
  { id: 3, name: "Omar", grade: 74, city: "Giza" },
  { id: 4, name: "Mona", grade: 88, city: "Cairo" }
];
printNames(...students)


//3-Without spread (normal calling)
console.log(".................")
printNames({id:1, name:"Ali"}, {id:2, name:"Sara"}, {id:3, name:"Omar"});
