namespace GUI_THUEXE
{
    partial class menu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnsystem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnlogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnlogout = new System.Windows.Forms.ToolStripMenuItem();
            this.mnchange = new System.Windows.Forms.ToolStripMenuItem();
            this.mnclose = new System.Windows.Forms.ToolStripMenuItem();
            this.mncustomer = new System.Windows.Forms.ToolStripMenuItem();
            this.mncus = new System.Windows.Forms.ToolStripMenuItem();
            this.mncar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnsearch = new System.Windows.Forms.ToolStripMenuItem();
            this.mnreport = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnsystem,
            this.mncustomer,
            this.mnsearch,
            this.mnreport});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(982, 36);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnsystem
            // 
            this.mnsystem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnlogin,
            this.mnlogout,
            this.mnchange,
            this.mnclose});
            this.mnsystem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsystem.Name = "mnsystem";
            this.mnsystem.Size = new System.Drawing.Size(86, 32);
            this.mnsystem.Text = "System";
            // 
            // mnlogin
            // 
            this.mnlogin.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnlogin.Name = "mnlogin";
            this.mnlogin.Size = new System.Drawing.Size(244, 32);
            this.mnlogin.Text = "Login";
            this.mnlogin.Click += new System.EventHandler(this.loginToolStripMenuItem_Click);
            // 
            // mnlogout
            // 
            this.mnlogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnlogout.Name = "mnlogout";
            this.mnlogout.Size = new System.Drawing.Size(244, 32);
            this.mnlogout.Text = "Logout";
            this.mnlogout.Click += new System.EventHandler(this.mnlogout_Click);
            // 
            // mnchange
            // 
            this.mnchange.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnchange.Name = "mnchange";
            this.mnchange.Size = new System.Drawing.Size(244, 32);
            this.mnchange.Text = "Change password";
            this.mnchange.Click += new System.EventHandler(this.mnchange_Click);
            // 
            // mnclose
            // 
            this.mnclose.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnclose.Name = "mnclose";
            this.mnclose.Size = new System.Drawing.Size(244, 32);
            this.mnclose.Text = "Close";
            this.mnclose.Click += new System.EventHandler(this.mnclose_Click);
            // 
            // mncustomer
            // 
            this.mncustomer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mncus,
            this.mncar});
            this.mncustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mncustomer.Name = "mncustomer";
            this.mncustomer.Size = new System.Drawing.Size(228, 32);
            this.mncustomer.Text = "Customer management";
            // 
            // mncus
            // 
            this.mncus.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mncus.Name = "mncus";
            this.mncus.Size = new System.Drawing.Size(216, 32);
            this.mncus.Text = "Customers";
            this.mncus.Click += new System.EventHandler(this.mncus_Click);
            // 
            // mncar
            // 
            this.mncar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mncar.Name = "mncar";
            this.mncar.Size = new System.Drawing.Size(216, 32);
            this.mncar.Text = "Cars";
            this.mncar.Click += new System.EventHandler(this.mncar_Click);
            // 
            // mnsearch
            // 
            this.mnsearch.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnsearch.Name = "mnsearch";
            this.mnsearch.Size = new System.Drawing.Size(82, 32);
            this.mnsearch.Text = "Search";
            this.mnsearch.Click += new System.EventHandler(this.mnsearch_Click);
            // 
            // mnreport
            // 
            this.mnreport.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnreport.Name = "mnreport";
            this.mnreport.Size = new System.Drawing.Size(83, 32);
            this.mnreport.Text = "Report";
            this.mnreport.Click += new System.EventHandler(this.mnreport_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 503);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "menu";
            this.Text = "menu";
            this.Activated += new System.EventHandler(this.menu_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnsystem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnlogin;
        private System.Windows.Forms.ToolStripMenuItem mnlogout;
        private System.Windows.Forms.ToolStripMenuItem mncustomer;
        private System.Windows.Forms.ToolStripMenuItem mnsearch;
        private System.Windows.Forms.ToolStripMenuItem mnreport;
        private System.Windows.Forms.ToolStripMenuItem mnchange;
        private System.Windows.Forms.ToolStripMenuItem mnclose;
        private System.Windows.Forms.ToolStripMenuItem mncus;
        private System.Windows.Forms.ToolStripMenuItem mncar;
    }
}

