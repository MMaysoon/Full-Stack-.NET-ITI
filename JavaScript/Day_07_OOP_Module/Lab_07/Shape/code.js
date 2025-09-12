// 1-Create a base class Shape with a method calcArea().
class Shape 
{
   calcArea()
   {
       return 0;
   }
}

// 2-Create subclasses Rectangle and Circle, and override the calcArea() method in each.
class Rectangel  extends Shape
{
    
    constructor(_width,_height) 
    {
       super();
        this.width=_width;
        this.height=_height
    }

    calcArea()
    {
        return `Rectange Area = ${this.width*this.height}`
    }
}

class Circle extends Shape
{
    
    constructor(_redius) 
    {
        super();
        this.redius=_redius;
    }

    calcArea()
    {
        return `Circle Area = ${Math.PI*this.redius*this.redius}`
    }
}

// 3-Create an array of different shapes (both rectangles and circles).
let shapes =
[
     new Rectangel(2,4),
     new Rectangel(5,8),
     new Circle(4),
     new Circle(7)
]

// 4-Loop through the array and calculate the area  shapes
shapes.forEach(s => {
    console.log(s.calcArea())
});