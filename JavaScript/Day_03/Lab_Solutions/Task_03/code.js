
// Search -> get query string 
var params = new URLSearchParams(window.location.search);
var username = params.get('username');
var password = params.get('password');

// open window  &  without action   (first time) (value null or undefined)
if (username == null && password == null) {
   console.log("waiting for user input......");
}

// check empty or spaces
else if (username.trim() == "" || password.trim() == "") {
   alert("Username and Password are required");
   window.location.href = "index.html";
}

//check correct
else if (username.toLowerCase() == "ali" && password == "123") {
   window.location.href = "welcome.html?msg=welcome ya ali";
}
else {
   window.location.href = "error.html?msg=ERROR!"
}

