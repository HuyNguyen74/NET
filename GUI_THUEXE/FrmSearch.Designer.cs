namespace GUI_THUEXE
{
    partial class FrmSearch
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
            this.rdcustomer = new System.Windows.Forms.RadioButton();
            this.rdcar = new System.Windows.Forms.RadioButton();
            this.grbcustomer = new System.Windows.Forms.GroupBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.butfind = new System.Windows.Forms.Button();
            this.grbcar = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcarname = new System.Windows.Forms.TextBox();
            this.txtlicense = new System.Windows.Forms.TextBox();
            this.Ord = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tenkh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sdt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CarName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bienso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.makh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbcustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            this.grbcar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rdcustomer
            // 
            this.rdcustomer.AutoSize = true;
            this.rdcustomer.Location = new System.Drawing.Point(54, 76);
            this.rdcustomer.Margin = new System.Windows.Forms.Padding(4);
            this.rdcustomer.Name = "rdcustomer";
            this.rdcustomer.Size = new System.Drawing.Size(112, 24);
            this.rdcustomer.TabIndex = 1;
            this.rdcustomer.TabStop = true;
            this.rdcustomer.Text = "Customers";
            this.rdcustomer.UseVisualStyleBackColor = true;
            this.rdcustomer.CheckedChanged += new System.EventHandler(this.rdcustomer_CheckedChanged);
            // 
            // rdcar
            // 
            this.rdcar.AutoSize = true;
            this.rdcar.Location = new System.Drawing.Point(54, 136);
            this.rdcar.Margin = new System.Windows.Forms.Padding(4);
            this.rdcar.Name = "rdcar";
            this.rdcar.Size = new System.Drawing.Size(66, 24);
            this.rdcar.TabIndex = 1;
            this.rdcar.TabStop = true;
            this.rdcar.Text = "Cars";
            this.rdcar.UseVisualStyleBackColor = true;
            this.rdcar.CheckedChanged += new System.EventHandler(this.rdcar_CheckedChanged);
            // 
            // grbcustomer
            // 
            this.grbcustomer.Controls.Add(this.txtname);
            this.grbcustomer.Controls.Add(this.label1);
            this.grbcustomer.Location = new System.Drawing.Point(323, 32);
            this.grbcustomer.Margin = new System.Windows.Forms.Padding(4);
            this.grbcustomer.Name = "grbcustomer";
            this.grbcustomer.Padding = new System.Windows.Forms.Padding(4);
            this.grbcustomer.Size = new System.Drawing.Size(543, 147);
            this.grbcustomer.TabIndex = 2;
            this.grbcustomer.TabStop = false;
            this.grbcustomer.Text = "Customer";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(113, 42);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(268, 27);
            this.txtname.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ord,
            this.tenkh,
            this.sdt,
            this.email,
            this.CarName,
            this.bienso,
            this.makh});
            this.dgvCustomer.Location = new System.Drawing.Point(132, 222);
            this.dgvCustomer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.RowTemplate.Height = 24;
            this.dgvCustomer.Size = new System.Drawing.Size(880, 337);
            this.dgvCustomer.TabIndex = 4;
            // 
            // butfind
            // 
            this.butfind.Location = new System.Drawing.Point(922, 56);
            this.butfind.Name = "butfind";
            this.butfind.Size = new System.Drawing.Size(74, 35);
            this.butfind.TabIndex = 2;
            this.butfind.Text = "Find";
            this.butfind.UseVisualStyleBackColor = true;
            this.butfind.Click += new System.EventHandler(this.butfind_Click);
            // 
            // grbcar
            // 
            this.grbcar.Controls.Add(this.txtlicense);
            this.grbcar.Controls.Add(this.txtcarname);
            this.grbcar.Controls.Add(this.label3);
            this.grbcar.Controls.Add(this.label2);
            this.grbcar.Location = new System.Drawing.Point(323, 32);
            this.grbcar.Name = "grbcar";
            this.grbcar.Size = new System.Drawing.Size(591, 160);
            this.grbcar.TabIndex = 5;
            this.grbcar.TabStop = false;
            this.grbcar.Text = "Car";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 104);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "License plate";
            // 
            // txtcarname
            // 
            this.txtcarname.Location = new System.Drawing.Point(210, 49);
            this.txtcarname.Name = "txtcarname";
            this.txtcarname.Size = new System.Drawing.Size(253, 27);
            this.txtcarname.TabIndex = 1;
            // 
            // txtlicense
            // 
            this.txtlicense.Location = new System.Drawing.Point(210, 97);
            this.txtlicense.Name = "txtlicense";
            this.txtlicense.Size = new System.Drawing.Size(253, 27);
            this.txtlicense.TabIndex = 1;
            // 
            // Ord
            // 
            this.Ord.DataPropertyName = "ord";
            this.Ord.HeaderText = "ord";
            this.Ord.Name = "Ord";
            this.Ord.Width = 70;
            // 
            // tenkh
            // 
            this.tenkh.DataPropertyName = "tenkh";
            this.tenkh.HeaderText = "Name";
            this.tenkh.Name = "tenkh";
            this.tenkh.Width = 150;
            // 
            // sdt
            // 
            this.sdt.DataPropertyName = "sdt";
            this.sdt.HeaderText = "Phone";
            this.sdt.Name = "sdt";
            this.sdt.Width = 120;
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.Width = 180;
            // 
            // CarName
            // 
            this.CarName.DataPropertyName = "tenxe";
            this.CarName.HeaderText = "CarName";
            this.CarName.Name = "CarName";
            this.CarName.Width = 150;
            // 
            // bienso
            // 
            this.bienso.DataPropertyName = "bienso";
            this.bienso.HeaderText = "License plate";
            this.bienso.Name = "bienso";
            this.bienso.Width = 150;
            // 
            // makh
            // 
            this.makh.DataPropertyName = "makh";
            this.makh.HeaderText = "Id";
            this.makh.Name = "makh";
            this.makh.ReadOnly = true;
            this.makh.Visible = false;
            // 
            // FrmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1065, 567);
            this.Controls.Add(this.grbcar);
            this.Controls.Add(this.butfind);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.grbcustomer);
            this.Controls.Add(this.rdcar);
            this.Controls.Add(this.rdcustomer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSearch";
            this.Text = "FrmSearch";
            this.Load += new System.EventHandler(this.FrmSearch_Load);
            this.grbcustomer.ResumeLayout(false);
            this.grbcustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            this.grbcar.ResumeLayout(false);
            this.grbcar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdcustomer;
        private System.Windows.Forms.RadioButton rdcar;
        private System.Windows.Forms.GroupBox grbcustomer;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button butfind;
        private System.Windows.Forms.GroupBox grbcar;
        private System.Windows.Forms.TextBox txtlicense;
        private System.Windows.Forms.TextBox txtcarname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ord;
        private System.Windows.Forms.DataGridViewTextBoxColumn tenkh;
        private System.Windows.Forms.DataGridViewTextBoxColumn sdt;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn CarName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bienso;
        private System.Windows.Forms.DataGridViewTextBoxColumn makh;
    }
}