using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Wyznaczniki
{
    class Chart
    {
        

        public void DrawChart(Graphics graph, float a, float b)
        {
            for (int i = 0; i < 200; i++)
            {
                graph.FillRectangle(Brushes.Black, i, a * i + b, 2, 2);
            }
        }
    }
}
