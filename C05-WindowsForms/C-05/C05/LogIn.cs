using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C05
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBox_IngresoDatos.Text))
            {
                string usuario = txtBox_IngresoDatos.Text;
                MenuPrincipal formMenuPrincipal = new MenuPrincipal(usuario);
                formMenuPrincipal.Show();
                this.Hide();
            }
            else
            {
                label1.Text = "USUARIO INVÁLIDO";
            }
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            MessageBox.Show("LOADING LOG IN");
        }
    }
}
