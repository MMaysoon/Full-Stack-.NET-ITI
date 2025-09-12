
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

//3-Remove Duplicates
for (var i=0;i<arr.length;i++)
{
    for (var j=i+1;j<arr.length;j++)
    {
        if (arr[i]==arr[j])
        {
           arr.splice(j,1)
           j--;
        }
    }
}

//4-Sort Ascending 
arr.sort(function (a, b) { return a - b; })

//5-Filter Numbers > 50
//  a.User Defined
var fArr = []
for (var i = 0; i < arr.length; i++) {
    if (arr[i] > 50) {
        console.log(arr[i])
        fArr.unshift(arr[i])
    }

}

// b.built-in
var result = arr.filter(function (elm) {
    return elm > 50;
})


//6.Min Max (User Defined)

// Loop
var min=Number(arr[0])
var max=Number(arr[0])

for (var i=1;i<arr.length;i++)
{
    if (Number(arr[i])> max)
    {
        max=arr[i]
    }

    if (arr[i]<min)
    {
        min=arr[i]
    }
}
console.log(`Min Number using loop: ${min}`);
console.log(`Max Number using loop: : ${max}`);


// Sort
console.log(`Min Number using sort: ${arr[0]}`);
console.log(`Max Number using sort : ${arr[arr.length-1]}`);








