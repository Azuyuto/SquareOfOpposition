using SquareOfOpposition.Common.Model;
using SquareOfOpposition.Common.SquareManager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareOfOpposition
{
    public partial class SquareForm : Form
    {
        public Square ParentSquare { get; set; }
        public string SquareType { get; set; }
        public Square square { get; set; }

        public SquareForm()
        {
            InitializeComponent();
            square = new Square();
        }

        public SquareForm(Square square, string squareType)
        {
            InitializeComponent();
            this.square = new Square();
            ParentSquare = square;
            SquareType = squareType;
        }

        private void SquareForm_Load(object sender, EventArgs e)
        {

        }

        protected override void OnPaint(PaintEventArgs e)
        {
            using (Pen p = new Pen(Color.Black))
            using (GraphicsPath capPath = new GraphicsPath())
            {
                // A triangle
/*                capPath.AddLine(-20, 0, 20, 0);
                capPath.AddLine(-20, 0, 0, 20);
                capPath.AddLine(0, 20, 20, 0);*/

                //poziom
                e.Graphics.DrawLine(p, 350, 130, 575, 130);
                //strzalka gora lewa
                e.Graphics.DrawLine(p, 350, 125, 350, 135);
                e.Graphics.DrawLine(p, 345, 130, 350, 135);
                e.Graphics.DrawLine(p, 345, 130, 350, 125);
                //strzalka gora prawa
                e.Graphics.DrawLine(p, 575, 125, 575, 135);
                e.Graphics.DrawLine(p, 580, 130, 575, 135);
                e.Graphics.DrawLine(p, 580, 130, 575, 125);

                e.Graphics.DrawLine(p, 350, 425, 575, 425);
                //strzalka dol lewa
                e.Graphics.DrawLine(p, 350, 420, 350, 430);
                e.Graphics.DrawLine(p, 345, 425, 350, 430);
                e.Graphics.DrawLine(p, 345, 425, 350, 420);
                //strzalka dol prawa
                e.Graphics.DrawLine(p, 575, 420, 575, 430);
                e.Graphics.DrawLine(p, 580, 425, 575, 430);
                e.Graphics.DrawLine(p, 580, 425, 575, 420);


                //pion
                e.Graphics.DrawLine(p, 260, 150, 260, 400);
                //strzalka lewa gora
                e.Graphics.DrawLine(p, 255, 150, 265, 150);
                e.Graphics.DrawLine(p, 255, 150, 260, 145);
                e.Graphics.DrawLine(p, 265, 150, 260, 145);
                //strzalka lewa dolna
                e.Graphics.DrawLine(p, 255, 400, 265, 400);
                e.Graphics.DrawLine(p, 255, 400, 260, 405);
                e.Graphics.DrawLine(p, 265, 400, 260, 405);


                e.Graphics.DrawLine(p, 675, 150, 675, 400);
                //strzalka prawa gora
                e.Graphics.DrawLine(p, 670, 150, 680, 150);
                e.Graphics.DrawLine(p, 670, 150, 675, 145);
                e.Graphics.DrawLine(p, 680, 150, 675, 145);
                //strzalka prawa dolna
                e.Graphics.DrawLine(p, 670, 400, 680, 400);
                e.Graphics.DrawLine(p, 670, 400, 675, 405);
                e.Graphics.DrawLine(p, 680, 400, 675, 405);

                //skos
                e.Graphics.DrawLine(p, 350, 150, 575, 400);
                //strzalka skos gora lewa
                e.Graphics.DrawLine(p, 347, 153, 353, 147);
                e.Graphics.DrawLine(p, 347, 153, 347, 147);
                e.Graphics.DrawLine(p, 347, 147, 353, 147);
                //strzalka skos dol prawa
                e.Graphics.DrawLine(p, 572, 403, 578, 397);
                e.Graphics.DrawLine(p, 572, 403, 578, 403);
                e.Graphics.DrawLine(p, 578, 403, 578, 397);

                e.Graphics.DrawLine(p, 350, 400, 575, 150);
                //strzalka skos gora prawa
                e.Graphics.DrawLine(p, 572, 147, 578, 153);
                e.Graphics.DrawLine(p, 572, 147, 578, 147);
                e.Graphics.DrawLine(p, 578, 153, 578, 147);
                //strzalka skos dol lewa
                e.Graphics.DrawLine(p, 347, 397, 353, 403);
                e.Graphics.DrawLine(p, 347, 397, 347, 403);
                e.Graphics.DrawLine(p, 347, 403, 353, 403);

                e.Graphics.DrawPath(p, capPath);
                /*                p.CustomEndCap = new System.Drawing.Drawing2D.CustomLineCap(null, capPath);*/
            }
        }

        private void SaPTxt_TextChanged(object sender, EventArgs e)
        {
            square.SaP = SaPTxt.Text;
        }

        private void SiPTxt_TextChanged(object sender, EventArgs e)
        {
            square.SiP = SiPTxt.Text;
        }

        private void SoPTxt_TextChanged(object sender, EventArgs e)
        {
            square.SoP = SoPTxt.Text;
        }

        private void SePTxt_TextChanged(object sender, EventArgs e)
        {
            square.SeP = SePTxt.Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SquareManager.addToSquareList(square, ParentSquare, SquareType);
            SpanTreeForm.Instance.RefreshTree();
            MachineStateForm.Instance.RefreshTree();
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
