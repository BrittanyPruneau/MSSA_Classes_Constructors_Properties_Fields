using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ClassesHW1
{
    class Square
    {
        //FIELDS
        private double side = 10;  // field
        public double newside = 10; 


        //CONSTRUCTOR 
        public Square()
        {
            this.side = 4;  // changed the value of the field side to 4. 
        }
        public Square(double side)       // ??  like this?  //The Square class should have a Constructor that allows (requires) the caller / user to specify the value of side each time a new Square is created("newwed up"). 
        {
            this.side = side;   // changes value of the field side to 5. 
        }

        public Square(double side, double other)
        {
            Side = side;
            Console.WriteLine("Whats in the Getter: {0} or {1}", Side, side);
        }

        //METHODS

        //The Square class should have a GetArea() Method and a GetPerimeter() Method.
        //These should be public, take no parameters, and return either the Area or the Perimeter of the Square.

        public double GetArea()
        {
            double area = side * side;
            return area;
        }

        public double GetPerimeter()
        {
            double Perimeter = 4 * side;
            return Perimeter; 
        }

        //The Square class should have a GetSide() Method which:
        //Doesn 't take any values
        //Returns the current value of the side field.

        public double GetSide()
        {
            return this.side; 
        }

        //The Square class should have a SetSide() Method which:
        //Takes a value
        //Checks to make sure that the value is reasonable
        //Sets the field side to that value
        //Doesn't return anything.

        public void SetSide(double side)
        {
            if (side >= 0)
            {
                this.side = side;
            }
        }

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                if(value > 0)
                {
                    side = value;
                }
            }
        }


    }
}




//Part 1: Create A Square class
//Create a Square class. It will be similar to the Circle class that was Demo'd and the Rectangle class from the Lab.
//The Square class should have only one field: side(which should be private).
//You may want to give side a default value
//The Square class should have a Constructor that allows (requires) the caller / user to specify the value of side each time a new Square is created("newwed up").
//The Square class should have a GetArea() Method and a GetPerimeter() Method.
//These should be public, take no parameters, and return either the Area or the Perimeter of the Square.
//The Square class should have a GetSide() Method which:
//Doesn 't take any values
//Returns the current value of the side field.


//The Square class should have a SetSide() Method which:
//Takes a value
//Checks to make sure that the value is reasonable
//Sets the field side to that value
//Doesn't return anything.
//Your Square class should be well tested.

//Part 2: Create A Triangle class

//Create a Triangle class. It will be similar to the Circle class that was Demo'd, the Rectangle class from the Lab, and the Square class above.

//The Triangle class should have three fields: a, b, and c(which should be private).
//You may want to give these default values
//The Triangle class should have a Constructor that allows (requires) the caller / user to specify the values of a, b, and c each time a new Triangle is created("newwed up").
//The Triangle class should have a GetArea() Method and a GetPerimeter() Method.
//These should be public, take no parameters, and return either the Area or the Perimeter of the Triangle
//Use Heron's Formula for the Area
//The Triangle class should have a GetSides() Method which:
//Doesn 't take any values
//Returns the current values of a, b, and c as a tuple
//The Triangle class should have a SetSides() Method which:
//Takes values for a, b, and c
//Checks to make sure that these values are reasonable
//Sets the fields a, b, and c to the incoming values (if they are reasonable)
//Doesn 't return anything.
//Deliverable: Submit a ".zip" file of your entire project (solution). It should include both Square.cs and Triangle.cs. In each of these two classes / files:

//All Fields should be private
//The Constructors should be public
//All Methods should be public
//Nothing should be static
//These should all be well-tested and working
//Test from Main() in Program.cs
//I will try and break them