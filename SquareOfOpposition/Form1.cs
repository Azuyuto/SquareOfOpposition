using SquareOfOpposition.Common.FileManager;
using SquareOfOpposition.Common.Model;
using SquareOfOpposition.Common.SquareManager;

namespace SquareOfOpposition
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addSquareBtn_Click(object sender, EventArgs e)
        {
            Form squareForm = new SquareForm();
            squareForm.ShowDialog();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}