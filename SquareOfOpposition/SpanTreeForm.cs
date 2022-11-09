using ControlTreeView;
using SquareOfOpposition.Common.SquareManager;
using SquareOfOpposition.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SquareOfOpposition
{
    public partial class SpanTreeForm : Form
    {
        public SpanTreeForm()
        {
            InitializeComponent();
            refreshTree();
        }

        private void refreshTree()
        {
            if(this.tableLayoutPanel.GetControlFromPosition(1, 0) != null)
            {
                tableLayoutPanel.Controls.Remove(tableLayoutPanel.GetControlFromPosition(1, 0));
            }
            var sampleCTreeView = new CTreeView
            {
                Dock = DockStyle.Fill,
                DrawStyle = CTreeViewDrawStyle.VerticalDiagram
            };
            this.tableLayoutPanel.Controls.Add(sampleCTreeView, 1, 0);
            sampleCTreeView.BeginUpdate();
            var squares = SquareManager.squareList;
            var i = 1;
            //foreach(var square in squares)
            //{
                var root = new RootNode();
                root.setTitle("Square " + i);
                sampleCTreeView.Nodes.Add(new CTreeNode("Root Node", root));
            //}
            for (int x = 0; x < 3; x++)
            {
                var node = new MyNode();
                sampleCTreeView.Nodes[0].Nodes.Add(new CTreeNode("node " + x, node));
            }
            sampleCTreeView.EndUpdate();
        }
    }
}
