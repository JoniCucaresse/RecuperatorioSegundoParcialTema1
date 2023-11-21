using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RecuperatorioSegundoParcialTema1.Datos;
using RecuperatorioSegundoParcialTema1.Entidades;

namespace RecuperatorioSegundoParcialTema1.Windows
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FormPrincipalAE frm = new FormPrincipalAE() { Text = "Nuevo ?" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
