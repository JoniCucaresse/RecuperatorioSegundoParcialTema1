namespace RecuperatorioSegundoParcialTema1.Windows
{
    partial class FormPrincipalAE
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtLado = new TextBox();
            cboColores = new ComboBox();
            label3 = new Label();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 38);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Lado:";
            // 
            // txtLado
            // 
            txtLado.Location = new Point(109, 35);
            txtLado.Name = "txtLado";
            txtLado.Size = new Size(100, 23);
            txtLado.TabIndex = 1;
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(109, 82);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(140, 23);
            cboColores.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 85);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 0;
            label3.Text = "Color Relleno:";
            // 
            // btnOK
            // 
            btnOK.AutoSize = true;
            btnOK.Image = Properties.Resources.ok_24px;
            btnOK.Location = new Point(58, 176);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(82, 49);
            btnOK.TabIndex = 4;
            btnOK.Text = "OK";
            btnOK.TextImageRelation = TextImageRelation.ImageAboveText;
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.AutoSize = true;
            btnCancelar.Image = Properties.Resources.cancel_24px;
            btnCancelar.Location = new Point(422, 176);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(82, 49);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageAboveText;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // FormPrincipalAE
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(567, 252);
            Controls.Add(btnCancelar);
            Controls.Add(btnOK);
            Controls.Add(cboColores);
            Controls.Add(label3);
            Controls.Add(txtLado);
            Controls.Add(label1);
            Name = "FormPrincipalAE";
            Text = "FormPrincipalAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtLado;
        private ComboBox cboColores;
        private Label label3;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}