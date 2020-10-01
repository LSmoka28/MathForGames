using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAndVectors
{
    class Vector2
    {
        // fields for storing values x and y 
        public float x;
        public float y;
        // default constructor

        public Vector2()
        {
            // left intentionally blank
        }

        // will initiaize the x and y fields
        public Vector2(float xArg, float yArg)
        {
            x = xArg;
            y = yArg;
        }

        // defines an operator for adding two Vector2s
        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x + rhs.x, lhs.y + rhs.y);
        }

        // defines operator for subtracting two Vector2s
        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            return new Vector2(lhs.x - rhs.x, lhs.y - rhs.y);
        }

        // defines op for multiplying the first Vector2 by a float number
        public static Vector2 operator *(Vector2 lhs, float multiplyBy)
        {
            return new Vector2(lhs.x * multiplyBy, lhs.y * multiplyBy);
        }

        // defines op for multiplying the second Vector2 by a float number
        public static Vector2 operator *(float multiplyBy, Vector2 rhs)
        {
            return new Vector2(rhs.x * multiplyBy, rhs.y * multiplyBy);
        }

        // defines op for diving the first Vector2 by a float number
        public static Vector2 operator /(Vector2 lhs, float divideBy)
        {
            return new Vector2(lhs.x / divideBy, lhs.y / divideBy);
        }
        
        // defines op for diving the second Vector2 by a float number
        public static Vector2 operator /(float divideBy, Vector2 rhs)
        {
            return new Vector2(rhs.x / divideBy, rhs.y / divideBy);
        }
    }
}
