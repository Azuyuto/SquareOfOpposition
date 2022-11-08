using SquareOfOpposition.Common.Model;
using SquareOfOpposition.Common.SquareManager;
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
    public partial class SquareForm : Form
    {
        Square square;
        public SquareForm()
        {
            InitializeComponent();
            square = new Square();
        }

        private void SquareForm_Load(object sender, EventArgs e)
        {
            
        }

        private void SaPTxt_TextChanged(object sender, EventArgs e)
        {
            square.SaP = SaPTxt.Text;
        }

        private void SiPTxt_TextChanged(object sender, EventArgs e)
        {
            square.SiP = SiPTxt.Text;
        }

        private void SoPTxt_TextChanged(object sender, EventArgs e)
        {
            square.SoP = SoPTxt.Text;
        }

        private void SePTxt_TextChanged(object sender, EventArgs e)
        {
            square.SeP = SePTxt.Text;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            SquareManager.addToSquareList(square);
            this.Close();
        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
