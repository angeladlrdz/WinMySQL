namespace WinMySQL.Views
{
    partial class frmProfesor
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtNumEmpleado = new TextBox();
            txtNombre = new TextBox();
            txtApPaterno = new TextBox();
            txtApMaterno = new TextBox();
            txtRFC = new TextBox();
            txtGrado = new TextBox();
            btnAceptar = new Button();
            label7 = new Label();
            txtSegNombre = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 18);
            label1.Name = "label1";
            label1.Size = new Size(123, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de empleado";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 75);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 185);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 239);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 295);
            label5.Name = "label5";
            label5.Size = new Size(28, 15);
            label5.TabIndex = 4;
            label5.Text = "RFC";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 349);
            label6.Name = "label6";
            label6.Size = new Size(100, 15);
            label6.TabIndex = 5;
            label6.Text = "Grado academico";
            // 
            // txtNumEmpleado
            // 
            txtNumEmpleado.Location = new Point(12, 36);
            txtNumEmpleado.Name = "txtNumEmpleado";
            txtNumEmpleado.Size = new Size(164, 23);
            txtNumEmpleado.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 93);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(257, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApPaterno
            // 
            txtApPaterno.Location = new Point(13, 203);
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(256, 23);
            txtApPaterno.TabIndex = 8;
            // 
            // txtApMaterno
            // 
            txtApMaterno.Location = new Point(13, 257);
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(256, 23);
            txtApMaterno.TabIndex = 9;
            // 
            // txtRFC
            // 
            txtRFC.Location = new Point(13, 313);
            txtRFC.Name = "txtRFC";
            txtRFC.Size = new Size(163, 23);
            txtRFC.TabIndex = 10;
            // 
            // txtGrado
            // 
            txtGrado.Location = new Point(13, 367);
            txtGrado.Name = "txtGrado";
            txtGrado.Size = new Size(163, 23);
            txtGrado.TabIndex = 11;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(194, 35);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 130);
            label7.Name = "label7";
            label7.Size = new Size(101, 15);
            label7.TabIndex = 13;
            label7.Text = "Segundo Nombre";
            // 
            // txtSegNombre
            // 
            txtSegNombre.Location = new Point(13, 153);
            txtSegNombre.Name = "txtSegNombre";
            txtSegNombre.Size = new Size(256, 23);
            txtSegNombre.TabIndex = 14;
            // 
            // frmProfesor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(290, 402);
            Controls.Add(txtSegNombre);
            Controls.Add(label7);
            Controls.Add(btnAceptar);
            Controls.Add(txtGrado);
            Controls.Add(txtRFC);
            Controls.Add(txtApMaterno);
            Controls.Add(txtApPaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtNumEmpleado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmProfesor";
            Text = "Profesor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtNumEmpleado;
        private TextBox txtNombre;
        private TextBox txtApPaterno;
        private TextBox txtApMaterno;
        private TextBox txtRFC;
        private TextBox txtGrado;
        private Button btnAceptar;
        private Label label7;
        private TextBox txtSegNombre;
    }
}