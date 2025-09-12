//1-Array of object (students info)
var students =
[
    {id:1,name:"maysoon",age:24},
    {id:2,name:"Menah",age:25},
    {id:3,name:"Ahmed",age:26},
    {id:4,name:"Mohamed",age:27},
    {id:5,name:"Fayrouz",age:28}
]


//2-Acces element 
var _dropdown=document.getElementById('stud')
var div_content =document.querySelector('.stud_info')

//3-Add id values to drop down 
students.forEach(s => 
{
      option=document.createElement('option')
      option.value=s.id;
      option.text=`ID: ${s.id}`
      _dropdown.appendChild(option)
});


//4-function display student info 
function displayStudInfo(id)
{
    var student=students.find(s=>s.id==id);
    if (student)
    {
        div_content.innerHTML=`
        <p>Name : ${student.name} </p>
        <p>Age :${student.age} </p>
        `
    }

    else {
        div_content.innerHTML='Not Found!'
    }
}


//5.default value (choosen value)
_dropdown.value=students[0].id
displayStudInfo(_dropdown.value)

//6.Change event
_dropdown.addEventListener('change',function(){
    displayStudInfo(this.value)
})

console.log(_dropdown.value)
