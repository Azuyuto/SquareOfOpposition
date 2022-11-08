using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareOfOpposition.Controls
{
    public partial class SpanTreeControl : UserControl
    {
        public SpanTreeControl()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black))
            using (GraphicsPath capPath = new GraphicsPath())
            {
                // A triangle
                capPath.AddLine(-20, 0, 20, 0);
                capPath.AddLine(-20, 0, 0, 20);
                capPath.AddLine(0, 20, 20, 0);

                p.CustomEndCap = new System.Drawing.Drawing2D.CustomLineCap(null, capPath);

                e.Graphics.DrawLine(p, 0, 50, 100, 50);
            }
        }
    }
}
