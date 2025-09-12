//1.Access btn & tbody
databtn=document.querySelector('#databtn');
tbody=document.querySelector('tbody');


//2.Load data
databtn.addEventListener('click' ,function ()
 {
    //1.make request
   var xhr=new XMLHttpRequest 
   xhr.open("Get","https://api.jsonbin.io/v3/b/68bc79dbae596e708fe4e8c6",true)
   
   //2.send request
   xhr.send("")

   // 3.response
   xhr.onreadystatechange=function(){
    if (xhr.status==200 & xhr.readyState==4)
    {
        response=JSON.parse(xhr.responseText)
        users=response.record


        tbody.innerHTML=""
        
        users.forEach(function(user)
        {
           crs = user.courses.join(' ');
           row =`<tr>
                    <td>${user.firstName} </td> 
                    <td>${user.lastName} </td>
                    <td>${user.phone} </td>
                    <td>${user.address} </td>
                    <td>${user.track} </td>
                    <td>${crs} </td>
                    <td><img src="${user.image}"/></td>
                    <td>${user.position} </td>
                </tr>`;

            tbody.innerHTML+=row;
        })
    }
   }
})