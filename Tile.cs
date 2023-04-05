using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractionGame
{
    public class Tile
    {
        int crystal;
        int processedCrystals;
        int fog;
        public PointF mapLocation;

        public Tile(int crystal, int processedCrystals, int fog, PointF mapLocation)
        {
            this.crystal = crystal;
            this.processedCrystals = processedCrystals;
            this.fog = fog;
            this.mapLocation = mapLocation;
        }
        public void Draw(Graphics handler)
        {
            int dX = 20, dY = 20;
            handler.FillRectangle(Brushes.Brown, mapLocation.X * dX, mapLocation.Y * dY, dX, dY);
            handler.DrawRectangle(Pens.Black, mapLocation.X * dX, mapLocation.Y * dY, dX, dY);

        }
    }
}
