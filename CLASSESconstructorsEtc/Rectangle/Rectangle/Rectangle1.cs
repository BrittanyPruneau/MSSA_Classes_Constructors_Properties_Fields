using System;
using System.Collections.Generic;
using System.Text;

namespace Rectangle
{
    class Rectangle1
    {
        //FIELDS

        private double length; // Encapsulation - protect my fields
        private double width = 4; // Encapsulation - Nobody - needs to know how I store things.

        



        //CONSTRUCTORS   
        // CONSTRUCTORS DO NOT RETURN!! 

        public Rectangle1()  // overloading constructors    
        {
            Console.WriteLine("My first constructor, yay! ");
            length = 1;
            width = 1;
        }

        public Rectangle1(double length)
        {
            this.length = length;   // here we passed in 4  as the double length. this.length changes the field length to 4 now. 
            this.width = 1;  //  this.width changes the field value width to 1. 
        }

        public Rectangle1(double length, double width)
        {
            this.length = length;  // the current value of length is 4 because we overloaded it above and used this.length
            this.width = width;   // the current value of 
            SetLength(length);
            SetWidth(width);
        }

        //METHODS\

        // The Rectangle class should have a GetArea() Method and a GetPerimeter() Method.
        // These should be public.
        // These should take no parameters.
        public double GetArea()
        {

            return length * width;
        }


        //The Rectangle class should have a GetLength() Method which:
        //Doesn't take any value(s).
        //Returns the current value of the length field.

        public double GetLength()
        {
            return length;
        }

        ///The Rectangle class should have a GetWidth() Method which:
       //Doesn't take any value(s).
        //Returns the current value of the width field.

        public double GetWidth()
        {
            return width;
        }

        //The Rectangle class should have a SetLength() Method which:
        //Takes a value.
        //Checks to make sure that the value is reasonable.
        //Sets the length field to that value.
        //Doesn't return anything. (below) 

        public void SetLength2(double length)
        {
            if (length >= 0)
            {
                this.length = length;
            }
        }

        //The Rectangle class should have a SetWidth() Method which:
        //Takes a value.
        //Checks to make sure that the value is reasonable.
        //Sets the width field to that value.
        //Doesn't return anything.

        public void SetWidth2(double width)
        {
            if (width >= 0)
            {
                this.width = width;
            }
        }

        public double GetPerimater()
        {
            double perimeter = (length * 2) + (width * 2);
            return perimeter;
        }

        public double SetLength(double length)
        {
            return length;
        }

        public double SetWidth(double width)
        {
            return width;
        }

 

    }
}



