using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExtractionGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyGraphics g = new MyGraphics();
            g.InitGraph(pictureBox1);
            Map map1 = new Map(20, 30);
            /*for(float t = 0; t<=(float)Math.PI/2; t+=0.01f)
            {
                PointF[] points = Engine.RegularPolygon(new PointF(200, 200), 150, 4, t);
                g.grp.DrawPolygon(Pens.Black, points);
            }*/
            map1.Draw(g.grp);
            g.RefreshGraph();

        }
    }
}
