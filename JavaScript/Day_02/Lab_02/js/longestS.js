//1-Accept string
var sInput;
var s;
while (true) {
    sInput = window.prompt('Enter String');
    if (sInput == null || sInput.trim() == "") {
        alert("Must add string (Not Empty)")
        continue;
    }
    s = sInput;
    break
}

var words=s.split(' ');
var maxS=words[0]
for(var i=0;i<words.length;i++)
{
    if (words[i].length > maxS.length)
    {
        maxS=words[i]
    }
}

console.log(`Max Lenght for word : - ${maxS}`)
