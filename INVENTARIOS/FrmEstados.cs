using Microsoft.VisualBasic;
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
    public partial class FrmEstados : Form
    {
        public string coneccion;
        SqlConnection con;
        private SqlDataAdapter BDEstados;
        private DataSet TBEstados;
        private DataRow RegEstados;
        public FrmEstados()
        {
            InitializeComponent();
        }

        private void FrmEstados_Load(object sender, EventArgs e)
        {
            string Strsql = "SELECT * FROM Estados";
            con = new SqlConnection();
            con.ConnectionString = coneccion;
            SqlCommand cmd = new SqlCommand(Strsql, con);
            BDEstados = new SqlDataAdapter(cmd);
            TBEstados = new DataSet();
            BDEstados.Fill(TBEstados, TBEstados "Estados");
            RegEstados = TBEstados.Tables["Estados"].Rows[0];
            MostrarDatos();

        }
        public void MostrarDatos()
        {
            int posicion;
            BindingManagerBase mbase = BindingContext[TBEstados, "Estados"];
            posicion = mbase.Position;
            BindingContext[TBEstados, "Estados"].Position = posicion;
            RegEstados = TBEstados.Tables["Estados"].Rows[posicion];
            TxtId.Text = Convert.ToString(RegEstados["Id"]);
            TxtNombre.Text = Convert.ToString(RegEstados["Nombre"]);

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BindingContext[TBEstados, "Estados"].Position = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BindingContext[TBEstados, "Estados"].Position = BindingContext[TBEstados, "Estados"].Count;
            MostrarDatos();
        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
