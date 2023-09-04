using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Slugs.Drawing
{
    public partial class Form1 : Form
    {
        private Graphics graphics;
        private Pen pen;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            pen = new Pen(Color.Red);
            graphics = e.Graphics;
            graphics.DrawEllipse(pen, new Rectangle(0, 0, 30, 30));

            pen.Dispose();
            graphics.Dispose();
        }
    }
}
