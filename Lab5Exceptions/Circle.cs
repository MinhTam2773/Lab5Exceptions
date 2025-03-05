using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5Exceptions
{
    public class Circle
    {
        private double radius;
        private const double MAX_RADIUS = 20;

        public Circle(double newRadius)
        {
            if (0 <= newRadius && newRadius <= MAX_RADIUS)
            {
                this.radius = newRadius;
            }
            else if (newRadius < 0)
            {
                throw new InvalidRadiusException(newRadius);
            }
            else if (newRadius > MAX_RADIUS)
            {
               throw new InvalidRadiusException(newRadius, MAX_RADIUS);
            }
        }

        public override string ToString()
        {
            return $"Circle[radius={radius}]";
        }
    }
}
