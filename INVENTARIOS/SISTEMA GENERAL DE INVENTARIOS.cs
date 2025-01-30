namespace INVENTARIOS
{
    public partial class Form1 : Form
    {
        public string coneccion;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void cARTERToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sALIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEstados frm = new FrmEstados();
            frm.coneccion = coneccion;
            frm.ShowDialog();
        }

        private void sALIRToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

        }
    }
}