using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Circle
    {
        public Vector2 Position
        {
            get; set;
        }

        public float Radius
        {
            get; set;
        }

        public bool CollidesWith(Circle circle)
        {
            float circlesX = (circle.Position.x - Position.x);
            float circlesY = (Position.y - circle.Position.y);
            float circlesRad = (Radius + circle.Radius);

            bool answer = ((circlesX * circlesX) + (circlesY * circlesY)) <= (circlesRad * circlesRad);

            return answer;
        }
    }
}
