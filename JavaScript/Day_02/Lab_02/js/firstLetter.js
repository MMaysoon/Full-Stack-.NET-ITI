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
var result=""
for(var i=0;i<words.length;i++)
{
    var word=words[i];
    result += word.charAt(0).toUpperCase() + word.slice(1) +" ";
}

console.log(result)
