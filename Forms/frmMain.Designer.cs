namespace MicroMEMSVer3.Forms
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.quanLiThietBiYTeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quanLiLinhKienThietBiYTeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quanLiThietBiYTeToolStripMenuItem,
            this.quanLiLinhKienThietBiYTeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // quanLiThietBiYTeToolStripMenuItem
            // 
            this.quanLiThietBiYTeToolStripMenuItem.Name = "quanLiThietBiYTeToolStripMenuItem";
            this.quanLiThietBiYTeToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.quanLiThietBiYTeToolStripMenuItem.Text = "Quan Li Thiet Bi Y Te";
            // 
            // quanLiLinhKienThietBiYTeToolStripMenuItem
            // 
            this.quanLiLinhKienThietBiYTeToolStripMenuItem.Name = "quanLiLinhKienThietBiYTeToolStripMenuItem";
            this.quanLiLinhKienThietBiYTeToolStripMenuItem.Size = new System.Drawing.Size(178, 20);
            this.quanLiLinhKienThietBiYTeToolStripMenuItem.Text = "Quan Li Linh Kien Thiet Bi Y Te";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem quanLiThietBiYTeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quanLiLinhKienThietBiYTeToolStripMenuItem;
    }
}