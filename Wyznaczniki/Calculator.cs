using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wyznaczniki
{
    class Calculator
    {
        public float X
        {
            get
            {
                return Wx / W;
            }
        }
        public float Y
        {
            get
            {
                return Wy / W;
            }
        }

        public float W { get; set; }
        public float Wx { get; set; }
        public float Wy { get; set; }

        public bool Calculate(float a, float b, float c, float a1, float b1, float c1)
        {
            W = a * b1 - a1 * b;
            Wx = c * b1 - c1 * b;
            Wy = a * c1 - a1 * c;



            if (W == 0)
            {
                if (Wx != 0 || Wy != 0)
                {
                    MessageBox.Show("Układ sprzeczny!");
                    return false;
                }
                else
                {
                    MessageBox.Show("Układ nieoznaczony!");
                    return false;
                }

            }
            else
                return true;
    
        }
    }
}
