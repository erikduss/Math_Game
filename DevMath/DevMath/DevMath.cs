using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class DevMath
    {
        public static float Lerp(float a, float b, float t)
        {
            float c = a + (b - a) * t;
            return c;
        }

        public static float DistanceTraveled(float startVelocity, float acceleration, float time)
        {
            float answer = (startVelocity * time) + (0.5f * acceleration * (time * time));
            return answer;
        }

        public static float Clamp(float value, float min, float max)
        {
            return (value < min) ? min : (value > max) ? max : value;
        }

        public static float RadToDeg(float angle)
        {
            float answer = (float)((180 / Math.PI) * angle);
            return answer;
        }

        public static float DegToRad(float angle)
        {
            float answer = (float)((Math.PI / 180) * angle);
            return answer;
        }
    }
}
