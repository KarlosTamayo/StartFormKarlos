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
    public partial class User : Form
    {
        Conexion conexion = new Conexion();
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            string smd = " select * from Usuario where IdUsuario =" + Login.codig;
            DataSet ds = conexion.con(smd);
            AdminLabel.Text = ds.Tables[0].Rows[0]["NombreUsuario"].ToString().Trim();
            UserLabel.Text = ds.Tables[0].Rows[0]["Account"].ToString().Trim();
            CodigoLabel.Text = ds.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();
        }
    }
}
