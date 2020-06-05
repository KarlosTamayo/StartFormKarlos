using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class MantenimientoClientes : Form
    {
        public MantenimientoClientes()
        {
            InitializeComponent();
        }

        Conexion conexion = new Conexion();
        private void GuardarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("Exec  ActulizaClientes '{0}', '{1}' , '{2}' ", idCliTextBox.Text.Trim(), NomCliTextBox.Text.Trim(), ApeCliTextBox.Text.Trim());
                conexion.con(data);
                MessageBox.Show("se guardo con satisfacion");





            }

            catch (Exception ex)
            {

                MessageBox.Show("Sin guardar", ex.Message);
            }
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            try
            {
                string data = string.Format("exec eliminarArticulos '{0}' ", idCliTextBox.Text.Trim());
                conexion.con(data);
                MessageBox.Show("se elimino satisfacion");

            }
            catch (Exception ex)
            {

                MessageBox.Show("no se puedo eliminar");
            }
        }
    }
}
