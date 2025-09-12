var nums= ['maysoon','menah','mohammed','ahmed','marwa','mai','fayrouz']
var output=document.querySelector('.output')


nums.forEach((name,index)=>
{
    var p=document.createElement('p')
    p.textContent=name;

    if (index%2==0)
    {
        p.classList.add('pink')
    }
    else 
    {
        p.classList.add('blue')
    }

    output.appendChild(p);
});
