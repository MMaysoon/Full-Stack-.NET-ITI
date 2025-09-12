//1.Assign btn & text
var input = document.getElementById("taskInput");
var addBtn = document.getElementById("addBtn");
var taskList = document.getElementById("taskList");

//2.event
addBtn.addEventListener("click", function () {
    var task = input.value.trim();

    if (task === "") {
        alert("Please enter a valid task!");
        return;  // stop ccontinue and start from begin
    }

    // ul (tasklist) -> li (tasktest +  deltebtn)
    var li = document.createElement("li");
    var taskText = document.createElement("span");
    taskText.textContent = task;
    li.appendChild(taskText);


    taskText.addEventListener("click", function (e) {
        e.target.classList.toggle("done");
    });


    const delBtn = document.createElement("button");
    delBtn.textContent = "Delete";
    delBtn.addEventListener("click", function (e) {
        li.remove();
    });

    li.appendChild(delBtn);

    taskList.appendChild(li);

    // clear input
    input.value = "";
});
