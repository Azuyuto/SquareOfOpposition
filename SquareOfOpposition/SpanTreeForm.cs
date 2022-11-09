using ControlTreeView;
using SquareOfOpposition.Common.Model;
using SquareOfOpposition.Common.FileManager;
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
        static SpanTreeForm? instance;

        public static SpanTreeForm Instance
        {
            get
            {
                if (instance == null)
                    return new SpanTreeForm();

                return instance;
            }
        }

        public SpanTreeForm()
        {
            instance = this;
            InitializeComponent();
            RefreshTree();
        }

        public void RefreshTree()
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
            var i = 0;
            foreach (var square in squares)
            {
                var root = new RootNode();
                root.setTitle("Square " + (i + 1));
                sampleCTreeView.Nodes.Add(new CTreeNode("Root Node", root));
                addNodesToNode(sampleCTreeView.Nodes[i], square);
                i++;
            }
            sampleCTreeView.EndUpdate();
        }

        public void addNodesToNode(CTreeNode node, Square square)
        {
            var AI_node = new MyNode();
            AI_node.setValues(square.SaP, square.SiP);
            node.Nodes.Add(new CTreeNode(AI_node));

            var EO_node = new MyNode();
            EO_node.setValues(square.SeP, square.SoP);
            node.Nodes.Add(new CTreeNode(EO_node));

            var IO_node = new MyNode();
            IO_node.setValues(square.SiP, square.SoP);
            node.Nodes.Add(new CTreeNode(IO_node));

            foreach(var sub_square in square.AI)
            {
                addNodesToNode(node.Nodes[0], sub_square);
            }

            foreach (var sub_square in square.EO)
            {
                addNodesToNode(node.Nodes[1], sub_square);
            }

            foreach (var sub_square in square.IO)
            {
                addNodesToNode(node.Nodes[2], sub_square);
            }
        }

        private void addSquare_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm();
            squareForm.ShowDialog();
            squareForm.FormClosed += FormClosing;
        }

        void FormClosing(object sender, FormClosedEventArgs e)
        {
            refreshTree();
        }
        private void tableLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    FileManager.saveSquareToFile(file);
                }
                catch (IOException)
                {
                }
            }
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                string file = openFileDialog1.FileName;
                try
                {
                    FileManager.readSquareFromFile(file);
                }
                catch (IOException)
                {
                }
            }
        }
    }
}
