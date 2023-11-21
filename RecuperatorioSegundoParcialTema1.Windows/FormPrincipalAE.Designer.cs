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
            txtVar1 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            cboColores = new ComboBox();
            label3 = new Label();
            gbxBordes = new GroupBox();
            btnOK = new Button();
            btnCancelar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 38);
            label1.Name = "label1";
            label1.Size = new Size(60, 15);
            label1.TabIndex = 0;
            label1.Text = "Variable 1:";
            // 
            // txtVar1
            // 
            txtVar1.Location = new Point(109, 35);
            txtVar1.Name = "txtVar1";
            txtVar1.Size = new Size(100, 23);
            txtVar1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(43, 67);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 0;
            label2.Text = "Variable 2:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(109, 64);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 1;
            // 
            // cboColores
            // 
            cboColores.DropDownStyle = ComboBoxStyle.DropDownList;
            cboColores.FormattingEnabled = true;
            cboColores.Location = new Point(109, 106);
            cboColores.Name = "cboColores";
            cboColores.Size = new Size(140, 23);
            cboColores.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 109);
            label3.Name = "label3";
            label3.Size = new Size(81, 15);
            label3.TabIndex = 0;
            label3.Text = "Color Relleno:";
            // 
            // gbxBordes
            // 
            gbxBordes.Location = new Point(334, 29);
            gbxBordes.Name = "gbxBordes";
            gbxBordes.Size = new Size(200, 100);
            gbxBordes.TabIndex = 3;
            gbxBordes.TabStop = false;
            gbxBordes.Text = "Tipos de Bordes";
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
            Controls.Add(gbxBordes);
            Controls.Add(cboColores);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtVar1);
            Controls.Add(label1);
            Name = "FormPrincipalAE";
            Text = "FormPrincipalAE";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtVar1;
        private Label label2;
        private TextBox textBox1;
        private ComboBox cboColores;
        private Label label3;
        private GroupBox gbxBordes;
        private Button btnOK;
        private Button btnCancelar;
        private ErrorProvider errorProvider1;
    }
}