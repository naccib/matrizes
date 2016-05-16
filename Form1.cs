using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace eMedic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatAppearance.MouseOverBackColor = ColorHelper.RemoveFromColor(CloseButton.BackColor, 40);

            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseOverBackColor = Color.Gainsboro;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }

    public static class ColorHelper
    {
        public static Color RemoveFromColor(Color C, int value)
        {
            int nR, nG, nB;

            nR = C.R - value;
            nG = C.G - value;
            nB = C.B - value;

            if (nR < 0) nR = 0;
            if (nG < 0) nG = 0;
            if (nB < 0) nB = 0;

            return Color.FromArgb(nR, nG, nB);
        }
    }
}
