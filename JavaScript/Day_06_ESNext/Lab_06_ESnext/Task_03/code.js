// -----------------Var--------------------
console.log("-----------------Var--------------------")
   //1.Hositing (host decalration not inialization) 
   console.log("value of var :- ",x)  //undefined 
   var x=10

   //2.loosely typed (Redaclare & Reassign)
   x="ali"
   x=false
   x=14.2
   var x="maysoon"

   //3.Function Scope 
   for(var i=0;i<5;i++)
   {
    console.log(i)
   }
   console.log("Scope : ",i)

// -----------------Let--------------------
console.log("-----------------Let--------------------")
   //1.Hositing but not access in (TDZ) 
  //console.log("value of let :- ",y)   // can not access - error
    let y=14

   //2.Can Reassign 
    y="maysoon"
    console.log("Reassign let : ",y)

   //3.Can not Redacaler
    //let y="hi";   //error

   //4.block scope 
      for(let w=0;w<5;w++)
     {
       console.log(w)
     }

    //console.log("Scope : ",w) //Refrence error 

// -----------------Const--------------------
console.log("-----------------Const--------------------")
   //1.Must be initailize when decalre 
   const b=100;

   //2.Hositing but not access in (TDZ) 
   //console.log(a)  //error
   const a=4;

   //3.Can't Reassign or Redacalre
      //a=5 //can't reassign 
     //cosnt a="maysoon" //can't redaclare

  //3.Block scope
   for(let z=0;z<5;z++)
     {
       console.log(z)
     }

    //console.log("Scope : ",z) //Refrence error