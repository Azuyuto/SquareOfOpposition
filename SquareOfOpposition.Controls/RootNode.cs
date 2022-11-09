using ControlTreeView;
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
    public partial class RootNode : NodeControl
    {
        public RootNode()
        {
            InitializeComponent();
        }

        public void setTitle(string title)
        {
            this.inLabel.Text = title;
        }
    }
}
