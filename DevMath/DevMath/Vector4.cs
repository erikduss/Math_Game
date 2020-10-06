using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector4
    {
        public float x;
        public float y;
        public float z;
        public float w;

        public float Magnitude
        {
            get
            {
                double d = (this.x * this.x) + (this.y * this.y) + (this.z * this.z) + (this.w * this.w);
                float answer = (float)Math.Sqrt(d);

                return answer;
            }
        }

        public Vector4 Normalized
        {
            get
            {
                float mag = Magnitude;

                Vector4 answer = new Vector4((x / mag), (y / mag), (z / mag), (w / mag));
                return answer;
            }
        }

        public Vector4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        public static implicit operator Vector4(Vector3 v)
        {
            return new Vector4(v.x, v.y, v.z, 0);
        }

        public static float Dot(Vector4 lhs, Vector4 rhs)
        {
            float answer = (lhs.x * rhs.x) + (lhs.y * rhs.y) + (lhs.z * rhs.z) + (lhs.w * rhs.w);
            return answer;
        }

        public static Vector4 Lerp(Vector4 a, Vector4 b, float t)
        {
            Vector4 c = a + (b - a) * t;
            return c;
        }

        public static Vector4 operator +(Vector4 lhs, Vector4 rhs)
        {
            Vector4 answer = new Vector4((lhs.x + rhs.x), (lhs.y + rhs.y), (lhs.z + rhs.z), (lhs.w + rhs.w));
            return answer;
        }

        public static Vector4 operator -(Vector4 lhs, Vector4 rhs)
        {
            Vector4 answer = new Vector4((lhs.x - rhs.x), (lhs.y - rhs.y), (lhs.z - rhs.z), (lhs.w - rhs.w));
            return answer;
        }

        public static Vector4 operator -(Vector4 v)
        {
            Vector4 answer = new Vector4(-v.x, -v.y, -v.z, -v.w);
            return answer;
        }

        public static Vector4 operator *(Vector4 lhs, float scalar)
        {
            Vector4 answer = new Vector4((lhs.x * scalar), (lhs.y * scalar), (lhs.z * scalar), (lhs.w * scalar));
            return answer;
        }

        public static Vector4 operator /(Vector4 lhs, float scalar)
        {
            Vector4 answer = new Vector4((lhs.x / scalar), (lhs.y / scalar), (lhs.z / scalar), (lhs.w / scalar));
            return answer;
        }
    }
}
