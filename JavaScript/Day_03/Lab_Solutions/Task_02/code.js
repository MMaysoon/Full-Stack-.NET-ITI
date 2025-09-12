var i=0;

function PrintNumber()
{
   console.log(i);
   
     if (i<=20)
        {
         console.log(i);
         
           document.write(`<div style='border: 2px solid red; width:40px; text-align: center; margin:4px;padding:4px'>${i}</div>`);
           document.title=i;
           console.log(i);
           setTimeout(PrintNumber,200);
           i++;
           console.log(i);
       }
}
console.log(i);
PrintNumber();