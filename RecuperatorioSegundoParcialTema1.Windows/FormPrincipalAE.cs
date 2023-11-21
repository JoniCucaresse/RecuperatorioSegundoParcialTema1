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
        private Hexagono hexagono;

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            CargarComboColores();
        }
        private void CargarComboColores()
        {
            var listaColores = Enum.GetValues(typeof(Relleno))
                .Cast<Relleno>().ToList();
            cboColores.DataSource = listaColores;
            cboColores.SelectedIndex = 0;
        }

        public Hexagono GetHexagono()
        {
            return hexagono;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (ValidarDatos())
            {
                hexagono = new Hexagono();
                hexagono.Lado = int.Parse(txtLado.Text);
                hexagono.Relleno = (Relleno)cboColores.SelectedItem;

                DialogResult = DialogResult.OK;
            }
        }
        private bool ValidarDatos()
        {
            bool valido = true;
            errorProvider1.Clear();
            if (!int.TryParse(txtLado.Text, out int Lado))
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Lado no numérico");
            }
            else if (Lado <= 0)
            {
                valido = false;
                errorProvider1.SetError(txtLado, "Lado no válido");
            }

            return valido;
        }
    }
}
