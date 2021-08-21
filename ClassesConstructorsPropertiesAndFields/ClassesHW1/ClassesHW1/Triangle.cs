using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHW1
{
    class Triangle
    {
        //Fields 
        //The Triangle class should have three fields: a, b, and c(which should be private).
        //You may want to give these default values
        private double a = 3;
        private double b = 4;
        private double c = 5;

        // Constructors 

        // The Triangle class should have a Constructor that allows (requires) the caller / user to specify the values of a, b, and c each time a new Triangle is 
        // created("newwed up"). 

        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;

            // or using the getter setter called A , B , C below I can do the same thing. 

            A = a;
            B = b;
            C = c; 

        }

        //    Methods 

        // The Triangle class should have a GetArea() Method and a GetPerimeter() Method.
        // These should be public, take no parameters, and return either the Area or the Perimeter of the Triangle
        // Use Heron's Formula for the Area.

        public double GetArea()
        {
            //Herons Formula 
            // s = .5 * (a+b+c)
            // Area = Math.Sqrt( s*(s-a)*(s-b)*(s-c)) 
           double s = .5 * (a + b + c);
           double Area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
           return Area;
        }

        //The Triangle class should have a GetSides() Method which:
        //Doesn't take any values
        //Returns the current values of a, b, and c as a tuple. 

        public (double,double,double) GetSides()
        {
            return (this.a, this.b, this.c);
        }

        //The Triangle class should have a SetSides() Method which:
        //Takes values for a, b, and c
        //Checks to make sure that these values are reasonable
        //Sets the fields a, b, and c to the incoming values (if they are reasonable)
        //Doesn 't return anything.

        public void SetSides()
        {

        }

        public double A
        {
            get
            {
                return a;

            }
            set
            { 
                if(a>=0)
                {
                    a = value;
                }
            }
        }

        public double B
        {
            get
            {
                return b;

            }
            set
            {
                if (b >= 0)
                {
                    b = value;
                }
            }
        }

        public double C
        {
            get
            {
                return c;

            }
            set
            {
                if (c >= 0)
                {
                    c = value;
                }
            }
        }

    }
}
