using System;
using System.Data;
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
                string strin = string.Format("select * from Usuario where Account = '{0}' and Password = '{1}' ", IDTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet DS = conexion.con(strin);

                string account = DS.Tables[0].Rows[0]["Acoount"].ToString().Trim();
                string contraseña = DS.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (account == IDTextBox.Text.Trim() && contraseña == PasswordTextBox.Text.Trim())
                {
                    MessageBox.Show("is fine");

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("usuario o contraseña incorrecta",ex.Message);

            }





            //try
            //{
            //    SqlConnection Conexion = new SqlConnection("Data Source=.;Initial Catalog=Administracion;Integrated Security=True");
            //    Conexion.Close(); 
            //    MessageBox.Show("te tiene dentro");
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("te tiene fuera", ex.Message);
            //}
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
