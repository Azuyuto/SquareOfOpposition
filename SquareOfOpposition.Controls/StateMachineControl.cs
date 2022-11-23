using ControlTreeView;
using SquareOfOpposition.Common.Model;
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
            Image imgArrowEOAI = this.arrowEOAI.Image;
            imgArrowEOAI.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.arrowEOAI.Image = imgArrowEOAI;

            Image imgArrowIOEO = this.arrowIOEO.Image;
            imgArrowIOEO.RotateFlip(RotateFlipType.RotateNoneFlipXY);
            this.arrowIOEO.Image = imgArrowIOEO;

            Image imgArrowAIIO = this.arrowAIIO.Image;
            imgArrowAIIO.RotateFlip(RotateFlipType.RotateNoneFlipX);
            this.arrowAIIO.Image = imgArrowAIIO;

            Image imgArrowIOAI = this.arrowIOAI.Image;
            imgArrowIOAI.RotateFlip(RotateFlipType.RotateNoneFlipY);
            this.arrowIOAI.Image = imgArrowIOAI;
        }

        public void setValue(Square square)
        {
            this.square = square;
        }

        private void StateMachineControl_Load(object sender, EventArgs e)
        {
            
        }

        private void AIButton_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void EOButton_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void IOButton_Click(object sender, EventArgs e)
        {
            HandleButtonClick(sender);
        }

        private void HandleButtonClick(object sender)
        {
            if (pressedButton != null)
            {
                drawArrow((RoundButton)sender);
            }
            else
            {
                pressedButton = (RoundButton)sender;
            }
        }

        private void drawArrow(RoundButton secondButton)
        {
            if (pressedButton != null)
            {
                var arrowStringValue = "arrow" + pressedButton.Text + secondButton.Text;
                var arrowControl = this.Controls.Find(arrowStringValue, false).FirstOrDefault();

                if(arrowControl != null)
                {
                    if ((bool?)arrowControl.Tag == null || (bool?)arrowControl.Tag == true)
                    {
                        arrowControl.Tag = false;
                    }
                    else
                    {
                        arrowControl.Tag = true;
                    }
                }

                this.Invalidate();
                this.Update();

                pressedButton = null;
            }
        }

        private void frame_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.White);
            DoubleBuffered = true;
            for (int i = 0; i < Controls.Count; i++)
                if (Controls[i].GetType() == typeof(PictureBox))
                {
                    var p = Controls[i] as PictureBox;
                    if((bool?)p.Tag == null || (bool?)p.Tag == true)
                    {
                        e.Graphics.DrawImage(p.Image, p.Left, p.Top, p.Width, p.Height);
                    }
                    p.Visible = false;
                }

            StateMachineControl panel = (StateMachineControl)sender;
            float width = (float)4.0;
            Pen pen = new Pen(SystemColors.ControlDark, width);
            pen.DashStyle = DashStyle.Dot;
            e.Graphics.DrawLine(pen, 0, 0, 0, panel.Height - 0);
            e.Graphics.DrawLine(pen, 0, 0, panel.Width - 0, 0);
            e.Graphics.DrawLine(pen, panel.Width - 2, panel.Height - 2, 0, panel.Height - 2);
            e.Graphics.DrawLine(pen, panel.Width - 2, panel.Height - 2, panel.Width - 2, 0);
        }
    }
}
