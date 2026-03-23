namespace WinMySQL.Views
{
    partial class frmReporte
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReporte));
            report1 = new FastReport.Report();
            bindingSourceMySQL = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)report1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMySQL).BeginInit();
            SuspendLayout();
            // 
            // report1
            // 
            report1.ReportResourceString = resources.GetString("report1.ReportResourceString");
            // 
            // frmReporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(650, 363);
            Name = "frmReporte";
            Text = "frmReporte";
            Load += frmReporte_Load;
            ((System.ComponentModel.ISupportInitialize)report1).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSourceMySQL).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FastReport.Report report1;
        private BindingSource bindingSourceMySQL;
    }
}