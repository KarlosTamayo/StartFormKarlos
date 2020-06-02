using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Login
{
    public partial class Login : Form
    {
        Conexion conexion = new Conexion();
        public Login()
        {
            InitializeComponent();
        }

        private void InButton_Click(object sender, EventArgs e)
        {
            try
            {
               string strin = string.Format("select * from Usuario where Account = '{0}' and Password = '{1}' ",) 
                   

            }
            catch (Exception ex)
            {
               
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
