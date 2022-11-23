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
    }
}
