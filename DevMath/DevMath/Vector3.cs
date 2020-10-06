using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector3
    {
        public float x;
        public float y;
        public float z;

        public float Magnitude
        {
            get
            {
                double d = (this.x * this.x) + (this.y * this.y) + (this.z * this.z);
                float answer = (float)Math.Sqrt(d);

                return answer;
            }
        }

        public Vector3 Normalized
        {
            get
            {
                float mag = Magnitude;

                Vector3 answer = new Vector3((x / mag), (y / mag), (z / mag));
                return answer;
            }
        }

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static implicit operator Vector3(Vector2 v)
        {
            return new Vector3(v.x, v.y, 0);
        }

        public static float Dot(Vector3 lhs, Vector3 rhs)
        {
            float answer = (lhs.x * rhs.x) + (lhs.y * rhs.y) + (lhs.z * rhs.z);
            return answer;
        }

        public static Vector3 Cross(Vector3 lhs, Vector3 rhs)
        {
            float cross_1 = (lhs.y * rhs.z) - (lhs.z * rhs.y);
            float cross_2 = (lhs.z * rhs.x) - (lhs.x * rhs.z);
            float cross_3 = (lhs.x * rhs.y) - (lhs.y * rhs.x);

            Vector3 answer = new Vector3(cross_1, cross_2, cross_3);

            return answer;
        }

        public static Vector3 Lerp(Vector3 a, Vector3 b, float t)
        {
            Vector3 c = a + (b - a) * t;
            return c;
        }

        public static Vector3 operator +(Vector3 lhs, Vector3 rhs)
        {
            Vector3 answer = new Vector3((lhs.x + rhs.x), (lhs.y + rhs.y), (lhs.z + rhs.z));
            return answer;
        }

        public static Vector3 operator -(Vector3 lhs, Vector3 rhs)
        {
            Vector3 answer = new Vector3((lhs.x - rhs.x), (lhs.y - rhs.y), (lhs.z - rhs.z));
            return answer;
        }

        public static Vector3 operator -(Vector3 v)
        {
            Vector3 answer = new Vector3(-v.x, -v.y, -v.z);
            return answer;
        }

        public static Vector3 operator *(Vector3 lhs, float scalar)
        {
            Vector3 answer = new Vector3((lhs.x * scalar), (lhs.y * scalar), (lhs.z * scalar));
            return answer;
        }

        public static Vector3 operator /(Vector3 lhs, float scalar)
        {
            Vector3 answer = new Vector3((lhs.x / scalar), (lhs.y / scalar), (lhs.z / scalar));
            return answer;
        }
    }
}
