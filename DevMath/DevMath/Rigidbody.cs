﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevMath
{
    public class Rigidbody
    {
        public Vector2 Velocity
        {
            get; private set;
        }

        public float mass = 1.0f;
        public float force = 150.0f;
        public float dragCoefficient = .47f;

        public void AddForce(Vector2 forceDirection, float deltaTime)
        {
            float acceleration = force / mass;

            /*var friction = dragCoefficient * force;
            var fnetto = force - friction;

            Vector2 verplaatsing = Velocity * deltaTime;*/

            Velocity = (-forceDirection * force / mass) * deltaTime;
        }
    }
}
