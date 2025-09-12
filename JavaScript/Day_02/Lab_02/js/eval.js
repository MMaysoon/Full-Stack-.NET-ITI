// 1-Validate Lenght
var lInput;
var l;
while (true) {
    lInput = window.prompt('Enter Array Lenght');
    if (lInput == null || lInput == '') {
        alert("Must add number (Not Empty)")
        continue;
    }

    var m = parseInt(lInput)
    if (isNaN(m)) {
        alert("Must add validate number")
        continue;
    }
    l = lInput;
    break
}

//2-Accept array
var arr = [];
var n;
for (var i = 0; i < l; i++) {
    n = window.prompt(`Enter number ${i + 1}`)
    if (n == null || n == '') {
        alert("Must add number (Not Empty)")
        i--;
        continue;
    }

    var m = parseInt(n)
    if (isNaN(m)) {
        alert("Must add validate number")
        i--;
        continue;
    }

    arr.push(n);
}


// 3-Accept Arithmaatic operator 
var OInput;
var o;
while (true) {
    oInput = window.prompt('Enter Aithmatic Operator + OR *');
    if (oInput == null || oInput == '') {
        alert("Must Enter Aithmatic Operator + OR *)")
        continue;
    }

    if (oInput!= '*' &&  oInput != '+')
    {
        alert("Must www Enter Aithmatic Operator + OR *)")
        continue;
    }

    o = oInput;
    break
}

switch(o){
    case '+':
        var sum=arr.join('+');
        console.log(`Sum = ${eval(sum)}`)
        break;
    case '*':
        var product=arr.join('*');
        console.log(`Product = ${eval(product)}`)
        break;
    default:
        break;
}
  