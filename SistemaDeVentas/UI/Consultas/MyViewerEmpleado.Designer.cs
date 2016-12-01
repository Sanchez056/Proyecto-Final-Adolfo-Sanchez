namespace SistemaDeVentas.UI.Consultas
{
    partial class MyViewerEmpleado
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
            this.EmpleadoreportViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // EmpleadoreportViewer
            // 
            this.EmpleadoreportViewer.Location = new System.Drawing.Point(2, 2);
            this.EmpleadoreportViewer.Name = "EmpleadoreportViewer";
            this.EmpleadoreportViewer.Size = new System.Drawing.Size(799, 413);
            this.EmpleadoreportViewer.TabIndex = 0;
            this.EmpleadoreportViewer.Load += new System.EventHandler(this.EmpleadoreportViewer_Load);
            // 
            // MyViewerEmpleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 414);
            this.Controls.Add(this.EmpleadoreportViewer);
            this.Name = "MyViewerEmpleado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MyViewerEmpleado_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer EmpleadoreportViewer;
    }
}