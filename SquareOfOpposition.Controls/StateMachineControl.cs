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
            this.Paint += new PaintEventHandler(this.PaintControl);
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
                drawArrow();
            }
            else
            {
                pressedButton = (RoundButton)sender;
            }
        }

        private void drawArrow()
        {
            if (pressedButton != null)
            {
                // press second button and draw line

                pressedButton = null;
            }
        }
        private void PaintControl(object sender, PaintEventArgs e)
        {
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
