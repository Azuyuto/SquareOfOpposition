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
    public partial class MyNode : NodeControl
    {
        public Square ParentSquare { get; set; }
        public string SquareType { get; set; }

        public MyNode()
        {
            InitializeComponent();
        }

        public void setValues(string? upSentence, string? downSentence, Square square, string squareType)
        {
            this.sentenceUpLabel.Text = upSentence;
            this.sentenceDownLabel.Text = downSentence;
            ParentSquare = square;
            SquareType = squareType;
        }

        public event EventHandler<ButtonClick> ButtonClick;

        private void addSquareButton_Click(object sender, EventArgs e)
        {
            EventHandler<ButtonClick> handler = ButtonClick;
            if (handler != null)
            {
                handler(this, new ButtonClick() { 
                    ParentSquare = ParentSquare,
                    SquareType = SquareType
                });
            }
        }
    }

    public class ButtonClick : EventArgs
    {
        public Square ParentSquare { get; set; }
        public string SquareType { get; set; }
    }
}
