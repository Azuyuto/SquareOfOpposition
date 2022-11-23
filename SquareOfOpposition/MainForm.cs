using SquareOfOpposition.Common.FileManager;
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
    public partial class MainForm : Form
    {
        static MainForm? instance;

        public static MainForm Instance
        {
            get
            {
                if (instance == null)
                    return new MainForm();

                return instance;
            }
        }

        public MainForm()
        {
            instance = this;
            InitializeComponent();
            openChildForm(new SpanTreeForm());
        }

        private void buttonOpen_Click(object sender, EventArgs e)
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

        private void buttonSave_Click(object sender, EventArgs e)
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

        private void buttonAddSquare_Click(object sender, EventArgs e)
        {
            SquareForm squareForm = new SquareForm();
            squareForm.ShowDialog();
        }

        private void buttonSpanTree_Click(object sender, EventArgs e)
        {
            openChildForm(new SpanTreeForm());
        }

        private void buttonMachineState_Click(object sender, EventArgs e)
        {
            openChildForm(new MachineStateForm());
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelRender.Controls.Add(childForm);
            panelRender.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
