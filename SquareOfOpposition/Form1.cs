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

        private void button1_Click(object sender, EventArgs e)
        {
            FileManager.saveSquareToFile();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FileManager.readSquareFromFile();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            foreach (Square s in SquareManager.getSquareList())
            {
                MessageBox.Show(s.ToString());
            }
        }
    }
}