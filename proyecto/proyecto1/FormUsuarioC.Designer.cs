namespace proyecto1
{
    partial class FormUsuarioC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuarioC));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRODEVENTASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cOMPRASToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rEGISTRODEVENTASToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.nOMBREToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gRUPOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mARCAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dESCRIPCIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mODELOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightGray;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vENTASToolStripMenuItem,
            this.cOMPRASToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1824, 124);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vENTASToolStripMenuItem
            // 
            this.vENTASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRODEVENTASToolStripMenuItem});
            this.vENTASToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("vENTASToolStripMenuItem.Image")));
            this.vENTASToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.vENTASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.vENTASToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.vENTASToolStripMenuItem.Name = "vENTASToolStripMenuItem";
            this.vENTASToolStripMenuItem.Size = new System.Drawing.Size(182, 120);
            this.vENTASToolStripMenuItem.Text = "VENTAS";
            // 
            // rEGISTRODEVENTASToolStripMenuItem
            // 
            this.rEGISTRODEVENTASToolStripMenuItem.Name = "rEGISTRODEVENTASToolStripMenuItem";
            this.rEGISTRODEVENTASToolStripMenuItem.Size = new System.Drawing.Size(199, 26);
            this.rEGISTRODEVENTASToolStripMenuItem.Text = "REALIZAR VENTA";
            this.rEGISTRODEVENTASToolStripMenuItem.Click += new System.EventHandler(this.rEGISTRODEVENTASToolStripMenuItem_Click);
            // 
            // cOMPRASToolStripMenuItem
            // 
            this.cOMPRASToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rEGISTRODEVENTASToolStripMenuItem1});
            this.cOMPRASToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cOMPRASToolStripMenuItem.Image")));
            this.cOMPRASToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.cOMPRASToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.White;
            this.cOMPRASToolStripMenuItem.Name = "cOMPRASToolStripMenuItem";
            this.cOMPRASToolStripMenuItem.Size = new System.Drawing.Size(213, 120);
            this.cOMPRASToolStripMenuItem.Text = "PRODUCTOS";
            // 
            // rEGISTRODEVENTASToolStripMenuItem1
            // 
            this.rEGISTRODEVENTASToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nOMBREToolStripMenuItem,
            this.gRUPOToolStripMenuItem,
            this.mARCAToolStripMenuItem,
            this.dESCRIPCIONToolStripMenuItem,
            this.mODELOToolStripMenuItem});
            this.rEGISTRODEVENTASToolStripMenuItem1.Name = "rEGISTRODEVENTASToolStripMenuItem1";
            this.rEGISTRODEVENTASToolStripMenuItem1.Size = new System.Drawing.Size(219, 26);
            this.rEGISTRODEVENTASToolStripMenuItem1.Text = "BUSCAR PRODUCTO";
            this.rEGISTRODEVENTASToolStripMenuItem1.Click += new System.EventHandler(this.rEGISTRODEVENTASToolStripMenuItem1_Click);
            // 
            // nOMBREToolStripMenuItem
            // 
            this.nOMBREToolStripMenuItem.Name = "nOMBREToolStripMenuItem";
            this.nOMBREToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.nOMBREToolStripMenuItem.Text = "NOMBRE";
            this.nOMBREToolStripMenuItem.Click += new System.EventHandler(this.nOMBREToolStripMenuItem_Click);
            // 
            // gRUPOToolStripMenuItem
            // 
            this.gRUPOToolStripMenuItem.Name = "gRUPOToolStripMenuItem";
            this.gRUPOToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.gRUPOToolStripMenuItem.Text = "GRUPO";
            this.gRUPOToolStripMenuItem.Click += new System.EventHandler(this.gRUPOToolStripMenuItem_Click);
            // 
            // mARCAToolStripMenuItem
            // 
            this.mARCAToolStripMenuItem.Name = "mARCAToolStripMenuItem";
            this.mARCAToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.mARCAToolStripMenuItem.Text = "MARCA";
            this.mARCAToolStripMenuItem.Click += new System.EventHandler(this.mARCAToolStripMenuItem_Click);
            // 
            // dESCRIPCIONToolStripMenuItem
            // 
            this.dESCRIPCIONToolStripMenuItem.Name = "dESCRIPCIONToolStripMenuItem";
            this.dESCRIPCIONToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.dESCRIPCIONToolStripMenuItem.Text = "DESCRIPCION";
            this.dESCRIPCIONToolStripMenuItem.Click += new System.EventHandler(this.dESCRIPCIONToolStripMenuItem_Click);
            // 
            // mODELOToolStripMenuItem
            // 
            this.mODELOToolStripMenuItem.Name = "mODELOToolStripMenuItem";
            this.mODELOToolStripMenuItem.Size = new System.Drawing.Size(176, 26);
            this.mODELOToolStripMenuItem.Text = "MODELO";
            this.mODELOToolStripMenuItem.Click += new System.EventHandler(this.mODELOToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palace Script MT", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(1539, 845);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 56);
            this.label1.TabIndex = 3;
            this.label1.Text = "Comercial Batz";
            // 
            // FormUsuarioC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1824, 878);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormUsuarioC";
            this.Text = "Usuario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormUsuarioC_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODEVENTASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cOMPRASToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rEGISTRODEVENTASToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem nOMBREToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gRUPOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mARCAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dESCRIPCIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mODELOToolStripMenuItem;
        private System.Windows.Forms.Label label1;
    }
}