using System;

namespace ClassesHW1
{
    class Program
    {
        static void Main(string[] args)
        {
            Square Sq1 = new Square(); // object w no input.
            Square Sq2 = new Square(5); // object with 1 input. overloading 
            Square Sq3 = new Square(3, 4); // here we used get set Side PROPERTY to  get the value 3 and set it to the FIELD side = 3; 

            Triangle T1 = new Triangle(4, 5, 6);

            Console.WriteLine(Sq1.GetArea());
            Console.WriteLine(Sq2.GetArea());
            Console.WriteLine(Sq1.GetPerimeter());
            Console.WriteLine(Sq2.GetPerimeter());
            Console.WriteLine(Sq1.GetSide());
            Console.WriteLine(T1.GetArea());
             
        }
    }
}
