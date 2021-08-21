using System;

namespace Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle1 r1 = new Rectangle1();
            Rectangle1 r2 = new Rectangle1(4);
            Rectangle1 r3 = new Rectangle1(10, 4);
           
            Console.WriteLine(r1.GetPerimater());
            r2.SetLength(18);
        }
    }
}
