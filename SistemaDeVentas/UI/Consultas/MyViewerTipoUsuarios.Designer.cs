namespace SistemaDeVentas.UI.Consultas
{
    partial class MyViewerTipoUsuarios
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
            this.TipoUsuariosreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // TipoUsuariosreportViewer
            // 
            this.TipoUsuariosreportViewer.Location = new System.Drawing.Point(-2, -1);
            this.TipoUsuariosreportViewer.Name = "TipoUsuariosreportViewer";
            this.TipoUsuariosreportViewer.Size = new System.Drawing.Size(505, 315);
            this.TipoUsuariosreportViewer.TabIndex = 0;
            // 
            // MyViewerTipoUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 315);
            this.Controls.Add(this.TipoUsuariosreportViewer);
            this.Name = "MyViewerTipoUsuarios";
            this.Text = "MyViewerTipoUsuarios";
            this.Load += new System.EventHandler(this.MyViewerTipoUsuarios_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer TipoUsuariosreportViewer;
    }
}