using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
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

        static double ExerciseD()
        {
            double xVal = 2;
            double yVal = 5;
            Console.Write("Input the value of position 1: ");
            int Pos1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of position 2: ");
            int Pos2 = Convert.ToInt32(Console.ReadLine());

            double sumX = (xVal * Pos1) - (xVal * Pos2);
            double xPos = sumX * sumX;

            double sumY = (yVal * Pos1) - (yVal * Pos2);
            double yPos = sumY * sumY;

            double distance = Math.Sqrt(xPos + yPos);

            Console.WriteLine(distance);
            return distance;

        }

        static int ExerciseE(int x, int y, int z)
        {
           
            Console.Write("Input the value of P pos: ");
            int pVal = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the value of Q pos: ");
            int qVal = Convert.ToInt32(Console.ReadLine());

            int pqX = (pVal * x) * (qVal * x);
            int pqY = (pVal * y) * (qVal * y);
            int pqZ = (pVal * z) * (pVal * z);

            int innerProduct = pqX + pqY + pqZ;

            Console.WriteLine($"the inner product of Pxyz and Qxyz is: {innerProduct}\n");
            return innerProduct;

        }

        static void ExerciseF()
        {
          
        }

        static void ExerciseG()
        {

        }


        static void Main(string[] args)
        {
            Console.WriteLine(ExerciseA(7));

            ExerciseB();

            Console.WriteLine(ExerciseC(3, 5, 6));

            ExerciseD();

            ExerciseE(2, 3, 5);

            Console.ReadKey();

        }
    }
}
