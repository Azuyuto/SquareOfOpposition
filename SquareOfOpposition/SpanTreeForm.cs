﻿using ControlTreeView;
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
            AI_node.setValues(square.SaP, square.SiP, square, "AI");
            AI_node.ButtonClick += c_addSquare_Click;
            node.Nodes.Add(new CTreeNode(AI_node));

            var EO_node = new MyNode();
            EO_node.setValues(square.SeP, square.SoP, square, "EO");
            EO_node.ButtonClick += c_addSquare_Click;
            node.Nodes.Add(new CTreeNode(EO_node));

            var IO_node = new MyNode();
            IO_node.setValues(square.SiP, square.SoP, square, "IO");
            IO_node.ButtonClick += c_addSquare_Click;
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

        static void c_addSquare_Click(object sender, ButtonClick e)
        {
            SquareForm squareForm = new SquareForm(e.ParentSquare, e.SquareType);
            squareForm.ShowDialog();
        }
    }
}
