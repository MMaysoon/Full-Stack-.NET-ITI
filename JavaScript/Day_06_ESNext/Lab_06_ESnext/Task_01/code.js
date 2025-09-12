const students = [
  { id: 1, name: "Ali", grade: 80, city: "Cairo" },
  { id: 2, name: "Sara", grade: 92, city: "Alexandria" },
  { id: 3, name: "Omar", grade: 74, city: "Giza" },
  { id: 4, name: "Mona", grade: 88, city: "Cairo" }
];

// 1- Create a new array that contains only the names of students using arrow functions.
console.log("Names................................")
const arrNames=students.map(s=>s.name)  // return array
console.log(arrNames)

// 2-Get all students who have a grade greater than or equal to 85.(filter)
console.log("Students with grade >=85.............")
const student_filer=students.filter(s=>s.grade>=85)   //return array of object
const stud=student_filer.map(s=>s.name)   //get array of names
console.log(stud)

// 3-Find the student whose name is "Sara".
console.log("Student Info with name sara..........")
const sara=students.find(s=>s.name.toLowerCase()=='sara')
console.log(sara)

// 4-Calculate the average grade of all students.(reduce)
console.log("Grade Average........................")
const avg=students.reduce((sum,student)=>sum+student.grade,0)/students.length
console.log(avg)


// 5-Sort students by grade (descending) using arrow function in sort.
console.log("Students sort descending............")
const stud_sort=students.sort((a,b)=>b.grade-a.grade)
console.log(stud_sort)

// 6-Print Students using forEach arr fun 
console.log("All students......................")
const all_stud=students.forEach(s=>
{
    console.log(s)
}
)
console.log(all_stud)

// 7-Make a shallow copy of the students array using spread.
console.log("Shallow copy using spreed.......................")
const students_2=[...students]    //copy by refrence 
console.log(students_2)

// 8-Add a new student object into the array using spread.
console.log("Add new studnet to array.........................")
const new_stud={ id: 14, name: "Maysoon", grade: 100, city: "Mansoura" }
const new_arr=[...students,new_stud]
console.log(new_arr)

// 9-Suppose you have another array of students, merge it with the first array using spread
console.log("Merg tow Array.....................................")
const stud_2 = [
  { id: 1, name: "Menah Allah", grade: 100, city: "Cairo" },
  { id: 2, name: "Mai", grade: 100, city: "Alexandria" },
];

const merged_arr=[...stud_2,...students]
console.log(merged_arr)

// 10- Update "Omar"’s grade to 95 without mutating the original array (use spread inside map).
console.log("Update student with name(Omar) by grade(95).........")
const arr=students.map(s=>  s.name.toLowerCase()=='omar'?{...s,grade:95}:s)
console.log(arr)

// 11-Remove the student with id = 2 using filter + spread.
console.log("Remove student with id = 2.........................")
var _stud=[...students].filter(s=>s.id!=2)
console.log(_stud)

// 12- Take out the first student and keep the rest in another array using destructuring + spread
console.log("Take out the first student and keep the rest in another array")
   //a.rest and destructing
   const [firstStud , ...restStud ]=students

   // get rest using spred
   const rStud=[...restStud]
   console.log("Rest student.............................\n",rStud)

// 13- destruct and Extract the first student into a variable, and keep the rest into another array using rest 
console.log("destruct and Extract the first student into a variable, and keep the rest into another array")
console.log("First student.............................\n",firstStud)
console.log("Rest student.............................\n",restStud)


// 14- Skip the first two students and store the third one in a variable.
console.log("Get third student using destructing")
const [,,third]=students
console.log("Third student \n",third)