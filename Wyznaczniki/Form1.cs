using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyznaczniki
{
    public partial class Form1 : Form
    {

        Calculator calc;
        Graphics gph;
        Chart chart;
        public Form1()
        {
            InitializeComponent();
            calc = new Calculator();
            gph = CreateGraphics();
            chart = new Chart();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (calc.Calculate(float.Parse(xProperty.Text), float.Parse(yProperty.Text), float.Parse(freeWords.Text),
                float.Parse(xProperty1.Text), float.Parse(yProperty1.Text), float.Parse(freeWords1.Text)))
            {
                ShowStats();

                xSum.Text = calc.X.ToString();
                ySum.Text = calc.Y.ToString();
            }
            else
                ShowStats();
            

            
        }

        public void ShowStats()
        {
            w.Text = calc.W.ToString();
            wx.Text = calc.Wx.ToString();
            wy.Text = calc.Wy.ToString();
        }

        public void DrawIt()
        {
            chart.DrawChart(gph, )
        }
    }
}
