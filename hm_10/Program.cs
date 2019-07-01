using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hm_10
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapeArray = new Shape[3];

            Random rand = new Random();

            shapeArray[0] = new Square(rand.Next(1, 11));
            shapeArray[1] = new Triangle(rand.Next(1, 11));
            shapeArray[2] = new Circle(rand.Next(1, 11));

            foreach (var shape in shapeArray)
            {
               Console.WriteLine($"This is \" {shape.GetType().Name} with {shape.length} \". CLR Type is {shape.GetType().FullName}. Area is {shape.GetArea()}");
            }

            Console.ReadKey();
        }
    }
 }

