namespace GUI_THUEXE
{
    partial class FrmCar
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
            this.dgvCar = new System.Windows.Forms.DataGridView();
            this.Ord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.butclose = new System.Windows.Forms.Button();
            this.butdelete = new System.Windows.Forms.Button();
            this.butupdate = new System.Windows.Forms.Button();
            this.butadd = new System.Windows.Forms.Button();
            this.butreset = new System.Windows.Forms.Button();
            this.butnew = new System.Windows.Forms.Button();
            this.txtlicense = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbcustomer = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCar
            // 
            this.dgvCar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ord,
            this.maxe,
            this.tenkh,
            this.email,
            this.makh});
            this.dgvCar.Location = new System.Drawing.Point(298, 218);
            this.dgvCar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvCar.Name = "dgvCar";
            this.dgvCar.RowTemplate.Height = 24;
            this.dgvCar.Size = new System.Drawing.Size(638, 286);
            this.dgvCar.TabIndex = 16;
            this.dgvCar.Click += new System.EventHandler(this.dgvCar_Click);
            // 
            // Ord
            // 
            this.Ord.DataPropertyName = "ord";
            this.Ord.HeaderText = "ord";
            this.Ord.Name = "Ord";
            this.Ord.Width = 70;
            // 
            // maxe
            // 
            this.maxe.DataPropertyName = "maxe";
            this.maxe.HeaderText = "CarID";
            this.maxe.Name = "maxe";
            this.maxe.ReadOnly = true;
            this.maxe.Visible = false;
            this.maxe.Width = 70;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenxe";
            this.tenkh.HeaderText = "Name";
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 180;
            // 
            // email
            // 
            this.email.DataPropertyName = "bienso";
            this.email.HeaderText = "Licecse plate";
            this.email.Name = "email";
            this.email.Width = 150;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "CustomerID";
            this.makh.Name = "makh";
            this.makh.Width = 70;
            // 
            // butclose
            // 
            this.butclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butclose.Location = new System.Drawing.Point(130, 475);
            this.butclose.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butclose.Name = "butclose";
            this.butclose.Size = new System.Drawing.Size(93, 29);
            this.butclose.TabIndex = 10;
            this.butclose.Text = "Close";
            this.butclose.UseVisualStyleBackColor = true;
            this.butclose.Click += new System.EventHandler(this.butclose_Click);
            // 
            // butdelete
            // 
            this.butdelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butdelete.Location = new System.Drawing.Point(130, 398);
            this.butdelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butdelete.Name = "butdelete";
            this.butdelete.Size = new System.Drawing.Size(93, 29);
            this.butdelete.TabIndex = 11;
            this.butdelete.Text = "Delete";
            this.butdelete.UseVisualStyleBackColor = true;
            this.butdelete.Click += new System.EventHandler(this.butdelete_Click);
            // 
            // butupdate
            // 
            this.butupdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butupdate.Location = new System.Drawing.Point(130, 343);
            this.butupdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butupdate.Name = "butupdate";
            this.butupdate.Size = new System.Drawing.Size(93, 29);
            this.butupdate.TabIndex = 12;
            this.butupdate.Text = "Update";
            this.butupdate.UseVisualStyleBackColor = true;
            this.butupdate.Click += new System.EventHandler(this.butupdate_Click);
            // 
            // butadd
            // 
            this.butadd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butadd.Location = new System.Drawing.Point(130, 286);
            this.butadd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butadd.Name = "butadd";
            this.butadd.Size = new System.Drawing.Size(93, 29);
            this.butadd.TabIndex = 13;
            this.butadd.Text = "Add";
            this.butadd.UseVisualStyleBackColor = true;
            this.butadd.Click += new System.EventHandler(this.butadd_Click);
            // 
            // butreset
            // 
            this.butreset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butreset.Location = new System.Drawing.Point(775, 29);
            this.butreset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butreset.Name = "butreset";
            this.butreset.Size = new System.Drawing.Size(93, 29);
            this.butreset.TabIndex = 14;
            this.butreset.Text = "Reset";
            this.butreset.UseVisualStyleBackColor = true;
            this.butreset.Click += new System.EventHandler(this.butreset_Click);
            // 
            // butnew
            // 
            this.butnew.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butnew.Location = new System.Drawing.Point(656, 27);
            this.butnew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.butnew.Name = "butnew";
            this.butnew.Size = new System.Drawing.Size(93, 29);
            this.butnew.TabIndex = 15;
            this.butnew.Text = "...";
            this.butnew.UseVisualStyleBackColor = true;
            this.butnew.Click += new System.EventHandler(this.butnew_Click);
            // 
            // txtlicense
            // 
            this.txtlicense.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtlicense.Location = new System.Drawing.Point(305, 129);
            this.txtlicense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtlicense.Name = "txtlicense";
            this.txtlicense.Size = new System.Drawing.Size(262, 27);
            this.txtlicense.TabIndex = 8;
            // 
            // txtname
            // 
            this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtname.Location = new System.Drawing.Point(305, 72);
            this.txtname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(262, 27);
            this.txtname.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(151, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "License plate";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(151, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Customers";
            // 
            // cmbcustomer
            // 
            this.cmbcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcustomer.FormattingEnabled = true;
            this.cmbcustomer.Location = new System.Drawing.Point(305, 34);
            this.cmbcustomer.Name = "cmbcustomer";
            this.cmbcustomer.Size = new System.Drawing.Size(262, 28);
            this.cmbcustomer.TabIndex = 17;
            this.cmbcustomer.SelectedIndexChanged += new System.EventHandler(this.cmbcustomer_SelectedIndexChanged_1);
            // 
            // FrmCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 531);
            this.Controls.Add(this.cmbcustomer);
            this.Controls.Add(this.dgvCar);
            this.Controls.Add(this.butclose);
            this.Controls.Add(this.butdelete);
            this.Controls.Add(this.butupdate);
            this.Controls.Add(this.butadd);
            this.Controls.Add(this.butreset);
            this.Controls.Add(this.butnew);
            this.Controls.Add(this.txtlicense);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmCar";
            this.Text = "FrmCar";
            this.Activated += new System.EventHandler(this.FrmCar_Activated);
            this.Load += new System.EventHandler(this.FrmCar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvCar;
        private System.Windows.Forms.Button butclose;
        private System.Windows.Forms.Button butdelete;
        private System.Windows.Forms.Button butupdate;
        private System.Windows.Forms.Button butadd;
        private System.Windows.Forms.Button butreset;
        private System.Windows.Forms.Button butnew;
        private System.Windows.Forms.TextBox txtlicense;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbcustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxe;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
    }
}