// 1.Using DOM 
 //a.Find all images by two ways (document default colloection & documnet method)
    //first way  -> collection
    imgs=document.images
    console.log("First way --------")
    for(var i=0;i<imgs.length;i++)
    {
      console.log("Image Source : ",imgs[i].src)
    }

    //second way -> document method
    imgs_2=document.querySelectorAll('img')
    console.log("second way --------")
    imgs_2.forEach(img=> {
      console.log("image source : ",img.src)
    });
    console.log('-------------------------------')

 //b.find all options for city drop down list 
   console.log('City Options ------------')
   cityoptions=document.querySelectorAll('select[name="City"] option')
   cityoptions.forEach(city=>{
    console.log("city name : ",city.text," & city value : ",city.value )
   });
   console.log('-------------------------------')

 //c.find all rows for second table in page 
  console.log('Row of second table ------------')
  table_2=document.getElementsByTagName('table')[1]
  _tr=table_2.children[0].children
  // htmlcollention (for of) -> array
  Array.from(_tr).forEach(r => {
    console.log(r)
  });
  console.log('-------------------------------')

 //d.find all elements that contant class name (fontblue)
  console.log('All Elements with class fontblue ------------')
   font_blue=document.querySelectorAll('.fontBlue')
   font_blue.forEach(element => {
     console.log(element)
   });
  console.log('-------------------------------')

  //2- Actions on HTML elements
    //a.get first anchor -> inside second table ->change href="training.com" & text="Training"
    console.log('Change Anchor values ------------')
    table_02=document.getElementsByTagName('table')[1]
    anc_01=table_02.children[0].children[0].children[0].children[0]
    anc_01.href='training.com'
    anc_01.text='training'
    console.log(anc_01.href)
    console.log(anc_01.text)
    console.log('-------------------------------')


    //b.find last image -> change border to :solid pink 2px
    console.log('Change style last img ')
    imgs=document.querySelectorAll('img')
    last_img=imgs[imgs.length-1]
    last_img.style.border="solid pink 2px"
    console.log(last_img)
    console.log('-------------------------------')

    //c.funcation -> find all checkbox (checked)is userdata form -> alert their values 
    console.log('Funcation find Checkbox ')
    function alertCheck ()
    {
        allcheckbox=document.querySelectorAll('form[name="regForm"] input[type="checkbox"]')
        
       allcheckbox.forEach(b=>
        b.addEventListener('change',function()
        {
           checkedBoxes = document.querySelectorAll('form[name="regForm"] input[type="checkbox"]:checked');
           values = Array.from(checkedBoxes).map(cb => cb.value);
           alert("Checked values: " + values.join(", "));
        })
       )
    }
   alertCheck()
    console.log('-------------------------------')

    //d.find elements with id="example" -> change background (pink)
    console.log('Elements with id="example')
    ex=document.querySelectorAll('#example')
    ex.forEach(e=>{
       e.style.backgroundColor="pink"
      console.log(e)
    }
    )
    console.log('-------------------------------')