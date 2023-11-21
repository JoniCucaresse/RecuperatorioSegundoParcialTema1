namespace RecuperatorioSegundoParcialTema1.Windows
{
    partial class FormPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            toolStrip1 = new ToolStrip();
            tsbNuevo = new ToolStripButton();
            tsbBorrar = new ToolStripButton();
            tsbEditar = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            tsbFiltrar = new ToolStripButton();
            tsbActualizar = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            tsbOrdenar = new ToolStripDropDownButton();
            ascendenteToolStripMenuItem = new ToolStripMenuItem();
            descendenteToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            tsbSalir = new ToolStripButton();
            dgvDatos = new DataGridView();
            colLado = new DataGridViewTextBoxColumn();
            colRelleno = new DataGridViewTextBoxColumn();
            colPerimetro = new DataGridViewTextBoxColumn();
            colSuperficie = new DataGridViewTextBoxColumn();
            colApotema = new DataGridViewTextBoxColumn();
            label1 = new Label();
            txtCantidad = new TextBox();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).BeginInit();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbNuevo, tsbBorrar, tsbEditar, toolStripSeparator1, tsbFiltrar, tsbActualizar, toolStripSeparator3, tsbOrdenar, toolStripSeparator2, tsbSalir });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 54);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // tsbNuevo
            // 
            tsbNuevo.Image = Properties.Resources.new_copy_32px;
            tsbNuevo.ImageScaling = ToolStripItemImageScaling.None;
            tsbNuevo.ImageTransparentColor = Color.Magenta;
            tsbNuevo.Name = "tsbNuevo";
            tsbNuevo.Size = new Size(46, 51);
            tsbNuevo.Text = "Nuevo";
            tsbNuevo.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbNuevo.Click += tsbNuevo_Click;
            // 
            // tsbBorrar
            // 
            tsbBorrar.Image = Properties.Resources.delete_file_32px;
            tsbBorrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBorrar.ImageTransparentColor = Color.Magenta;
            tsbBorrar.Name = "tsbBorrar";
            tsbBorrar.Size = new Size(43, 51);
            tsbBorrar.Text = "Borrar";
            tsbBorrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbEditar
            // 
            tsbEditar.Image = Properties.Resources.edit_file_32px;
            tsbEditar.ImageScaling = ToolStripItemImageScaling.None;
            tsbEditar.ImageTransparentColor = Color.Magenta;
            tsbEditar.Name = "tsbEditar";
            tsbEditar.Size = new Size(41, 51);
            tsbEditar.Text = "Editar";
            tsbEditar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 54);
            // 
            // tsbFiltrar
            // 
            tsbFiltrar.Image = Properties.Resources.filled_filter_32px;
            tsbFiltrar.ImageScaling = ToolStripItemImageScaling.None;
            tsbFiltrar.ImageTransparentColor = Color.Magenta;
            tsbFiltrar.Name = "tsbFiltrar";
            tsbFiltrar.Size = new Size(41, 51);
            tsbFiltrar.Text = "Filtrar";
            tsbFiltrar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // tsbActualizar
            // 
            tsbActualizar.Image = Properties.Resources.refresh_32px;
            tsbActualizar.ImageScaling = ToolStripItemImageScaling.None;
            tsbActualizar.ImageTransparentColor = Color.Magenta;
            tsbActualizar.Name = "tsbActualizar";
            tsbActualizar.Size = new Size(63, 51);
            tsbActualizar.Text = "Actualizar";
            tsbActualizar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 54);
            // 
            // tsbOrdenar
            // 
            tsbOrdenar.DropDownItems.AddRange(new ToolStripItem[] { ascendenteToolStripMenuItem, descendenteToolStripMenuItem });
            tsbOrdenar.Image = Properties.Resources.sorting_arrows_32px;
            tsbOrdenar.ImageScaling = ToolStripItemImageScaling.None;
            tsbOrdenar.ImageTransparentColor = Color.Magenta;
            tsbOrdenar.Name = "tsbOrdenar";
            tsbOrdenar.Size = new Size(63, 51);
            tsbOrdenar.Text = "Ordenar";
            tsbOrdenar.TextImageRelation = TextImageRelation.ImageAboveText;
            // 
            // ascendenteToolStripMenuItem
            // 
            ascendenteToolStripMenuItem.Image = Properties.Resources.numerical_sorting_32px;
            ascendenteToolStripMenuItem.Name = "ascendenteToolStripMenuItem";
            ascendenteToolStripMenuItem.Size = new Size(142, 22);
            ascendenteToolStripMenuItem.Text = "Ascendente";
            // 
            // descendenteToolStripMenuItem
            // 
            descendenteToolStripMenuItem.Image = Properties.Resources.reversed_numerical_sorting_32px;
            descendenteToolStripMenuItem.Name = "descendenteToolStripMenuItem";
            descendenteToolStripMenuItem.Size = new Size(142, 22);
            descendenteToolStripMenuItem.Text = "Descendente";
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 54);
            // 
            // tsbSalir
            // 
            tsbSalir.Image = Properties.Resources.exit_32px;
            tsbSalir.ImageScaling = ToolStripItemImageScaling.None;
            tsbSalir.ImageTransparentColor = Color.Magenta;
            tsbSalir.Name = "tsbSalir";
            tsbSalir.Size = new Size(36, 51);
            tsbSalir.Text = "Salir";
            tsbSalir.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbSalir.Click += tsbSalir_Click;
            // 
            // dgvDatos
            // 
            dgvDatos.AllowUserToAddRows = false;
            dgvDatos.AllowUserToDeleteRows = false;
            dgvDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDatos.Columns.AddRange(new DataGridViewColumn[] { colLado, colRelleno, colPerimetro, colSuperficie, colApotema });
            dgvDatos.Location = new Point(0, 57);
            dgvDatos.Name = "dgvDatos";
            dgvDatos.ReadOnly = true;
            dgvDatos.RowTemplate.Height = 25;
            dgvDatos.Size = new Size(800, 281);
            dgvDatos.TabIndex = 1;
            // 
            // colLado
            // 
            colLado.HeaderText = "Lado";
            colLado.Name = "colLado";
            colLado.ReadOnly = true;
            colLado.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colRelleno
            // 
            colRelleno.HeaderText = "Relleno";
            colRelleno.Name = "colRelleno";
            colRelleno.ReadOnly = true;
            colRelleno.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colPerimetro
            // 
            colPerimetro.HeaderText = "Perimetro";
            colPerimetro.Name = "colPerimetro";
            colPerimetro.ReadOnly = true;
            colPerimetro.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colSuperficie
            // 
            colSuperficie.HeaderText = "Superficie";
            colSuperficie.Name = "colSuperficie";
            colSuperficie.ReadOnly = true;
            colSuperficie.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // colApotema
            // 
            colApotema.HeaderText = "Apotema";
            colApotema.Name = "colApotema";
            colApotema.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(29, 359);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 2;
            label1.Text = "Cantidad Registros:";
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(144, 356);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 3;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 394);
            Controls.Add(txtCantidad);
            Controls.Add(label1);
            Controls.Add(dgvDatos);
            Controls.Add(toolStrip1);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            Load += FormPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDatos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbNuevo;
        private ToolStripButton tsbBorrar;
        private ToolStripButton tsbEditar;
        private ToolStripButton tsbFiltrar;
        private ToolStripButton tsbActualizar;
        private ToolStripButton tsbSalir;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripDropDownButton tsbOrdenar;
        private ToolStripMenuItem ascendenteToolStripMenuItem;
        private ToolStripMenuItem descendenteToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private DataGridView dgvDatos;
        private ToolStripSeparator toolStripSeparator3;
        private Label label1;
        private TextBox txtCantidad;
        private DataGridViewTextBoxColumn colLado;
        private DataGridViewTextBoxColumn colRelleno;
        private DataGridViewTextBoxColumn colPerimetro;
        private DataGridViewTextBoxColumn colSuperficie;
        private DataGridViewTextBoxColumn colApotema;
    }
}