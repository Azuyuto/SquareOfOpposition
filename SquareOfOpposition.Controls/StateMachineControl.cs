using ControlTreeView;
using SquareOfOpposition.Common.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareOfOpposition.Controls
{
    public partial class StateMachineControl : NodeControl
    {
        RoundButton pressedButton;
        Square square;
        public StateMachineControl()
        {
            InitializeComponent();
            RotateArrow();
        }

        private void RotateArrow()
        {
            Image imgArrowAIEO = this.arrowAIEO.Image;
            imgArrowAIEO.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.arrowAIEO.Image = imgArrowAIEO;

            Image imgArrowIOEO = this.arrowIOEO.Image;
            imgArrowIOEO.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            this.arrowIOEO.Image = imgArrowIOEO;

            Image imgArrowAIIO = this.arrowAIIO.Image;
            imgArrowAIIO.RotateFlip(RotateFlipType.RotateNoneFlipY);
            this.arrowAIIO.Image = imgArrowAIIO;

            Image imgArrowIOAI = this.arrowIOAI.Image;
            imgArrowIOAI.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.arrowIOAI.Image = imgArrowIOAI;
        }

        public void setValue(Square square)
        {
            this.square = square;
        }

        private void StateMachineControl_Load(object sender, EventArgs e)
        {
        }

        private void drawArrow()
        {
            if (pressedButton != null)
            {
                // press second button and draw line
            }
        }

        private void AIButton_Click(object sender, EventArgs e)
        {
            pressedButton = (RoundButton)sender;
        }

        private void EOButton_Click(object sender, EventArgs e)
        {

        }

        private void IOButton_Click(object sender, EventArgs e)
        {

        }

        private void frame_Paint(object sender, PaintEventArgs e)
        {
            DoubleBuffered = true;
            for (int i = 0; i < Controls.Count; i++)
                if (Controls[i].GetType() == typeof(PictureBox))
                {
                    var p = Controls[i] as PictureBox;
                    p.Visible = false;
                    e.Graphics.DrawImage(p.Image, p.Left, p.Top, p.Width, p.Height);
                }
        }
    }
}
