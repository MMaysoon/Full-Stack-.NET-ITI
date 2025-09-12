//1-Map (create new arr & not affect in parent arr & apply func)
var arr1 = [1, 2, 3, 4]  
var arr2 = arr1.map(myFunc)

function myFunc(num) {
    return num * 2;
}

console.log(`Map Result :- ${arr2}`)


//2-every (T/F)
var ages=[20,14,15,16]

function checkage(age)
{
    return age>16;
}

console.log(`Every Result :- ${ages.every(checkage)}`)


//3-reduce > reduce any array to single value
var arr3=[10,20,30,2,5]

var sum=arr3.reduce(function (accu , current) {
    return accu+current
},0)

console.log(`Replace Result :- ${sum}`)

//4.From 
   //a.create array from string 
   var s="maysoon"
   console.log(`From array form string Result :- ${Array.from(s)}`)

   //a.create array from array
   var s2=[1,2,3]
   console.log(`From array form array Result :- ${Array.from(s2,x=>x*2)}`)


//5.Find
var ages2=[20,14,15,16]

function checkage(age)
{
    return age>16;
}

console.log(`Find Result :- ${ages2.find(checkage)}`)

