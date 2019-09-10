using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IKEA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            //Graphic objects
            Graphics g = this.CreateGraphics();
            Pen drawPenB = new Pen(Color.Blue, 5);
            Pen drawPenR = new Pen(Color.Blue, 1);
            Pen drawPenY = new Pen(Color.Yellow, 5);
            SolidBrush drawBrushY = new SolidBrush(Color.Yellow);
            SolidBrush drawBrushB = new SolidBrush(Color.Blue);
            Font drawFont = new Font("Futura", 40, FontStyle.Bold);
            Font drawFontR = new Font("Futura", 7, FontStyle.Regular);

            //Code for shapes
            g.DrawRectangle(drawPenB, 40, 40, 200, 100);
            g.FillRectangle(drawBrushB, 40, 40, 200, 100);
            g.DrawEllipse(drawPenY, 45, 55, 190, 70);
            g.FillEllipse(drawBrushY, 45, 55, 190, 70);
            g.DrawEllipse(drawPenR, 198, 67, 10, 10);

            //Code for Text
            g.DrawString("IKEA", drawFont, drawBrushB, 70, 60);
            g.DrawString("R", drawFontR, drawBrushB, 198, 66);
        }
    }
}
