/*
 * Program Title: PROG2070_TPhillipsAssignment1
 * 
 * Date Modified: 2019/02/04
 * 
 */
using System;

namespace TPhillipsAssignment1
{
    public class Circle
    {
        private int circleRadius;

        public Circle()
        {
            circleRadius = 1;
        }

        public int GetRadius()
        {
            return circleRadius;
        }

        public void SetRadius(int radius)
        {
            circleRadius = radius;
        }

        public double GetCircumference()
        {
            double circumference = 2 * Math.PI * circleRadius;
            circumference = Math.Round(circumference, 2);
            return circumference;
        }

        public double GetArea()
        {
            double area = Math.PI * (circleRadius * circleRadius);
            area = Math.Round(area, 2);
            return area;
        }
    }
}
