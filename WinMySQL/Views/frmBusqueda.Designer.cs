namespace WinMySQL.Views
{
    partial class frmBusqueda
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
            txtBusqueda = new TextBox();
            dgvBusqueda = new DataGridView();
            lblAsistio = new Label();
            lblNoAsistio = new Label();
            dtpBusqueda = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).BeginInit();
            SuspendLayout();
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(12, 77);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(218, 23);
            txtBusqueda.TabIndex = 0;
            txtBusqueda.TextChanged += textBox1_TextChanged;
            // 
            // dgvBusqueda
            // 
            dgvBusqueda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBusqueda.Location = new Point(12, 119);
            dgvBusqueda.Name = "dgvBusqueda";
            dgvBusqueda.Size = new Size(462, 289);
            dgvBusqueda.TabIndex = 1;
            // 
            // lblAsistio
            // 
            lblAsistio.AutoSize = true;
            lblAsistio.Location = new Point(388, 18);
            lblAsistio.Name = "lblAsistio";
            lblAsistio.Size = new Size(38, 15);
            lblAsistio.TabIndex = 2;
            lblAsistio.Text = "label1";
            // 
            // lblNoAsistio
            // 
            lblNoAsistio.AutoSize = true;
            lblNoAsistio.Location = new Point(388, 77);
            lblNoAsistio.Name = "lblNoAsistio";
            lblNoAsistio.Size = new Size(38, 15);
            lblNoAsistio.TabIndex = 3;
            lblNoAsistio.Text = "label2";
            // 
            // dtpBusqueda
            // 
            dtpBusqueda.Location = new Point(12, 18);
            dtpBusqueda.Name = "dtpBusqueda";
            dtpBusqueda.Size = new Size(200, 23);
            dtpBusqueda.TabIndex = 4;
            dtpBusqueda.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // frmBusqueda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 420);
            Controls.Add(dtpBusqueda);
            Controls.Add(lblNoAsistio);
            Controls.Add(lblAsistio);
            Controls.Add(dgvBusqueda);
            Controls.Add(txtBusqueda);
            Name = "frmBusqueda";
            Text = "frmBusqueda";
            Load += frmBusqueda_Load;
            ((System.ComponentModel.ISupportInitialize)dgvBusqueda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBusqueda;
        private DataGridView dgvBusqueda;
        private Label lblAsistio;
        private Label lblNoAsistio;
        private DateTimePicker dtpBusqueda;
    }
}