namespace WinMySQL.Views
{
    partial class frmAsistencia
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
            dtpAsistencia = new DateTimePicker();
            txtAsistencia = new TextBox();
            dgvAsistencia = new DataGridView();
            label1 = new Label();
            btnBuscar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            SuspendLayout();
            // 
            // dtpAsistencia
            // 
            dtpAsistencia.Location = new Point(12, 26);
            dtpAsistencia.Name = "dtpAsistencia";
            dtpAsistencia.Size = new Size(200, 23);
            dtpAsistencia.TabIndex = 0;
            dtpAsistencia.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtAsistencia
            // 
            txtAsistencia.Location = new Point(12, 98);
            txtAsistencia.Name = "txtAsistencia";
            txtAsistencia.Size = new Size(200, 23);
            txtAsistencia.TabIndex = 1;
            txtAsistencia.KeyUp += txtAsistencia_KeyUp;
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.AllowUserToAddRows = false;
            dgvAsistencia.AllowUserToDeleteRows = false;
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(12, 146);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.ReadOnly = true;
            dgvAsistencia.Size = new Size(395, 292);
            dgvAsistencia.TabIndex = 4;
            dgvAsistencia.CellClick += dataGridView2_CellClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 80);
            label1.Name = "label1";
            label1.Size = new Size(110, 15);
            label1.TabIndex = 6;
            label1.Text = "Número de Control";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(263, 63);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 450);
            Controls.Add(btnBuscar);
            Controls.Add(label1);
            Controls.Add(dgvAsistencia);
            Controls.Add(txtAsistencia);
            Controls.Add(dtpAsistencia);
            Name = "frmAsistencia";
            Text = "Asistencia";
            Load += frmAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpAsistencia;
        private TextBox txtAsistencia;
        private DataGridView dgvAsistencia;
        private Label label1;
        private Button btnBuscar;
    }
}