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
            rbnAsistenciaSi = new RadioButton();
            rbnAsistenciaNo = new RadioButton();
            grpbAsistencia = new GroupBox();
            btnBuscar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).BeginInit();
            grpbAsistencia.SuspendLayout();
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
            // 
            // dgvAsistencia
            // 
            dgvAsistencia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAsistencia.Location = new Point(12, 146);
            dgvAsistencia.Name = "dgvAsistencia";
            dgvAsistencia.Size = new Size(434, 292);
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
            // rbnAsistenciaSi
            // 
            rbnAsistenciaSi.AutoSize = true;
            rbnAsistenciaSi.Location = new Point(16, 25);
            rbnAsistenciaSi.Name = "rbnAsistenciaSi";
            rbnAsistenciaSi.Size = new Size(34, 19);
            rbnAsistenciaSi.TabIndex = 8;
            rbnAsistenciaSi.TabStop = true;
            rbnAsistenciaSi.Text = "Si";
            rbnAsistenciaSi.UseVisualStyleBackColor = true;
            rbnAsistenciaSi.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // rbnAsistenciaNo
            // 
            rbnAsistenciaNo.AutoSize = true;
            rbnAsistenciaNo.Location = new Point(16, 59);
            rbnAsistenciaNo.Name = "rbnAsistenciaNo";
            rbnAsistenciaNo.Size = new Size(41, 19);
            rbnAsistenciaNo.TabIndex = 9;
            rbnAsistenciaNo.TabStop = true;
            rbnAsistenciaNo.Text = "No";
            rbnAsistenciaNo.UseVisualStyleBackColor = true;
            rbnAsistenciaNo.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // grpbAsistencia
            // 
            grpbAsistencia.Controls.Add(rbnAsistenciaSi);
            grpbAsistencia.Controls.Add(rbnAsistenciaNo);
            grpbAsistencia.Location = new Point(314, 17);
            grpbAsistencia.Name = "grpbAsistencia";
            grpbAsistencia.Size = new Size(110, 78);
            grpbAsistencia.TabIndex = 10;
            grpbAsistencia.TabStop = false;
            grpbAsistencia.Text = "Asistencia";
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(218, 98);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 11;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += button1_Click;
            // 
            // button1
            // 
            button1.Location = new Point(218, 69);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // frmAsistencia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 450);
            Controls.Add(button1);
            Controls.Add(btnBuscar);
            Controls.Add(grpbAsistencia);
            Controls.Add(label1);
            Controls.Add(dgvAsistencia);
            Controls.Add(txtAsistencia);
            Controls.Add(dtpAsistencia);
            Name = "frmAsistencia";
            Text = "Asistencia";
            Load += frmAsistencia_Load;
            ((System.ComponentModel.ISupportInitialize)dgvAsistencia).EndInit();
            grpbAsistencia.ResumeLayout(false);
            grpbAsistencia.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dtpAsistencia;
        private TextBox txtAsistencia;
        private DataGridView dgvAsistencia;
        private Label label1;
        private RadioButton rbnAsistenciaSi;
        private RadioButton rbnAsistenciaNo;
        private GroupBox grpbAsistencia;
        private Button btnBuscar;
        private Button button1;
    }
}