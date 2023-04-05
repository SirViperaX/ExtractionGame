using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractionGame
{
    public static class Engine
    {
        public static PointF[] RegularPolygon(PointF mapLocation, float radius, int n, float rotAngle)
        {
            float alpha = (float)(Math.PI * 2 / n);
            PointF[] toR = new PointF[n];
            for (int i = 0; i < n; i++)
            {
                float x = mapLocation.X + radius * (float) Math.Cos(i * alpha + rotAngle);
                float y = mapLocation.Y + radius * (float) Math.Sin(i * alpha + rotAngle);
                toR[i]= new PointF(x,y);
            }
            return toR;
        }
    }
}
