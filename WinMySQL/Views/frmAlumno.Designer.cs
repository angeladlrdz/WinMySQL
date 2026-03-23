namespace WinMySQL.Views
{
    partial class frmAlumno
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
            txtNumControl = new TextBox();
            txtNombre = new TextBox();
            txtApPaterno = new TextBox();
            txtApMaterno = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(108, 15);
            label1.TabIndex = 0;
            label1.Text = "Numero de control";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 71);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Primer Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 126);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 2;
            label3.Text = "Apellido Paterno";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 185);
            label4.Name = "label4";
            label4.Size = new Size(99, 15);
            label4.TabIndex = 3;
            label4.Text = "Apellido Materno";
            // 
            // txtNumControl
            // 
            txtNumControl.Location = new Point(12, 34);
            txtNumControl.Name = "txtNumControl";
            txtNumControl.Size = new Size(177, 23);
            txtNumControl.TabIndex = 6;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(12, 89);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(264, 23);
            txtNombre.TabIndex = 7;
            // 
            // txtApPaterno
            // 
            txtApPaterno.Location = new Point(12, 144);
            txtApPaterno.Name = "txtApPaterno";
            txtApPaterno.Size = new Size(264, 23);
            txtApPaterno.TabIndex = 8;
            // 
            // txtApMaterno
            // 
            txtApMaterno.Location = new Point(12, 203);
            txtApMaterno.Name = "txtApMaterno";
            txtApMaterno.Size = new Size(264, 23);
            txtApMaterno.TabIndex = 9;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(201, 33);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 12;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmAlumno
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 244);
            Controls.Add(btnAceptar);
            Controls.Add(txtApMaterno);
            Controls.Add(txtApPaterno);
            Controls.Add(txtNombre);
            Controls.Add(txtNumControl);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmAlumno";
            Text = "Alumno";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtNumControl;
        private TextBox txtNombre;
        private TextBox txtApPaterno;
        private TextBox txtApMaterno;
        private Button btnAceptar;
    }
}