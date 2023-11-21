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
    public partial class FormPrincipalAE : Form
    {
        public FormPrincipalAE()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
