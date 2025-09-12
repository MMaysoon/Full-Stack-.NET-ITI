var students = [
   { name: "Ali", age: 20, Crs: "CS" },
   { name: "Sara", age: 22, Crs: "Math" },
   { name: "Sara", age: 19, Crs: "Physics" },
   { name: "Laila", age: 21, Crs: "CS" },
   { name: "Hassan", age: 23, Crs: "Engineering" },
   { name: "Mona", age: 20, Crs: "Biology" },
   { name: "Kareem", age: 24, Crs: "Math" },
   { name: "Ali", age: 18, Crs: "CS" }
];

// 1- Display all students
console.log("All Students:");
students.forEach(student => {
   console.log(`Name: ${student.name}, Age: ${student.age}, Course: ${student.Crs}`);
});

// 2-find and Search for a student by name and print their details.
function searchByName(name) {
   var student = students.find(student => student.name.toLowerCase() === name.toLowerCase());
   if (student) {
      console.log(`Found Student - Name: ${student.name}, Age: ${student.age}, Course: ${student.Crs}`);
   } else {
      console.log("Student not found");
   }
}
searchByName("Omar");

// 3-Find how many students are in the array(count Students).
console.log("Count Students:", students.length)

// 4-Get all students who are in "CS"
var csStudent = students.filter(s => s.Crs == "CS");
console.log("CS Students..................... ")
csStudent.forEach(student => {
   console.log(`Name: ${student.name}, Age: ${student.age}, Course: ${student.Crs}`);
});

// 5-Find youngest student
var copy = students.slice();
copy.sort((a, b) => a.age - b.age);
console.log(`Youngest Student with : ...`);
console.log(`Name: ${copy[0].name}, Age: ${copy[0].age}, Course: ${copy[0].Crs}`)

// 6- Sort Students by age
students.sort((a, b) => a.age - b.age);
console.log("sort by age ..... ", students)

// 7-Create a new array with only student names.
var names = students.map(s => s.name)
console.log("Array of names : ... ", names)

// 8-Check if all students are above age  18 and return true or false
var above18 = students.every(s => s.age > 18)
console.log("All above 18 ?", above18)

// 9-return Students Who Have the Same Crs
var courses = {}

students.forEach(function (student) {
   if (!courses[student.Crs]) {
      courses[student.Crs] = []
   }

   courses[student.Crs].push(student.name)
})

var result = {};
Object.keys(courses).forEach(crs => {
   if (courses[crs].length >= 2) {
      result[crs] = courses[crs]
   }
});

console.log("students have same course :- ..", result)

// 10-Calculate the average age of all students.
var avgAge = students.reduce((sum, s) => sum + s.age, 0) / students.length
console.log("Average Age:", avgAge)

// 11-Sort and Find top 3 oldest students
var top3 = students.slice(0, 3)
console.log("Top 3 Oldest......")
top3.forEach(student => {
   console.log(`Name: ${student.name}, Age: ${student.age}, Course: ${student.Crs}`);
});

// 12-Find if there are students with the same name.
var namesCount = {}

students.forEach(function (student) {
   if (!namesCount[student.name]) {
      namesCount[student.name] = 1;
   }
   else {
      namesCount[student.name] += 1;
   }
})

for (var _name in namesCount) {
   if (namesCount[_name] > 1) {
      console.log(_name + " is duplicated")
   }
   else {
      console.log("No Duplicated ! All names is unique")
   }
}

// 13-Reverse the array without using .reverse().
var reversed=[]
for (var i=students.length-1;i>=0;i-- )
{
   reversed.push(students[i]);
}
console.log("Reversed......")
reversed.forEach(student => {
   console.log(`Name: ${student.name}, Age: ${student.age}, Course: ${student.Crs}`);
});

// 14-Add a new property email for each student in the format: name.toLowerCase+"@iti.com"
students.forEach(s => {
  s.email = s.name.toLowerCase() + "@iti.com";
});
console.log("Students with email:");
students.forEach(student => {
   console.log(`Name: ${student.name}, Age: ${student.age}, Course: ${student.Crs} ,Email: ${student.email}`);
});