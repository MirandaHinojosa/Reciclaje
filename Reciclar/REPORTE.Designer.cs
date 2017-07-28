namespace Reciclar
{
    partial class REPORTE
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
            this.VisorReporte = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // VisorReporte
            // 
            this.VisorReporte.ActiveViewIndex = -1;
            this.VisorReporte.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.VisorReporte.CachedPageNumberPerDoc = 10;
            this.VisorReporte.Cursor = System.Windows.Forms.Cursors.Default;
            this.VisorReporte.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisorReporte.Location = new System.Drawing.Point(0, 0);
            this.VisorReporte.Name = "VisorReporte";
            this.VisorReporte.Size = new System.Drawing.Size(768, 400);
            this.VisorReporte.TabIndex = 0;
            // 
            // REPORTE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 400);
            this.Controls.Add(this.VisorReporte);
            this.Name = "REPORTE";
            this.Text = "REPORTE";
            this.Load += new System.EventHandler(this.REPORTE_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer VisorReporte;
    }
}