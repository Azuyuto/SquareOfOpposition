using ControlTreeView;
using SquareOfOpposition.Common.Model;
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

namespace SquareOfOpposition
{
    public partial class MachineStateForm : Form
    {
        static MachineStateForm? instance;

        public static MachineStateForm Instance
        {
            get
            {
                if (instance == null)
                    return new MachineStateForm();

                return instance;
            }
        }

        public MachineStateForm()
        {
            instance = this;
            InitializeComponent();
            RefreshTree();
        }

        public void RefreshTree()
        {
            this.panelRender.Controls.Clear();
            var sampleCTreeView = new CTreeView
            {
                Dock = DockStyle.Fill,
                DrawStyle = CTreeViewDrawStyle.VerticalDiagram
            };
            this.panelRender.Controls.Add(sampleCTreeView);
            sampleCTreeView.BeginUpdate();
            var squares = SquareManager.squareList;
            var i = 0;
            foreach (var square in squares)
            {
                var root = new RootNode();
                root.setTitle("INPUT " + (i + 1));
                sampleCTreeView.Nodes.Add(new CTreeNode("Root Node", root));
                addNodesToNode(sampleCTreeView.Nodes[i], square);
                i++;
            }
            sampleCTreeView.EndUpdate();
        }

        public void addNodesToNode(CTreeNode node, Square square)
        {
            var stateMachine = new StateMachineControl();
            stateMachine.setValue(square);
            node.Nodes.Add(new CTreeNode(stateMachine));

            foreach (var sub_square in square.AI)
            {
                addNodesToNode(node.Nodes[0], sub_square);
            }

            foreach (var sub_square in square.EO)
            {
                addNodesToNode(node.Nodes[0], sub_square);
            }

            foreach (var sub_square in square.IO)
            {
                addNodesToNode(node.Nodes[0], sub_square);
            }
        }
    }
}
