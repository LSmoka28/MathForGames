using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathFormulas
{
    class Program
    {
        static float ExerciseA(float x)
        {
            float result = x * x + 2 * x - 7;
            return result;
        }

        static void ExerciseB()
        {
            int a, b, c;
            double d, x1, x2;

            Console.Write("Input the value of a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of b: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of c: ");
            c = Convert.ToInt32(Console.ReadLine());

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                Console.Write("Both roots are equal.\n");
                x1 = -b / (2.0 * a);
                x2 = x1;
                
            }
            else if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                Console.WriteLine($"Root 1: {x1}\n" +
                    $"Root 2: {x2}\n");
            }
            else
            {
                Console.WriteLine($"No solution");
            }
            
        }

        static int ExerciseC(int s, int e, int t)
        {
            int result = s + (t * (e - s));
            return result;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ExerciseA(7));

            ExerciseB();

            Console.WriteLine(ExerciseC(3, 5, 6));
            Console.ReadKey();

        }
    }
}
