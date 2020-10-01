using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trigonometry
{
    class Program
    {
        /* 1. The lecture mentioned that one radian is approximately 57 degrees. What is it exactly (or to
                at least three decimal places)?

                - 57.295 or 57.3 if rounded 
         
         
         2. A typical field of view used in 3D games is sixty degrees. What is this in radians?

                - Radians = (60 degrees/180 degrees) * Pi = (.333) * Pi = 1.047rad



         3. Most people think in terms of degrees rather than radians, but most maths algorithms
            and/or libraries require radians rather than degrees. Your programs will therefore need to
            convert between one and the other.
            
            Write a pair of functions that will:

         */

        // Convert from degrees to radians
        static void DegreeToRadian()
        {
            Console.WriteLine($"Conversion from Deg to Rad\nWhat is the degree?");
            double degree = double.Parse(Console.ReadLine());

            double radian = ((degree / 180) * Math.PI);
            Console.WriteLine($"the radian value is {radian}\n");
        }

        // Convert from radians to degrees
        static double RadianToDegree(double radian)
        {
            double degree = ((radian * 180) / Math.PI);
            return degree;
        }

        /* 
         
         4. It is thought that the ancient Egyptians marked out the right angles around their buildings by
            employing a loop of rope with 12 knots spaced out equally along its length. They would wrap
            the rope around three stakes in the ground to form a triangle, placing each stake at the
            exact location of a knot in the rope. By adjusting the stakes so that each stake is exactly at
            the position of a knot and the rope is kept taut, they could get the stakes to form an exact
            right-angle with each other. 
         
                - with 12 knots using a 3, 4, and 5, sided triangle with result in a right triangle
       
         5. Again consider the three stakes laid out by the Egyptians to form a right-angled triangle.
            Given that one of the angles is a right angle, what are the other two angles?
        
                - Sin value = .6 = 36.86 deg
                - Cos value = .8 = 53.13 deg
         
        6. For the next two exercises, you’ll need a calculator equipped with trig functions.
           Alternatively, you can use the calculator built in to Windows, but you’ll need to set it up for
           ‘Scientific’ operations (one of the options on the View menu).
            
            Find the length of ‘x’

                - x = 21.20444
                - find x by sin(angle B)/ sin(angle C) * length of side c
                
        
        7. Given the following triangle:
           
           Find the size of the specified angle
            side a = 8
            side b = 6
            side c = 9
            
                - angle = 29.34
                - find angle A by side b ^ 2 + side c ^ 2 - side a ^ 2 / (b*c)*2


                
        8. Challenge
        Write a function to compute all three angles of a triangle given the length of all of its sides.
        Test out your function by solving the triangle given in Exercise 7 above.
            side a = 8
            side b = 6
            side c = 9
         */

        static void FindAngles(double sideA, double sideB, double sideC)
        {
            double angleA = (((sideB * sideB) + (sideC * sideC)) - (sideA * sideA)) / ((sideB * sideC) * 2);
            double angleB = (((sideA * sideA) + (sideC * sideC)) - (sideB * sideB)) / ((sideA * sideC) * 2);
            double angleC = (((sideA * sideA) + (sideB * sideB)) - (sideC * sideC)) / ((sideA * sideB) * 2);

            Console.WriteLine($"Cos A: {angleA}");
            Console.WriteLine($"Cos B: {angleB}");
            Console.WriteLine($"Cos C: {angleC}");

            angleA = Math.Acos(angleA);
            angleB = Math.Acos(angleB);
            angleC = Math.Acos(angleC);


            Console.WriteLine($"Angle B: {RadianToDegree(angleA)}");
            Console.WriteLine($"Angle B: {RadianToDegree(angleB)}");
            Console.WriteLine($"Angle C: {RadianToDegree(angleC)}");
        }



        static void Main(string[] args)
        {
            FindAngles(8, 6, 9);

            Console.ReadKey();
        }
    }
}
