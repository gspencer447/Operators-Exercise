using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorExercise
{
    internal class AreaOfCircle
    {
        public static double CircleArea() 
        {
            Console.WriteLine("What is the radius of your circle?");
            double radius = double.Parse(Console.ReadLine());
            double formula = (Math.PI * radius * radius);

            return formula;
        }
    }
}
