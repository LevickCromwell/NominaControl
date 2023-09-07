namespace NominaControl
{
    partial class frmCambiarDiasTrabajados
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
            txtNombre = new TextBox();
            txtPuesto = new TextBox();
            nmrDias = new NumericUpDown();
            btnAceptar = new Button();
            btnCancelar = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)nmrDias).BeginInit();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(179, 12);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(192, 23);
            txtNombre.TabIndex = 0;
            // 
            // txtPuesto
            // 
            txtPuesto.Location = new Point(179, 41);
            txtPuesto.Name = "txtPuesto";
            txtPuesto.ReadOnly = true;
            txtPuesto.Size = new Size(192, 23);
            txtPuesto.TabIndex = 1;
            // 
            // nmrDias
            // 
            nmrDias.Location = new Point(179, 70);
            nmrDias.Name = "nmrDias";
            nmrDias.Size = new Size(192, 23);
            nmrDias.TabIndex = 2;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(12, 140);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(97, 46);
            btnAceptar.TabIndex = 3;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(115, 140);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(95, 46);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 5;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Puesto";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 78);
            label3.Name = "label3";
            label3.Size = new Size(87, 15);
            label3.TabIndex = 7;
            label3.Text = "Dias trabajados";
            // 
            // frmCambiarDiasTrabajados
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(383, 239);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnCancelar);
            Controls.Add(btnAceptar);
            Controls.Add(nmrDias);
            Controls.Add(txtPuesto);
            Controls.Add(txtNombre);
            Name = "frmCambiarDiasTrabajados";
            Text = "frmCambiarDiasTrabajados";
            ((System.ComponentModel.ISupportInitialize)nmrDias).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private TextBox txtPuesto;
        private NumericUpDown nmrDias;
        private Button btnAceptar;
        private Button btnCancelar;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}