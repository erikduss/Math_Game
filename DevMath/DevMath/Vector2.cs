using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public struct Vector2
    {
        public float x;
        public float y;

        public float Magnitude
        {
            
            get 
            {
                double d = (this.x * this.x) + (this.y * this.y);
                float answer = (float)Math.Sqrt(d);

                return answer;
            }
        }

        public Vector2 Normalized
        {
            get 
            {
                float mag = Magnitude;

                Vector2 answer = new Vector2((x / mag), (y / mag));
                return answer;
            }
        }

        public Vector2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public static float Dot(Vector2 lhs, Vector2 rhs)
        {
            float answer = (lhs.x * rhs.x) + (lhs.y * rhs.y);
            return answer;
        }

        public static Vector2 Lerp(Vector2 a, Vector2 b, float t)
        {
            Vector2 c = a + (b - a) * t;
            return c;
        }

        public static float Angle(Vector2 lhs, Vector2 rhs)
        {
            double yCalc = (double)rhs.y - lhs.y;
            double xCalc = (double)rhs.x - lhs.x;

            return (float)Math.Atan2(yCalc, xCalc);
        }

        public static Vector2 DirectionFromAngle(float angle)
        {
            double ca = Math.Cos(angle);
            double sa = Math.Sin(angle);

            return new Vector2((float)ca, (float)sa);
        }

        public static Vector2 operator +(Vector2 lhs, Vector2 rhs)
        {
            Vector2 answer = new Vector2((lhs.x + rhs.x), (lhs.y + rhs.y));
            return answer;
        }

        public static Vector2 operator -(Vector2 lhs, Vector2 rhs)
        {
            Vector2 answer = new Vector2((lhs.x - rhs.x), (lhs.y - rhs.y));
            return answer;
        }

        public static Vector2 operator -(Vector2 v)
        {
            Vector2 answer = new Vector2(-v.x, -v.y);
            return answer;
        }

        public static Vector2 operator *(Vector2 lhs, float scalar)
        {
            Vector2 answer = new Vector2((lhs.x * scalar), (lhs.y * scalar));
            return answer;
        }

        public static Vector2 operator /(Vector2 lhs, float scalar)
        {
            Vector2 answer = new Vector2((lhs.x / scalar), (lhs.y / scalar));
            return answer;
        }
    }
}
