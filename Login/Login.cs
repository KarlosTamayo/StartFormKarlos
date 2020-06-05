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
        public static string codig;

        private void InButton_Click(object sender, EventArgs e)
        {
            try
            {
                string strin = string.Format("select * from Usuario where Account = '{0}' and Password = '{1}' ", IDTextBox.Text.Trim(), PasswordTextBox.Text.Trim());
                DataSet DS = conexion.con(strin);

                codig = DS.Tables[0].Rows[0]["IdUsuario"].ToString().Trim();

                string account = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contraseña = DS.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (account == IDTextBox.Text.Trim() && contraseña == PasswordTextBox.Text.Trim())
                {

                    if (Convert.ToBoolean(DS.Tables[0].Rows[0]["StatusAdmin"]) == true)
                    {
                        Admin admin = new Admin();
                        this.Hide();
                        admin.Show();
                    }
                    else
                    {
                        User user = new User();
                        this.Hide();
                        user.Show();

                    }
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
