// 1- Create a base class Person with properties: name and age.
class Person {

    constructor(_name, _age) {
        this.name = _name
        this.age = _age
    }

    print() 
    {
        return ` Name=${this.name} Age= ${this.age}`
    }

    introduce()
    {
       return `Super Class (student).......... \n`
    }
}

// 2-Create a subclass Teacher with property subject and method teach().
class Teacher extends Person 
{

    constructor(_name, _age, _subject) {
        super(_name, _age);
        this.subject = _subject
    }


    teach()
    {
       return `Student subclass :- \n ${super.print()},Subject= ${this.subject}`
    }

    introduce()
    {
        return `${super.introduce()} \t subclass_1 : Teacher`
    }
}

// 3-Create a subclass Student with property major and method study().
class Student extends Person
{

    constructor(_name, _age, _major) {
        super(_name, _age);
        this.major = _major;
    }

    study()
    {
      return `Student subclass :- \n  ${super.print()},Major= ${this.major}`
    }

    introduce()
    {
        return `\t subclass_2 : Student`
    }
}


// 4-Create objects of Teacher and Student, then call their methods.
let s=new Student("maysoon",24,"Computer Science")
console.log(s.study())

let t=new Teacher("maysoon",24,"JavaScript")
console.log(t.teach())

// 5-override a method introduce() in both Teacher and Student.
console.log(t.introduce());
console.log(s.introduce());
