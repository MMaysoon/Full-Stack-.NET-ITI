// console.log("Sum three identical = " + sum1)
// console.log("Sum three = "+ sum2.toPrecision(5))
// console.log("num1+num3 =" , sum3)
// console.log("Type of x  variable -> ",typeof x);
// console.log("num1*x = ", mutli)


//Sum of two input 
// var result=0;
// var n;
// for(var i=0;i<2;i++)
// {
//     n=window.prompt(`Enter number ${i+1}`)
//     if (n==null || n=='')
//     {
//         alert("Must add number (Not Empty)")
//         i--;
//         continue;
//     }

//     n=parseInt(n)
//     if (isNaN(n))
//     {
//         alert("Must add validate number")
//         i--;
//         continue;
//     }

//     result+=n;
// }
// console.log("Sum of two numbers = ",result)



// Recive 5 number
var result2="";
var n2;
for(var i=0;i<5;i++)
{
    n=window.prompt(`Enter number ${i+1}`)
    if (n==null || n=='')
    {
        alert("Must add number (Not Empty)")
        i--;
        continue;
    }

    var m=parseInt(n)
    if (isNaN(m))
    {
        alert("Must add validate number")
        i--;
        continue;
    }

    result2+=n;
}
result2=parseInt(result2)
result2=result2.toPrecision(5)
console.log("Five numbers = ",result2)

