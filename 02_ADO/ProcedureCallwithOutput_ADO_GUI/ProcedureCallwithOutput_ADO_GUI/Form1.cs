namespace ProcedureCallwithOutput_ADO_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void iNSERTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 F = new Form2();
            F.Show();
        }

        private void uPDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 F = new Form3();
            F.Show();
        }

        private void dELETEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 F = new Form4();
            F.Show();
        }

        private void dISPLAYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form5 F = new Form5();
            F.Show();
        }
    }
}