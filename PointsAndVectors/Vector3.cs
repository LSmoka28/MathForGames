using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointsAndVectors
{
    class Vector3
    {
        // fields for storing values x, y, and z 
        public float x;
        public float y;
        public float z;

        // default constructor
        public Vector3()
        {
            // left intentionally blank
        }

        // will initiaize the x, y, and z fields
        public Vector3(float xArg, float yArg, float zArg)
        {
            x = xArg;
            y = yArg;
            z = zArg;
        }

        // defines an operator for adding two Vector3s
        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        }

        // defines an operator for subtracting two Vector3s
        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            return new Vector3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        }

        // defines op for multiplying the first Vector3 by a float number
        public static Vector3 operator *(Vector3 lhs, float multiplyBy)
        {
            return new Vector3(lhs.x * multiplyBy, lhs.y * multiplyBy, lhs.z * multiplyBy);
        }

        // defines op for multiplying the second Vector3 by a float number
        public static Vector3 operator *(float multiplyBy, Vector3 rhs)
        {
            return new Vector3(rhs.x * multiplyBy, rhs.y * multiplyBy, rhs.z * multiplyBy);
        }

        // defines op for diving the first Vector3 by a float number
        public static Vector3 operator /(Vector3 lhs, float divideBy)
        {
            return new Vector3(lhs.x / divideBy, lhs.y / divideBy, lhs.z / divideBy);
        }

        // defines op for diving the second Vector3 by a float number
        public static Vector3 operator /(float divideBy, Vector3 rhs)
        {
            return new Vector3(rhs.x / divideBy, rhs.y / divideBy, rhs.z / divideBy);
        }
        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }

        public float Distance(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (float)Math.Sqrt(diffX * diffX + diffY * diffY + diffZ * diffZ);
        }

        public float DistanceSqr(Vector3 other)
        {
            float diffX = x - other.x;
            float diffY = y - other.y;
            float diffZ = z - other.z;
            return (diffX * diffX + diffY * diffY + diffZ * diffZ);
        }
        public void Normalize()
        {
            float m = Magnitude();
            this.x /= m;
            this.y /= m;
            this.z /= m;
        }
    }
}
