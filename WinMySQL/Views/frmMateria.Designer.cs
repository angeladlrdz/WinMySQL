namespace WinMySQL.Views
{
    partial class frmMateria
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
            txtMateria = new TextBox();
            label2 = new Label();
            txtClave = new TextBox();
            btnAceptar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 12);
            label1.Name = "label1";
            label1.Size = new Size(47, 15);
            label1.TabIndex = 0;
            label1.Text = "Materia";
            // 
            // txtMateria
            // 
            txtMateria.Location = new Point(12, 30);
            txtMateria.Name = "txtMateria";
            txtMateria.Size = new Size(371, 23);
            txtMateria.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 83);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "CVE Oficial";
            // 
            // txtClave
            // 
            txtClave.Location = new Point(14, 101);
            txtClave.Name = "txtClave";
            txtClave.Size = new Size(192, 23);
            txtClave.TabIndex = 3;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(289, 103);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // frmMateria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(406, 151);
            Controls.Add(btnAceptar);
            Controls.Add(txtClave);
            Controls.Add(label2);
            Controls.Add(txtMateria);
            Controls.Add(label1);
            Name = "frmMateria";
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtMateria;
        private Label label2;
        private TextBox txtClave;
        private Button btnAceptar;
    }
}