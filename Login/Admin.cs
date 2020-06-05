using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Admin : Form
    {
        Conexion conexion = new Conexion();

        public Admin()
        {
            InitializeComponent();
        }

        private void AdminLabel_Click(object sender, EventArgs e)
        {
           
        }

        private void COntenedorPrincpalButton_Click(object sender, EventArgs e)
        {
            ContenedorPrincipal contenedor = new ContenedorPrincipal();
            this.Hide();
            contenedor.Show();
        }

        private void Admin_Load(object sender, EventArgs e)
        {

            string smd = " select * from Usuario where IdUsuario ="+Login.codig;
            DataSet ds = conexion.con(smd);
            AdminLabel.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();
            UserLabel.Text = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
            CodigoLabel.Text = ds.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();

        }
    }
}
