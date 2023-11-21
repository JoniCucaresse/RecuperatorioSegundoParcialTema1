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
        RepositorioDeHexagonos repositorio = new RepositorioDeHexagonos();
        List<Hexagono> hexagonosLista;
        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            hexagonosLista = repositorio.GetLista();
            MostrarDatosEnGrilla();
        }

        private void tsbNuevo_Click(object sender, EventArgs e)
        {
            FormPrincipalAE frm = new FormPrincipalAE() { Text = "Nuevo Hexagono" };
            DialogResult dr = frm.ShowDialog(this);
            if (dr == DialogResult.Cancel)
            {
                return;
            }
            Hexagono hexagono = frm.GetHexagono();
            repositorio.Agregar(hexagono);
            var r = ConstruirFila();
            SetearFila(r, hexagono);
            AgregarFila(r);
        }
        private DataGridViewRow ConstruirFila()
        {
            var r = new DataGridViewRow();
            r.CreateCells(dgvDatos);
            return r;
        }

        private void SetearFila(DataGridViewRow r, Hexagono hexagono)
        {
            r.Cells[colLado.Index].Value = hexagono.Lado;
            r.Cells[colRelleno.Index].Value = hexagono.Relleno;
            r.Cells[colPerimetro.Index].Value = hexagono.GetPerimetro();
            r.Cells[colSuperficie.Index].Value = hexagono.GetArea();
            r.Cells[colApotema.Index].Value = hexagono.Apotema;


            r.Tag = hexagono;
        }
        private void AgregarFila(DataGridViewRow r)
        {
            dgvDatos.Rows.Add(r);
        }
        private void MostrarDatosEnGrilla()
        {
            dgvDatos.Rows.Clear();
            foreach (var hexagono in hexagonosLista)
            {
                DataGridViewRow r = ConstruirFila();
                SetearFila(r, hexagono);
                AgregarFila(r);
            }
        }

        private void tsbSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

     
    }
}
