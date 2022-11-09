﻿using ControlTreeView;
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
        public MyNode()
        {
            InitializeComponent();
        }

        public void setValues(string? upSentence, string? downSentence)
        {
            this.sentenceUpLabel.Text = upSentence;
            this.sentenceDownLabel.Text = downSentence;
        }
    }
}
