using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAndVectors
{
    class Program
    {
        /*  2. What is the magnitude of the following Vectors:
                a. { 1, 1, 1 } = 1.732051
                b. { 3, -2 } = 3.605551
                c. { -1, 1, -1 } = 1.732051
                d. { 0.5, -1, 0.25 } = 1.145644
        
            3. What is the distance between the following Points:
                a. { -2, 5.5 } and { 9, -22 } = 29.61841
                b. { 0, 1, 2 } and { 9, -2, 7 } = 10.72381
         */


        static void Main(string[] args)
        {
            Vector2 tmpPlayer = new Vector2(-2, 5.5f);
            Vector2 tmpEnemy = new Vector2(9, -22);
            Vector3 playerPos = new Vector3(5, 4, 2);
            Vector3 enemyPos = new Vector3(9, -2, 7);


            Console.WriteLine(playerPos.Magnitude());
            playerPos.Normalize();
            Console.WriteLine(playerPos.x);
            Console.ReadKey();



        }
    }
}
