using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace INVENTARIOS
{
    public partial class Login : Form
    {
        SqlConnection con;
        protected String StringSQL = "SERVER=.;DataBase=VERANO;Integrated Security=SSPI;";
        private SqlDataAdapter BDControl;
        private DataSet TBControl;
        private DataRow RegControl;
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            TxTUsuario.Focus();

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            string Strsql = "SELECT * FROM Control";
            con = new SqlConnection();
            con.ConnectionString = StringSQL;
            SqlCommand cmd = new SqlCommand (Strsql, con);
            BDControl = new SqlDataAdapter(cmd);
            TBControl = new DataSet();
            BDControl.Fill(TBControl,  "Control");
            RegControl = TBControl.Tables["Control"].Rows[0];
            if ((TxTUsuario.Text != Convert.ToString(RegControl["Usuario"])) || (TxTPassword.Text != Convert.ToString(RegControl["Password"])));
            {
                MessageBox.Show("Usuario y Contraseña Incorrectos");
            }
            {
                MessageBox.Show("Enhorabuena Datos Correctos... Ya puede accesar al sistema");
                this.Visible = false;
                Form1 frm = new Form1();
                frm.coneccion = StringSQL;
                frm.ShowDialog();
                Close();
            }
       
        }

        private void BtnAceptar_Click_1(object sender, EventArgs e)
        {

        }

        private void TxTPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxTUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
