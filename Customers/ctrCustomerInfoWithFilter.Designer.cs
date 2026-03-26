namespace CarRental_3_
{
    partial class ctrCustomerInfoWithFilter
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ctrCustomerInfoWithFilter));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ctrPersonInfo1 = new CarRental_3_.ctrPersonInfo();
            this.gbFilter = new System.Windows.Forms.GroupBox();
            this.btnAddNewCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.btnFindCustomer = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.cmFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.groupBox1.SuspendLayout();
            this.gbFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ctrPersonInfo1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(0, 91);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(870, 298);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Customer Info";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ctrPersonInfo1
            // 
            this.ctrPersonInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.ctrPersonInfo1.Location = new System.Drawing.Point(1, 14);
            this.ctrPersonInfo1.Name = "ctrPersonInfo1";
            this.ctrPersonInfo1.Size = new System.Drawing.Size(863, 278);
            this.ctrPersonInfo1.TabIndex = 0;
            this.ctrPersonInfo1.PersonInfo += new System.EventHandler<CarRental_3_.ctrPersonInfo.clsPersonInfoFoundArgs>(this.ctrPersonInfo1_PersonInfo);
            this.ctrPersonInfo1.Load += new System.EventHandler(this.ctrPersonInfo1_Load);
            // 
            // gbFilter
            // 
            this.gbFilter.Controls.Add(this.btnAddNewCustomer);
            this.gbFilter.Controls.Add(this.btnFindCustomer);
            this.gbFilter.Controls.Add(this.txtSearch);
            this.gbFilter.Controls.Add(this.cmFilter);
            this.gbFilter.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbFilter.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.gbFilter.Location = new System.Drawing.Point(3, 10);
            this.gbFilter.Name = "gbFilter";
            this.gbFilter.Size = new System.Drawing.Size(867, 75);
            this.gbFilter.TabIndex = 75;
            this.gbFilter.TabStop = false;
            this.gbFilter.Text = "Filter";
            this.gbFilter.Enter += new System.EventHandler(this.gbFilter_Enter);
            // 
            // btnAddNewCustomer
            // 
            this.btnAddNewCustomer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnAddNewCustomer.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnAddNewCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddNewCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddNewCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddNewCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnAddNewCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddNewCustomer.ForeColor = System.Drawing.Color.White;
            this.btnAddNewCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnAddNewCustomer.Image")));
            this.btnAddNewCustomer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnAddNewCustomer.Location = new System.Drawing.Point(775, 14);
            this.btnAddNewCustomer.Name = "btnAddNewCustomer";
            this.btnAddNewCustomer.Size = new System.Drawing.Size(63, 55);
            this.btnAddNewCustomer.TabIndex = 74;
            this.btnAddNewCustomer.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // btnFindCustomer
            // 
            this.btnFindCustomer.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnFindCustomer.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnFindCustomer.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnFindCustomer.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnFindCustomer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnFindCustomer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnFindCustomer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(55)))), ((int)(((byte)(70)))));
            this.btnFindCustomer.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnFindCustomer.ForeColor = System.Drawing.Color.White;
            this.btnFindCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnFindCustomer.Image")));
            this.btnFindCustomer.ImageSize = new System.Drawing.Size(50, 50);
            this.btnFindCustomer.Location = new System.Drawing.Point(661, 14);
            this.btnFindCustomer.Name = "btnFindCustomer";
            this.btnFindCustomer.Size = new System.Drawing.Size(63, 55);
            this.btnFindCustomer.TabIndex = 73;
            this.btnFindCustomer.Click += new System.EventHandler(this.btnAddNewVehicle_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearch.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            this.txtSearch.BorderThickness = 2;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(250, 24);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.White;
            this.txtSearch.PlaceholderText = "";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(233, 29);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 1;
            this.txtSearch.Visible = false;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSearch_KeyPress);
            // 
            // cmFilter
            // 
            this.cmFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.cmFilter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmFilter.ForeColor = System.Drawing.Color.Black;
            this.cmFilter.ItemHeight = 20;
            this.cmFilter.Items.AddRange(new object[] {
            "None",
            "CustomerID",
            "NationalNo"});
            this.cmFilter.Location = new System.Drawing.Point(6, 24);
            this.cmFilter.Name = "cmFilter";
            this.cmFilter.Size = new System.Drawing.Size(214, 26);
            this.cmFilter.TabIndex = 0;
            this.cmFilter.SelectedIndexChanged += new System.EventHandler(this.cmFilter_SelectedIndexChanged);
            // 
            // ctrCustomerInfoWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.Controls.Add(this.gbFilter);
            this.Controls.Add(this.groupBox1);
            this.Name = "ctrCustomerInfoWithFilter";
            this.Size = new System.Drawing.Size(877, 395);
            this.groupBox1.ResumeLayout(false);
            this.gbFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox gbFilter;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2ComboBox cmFilter;
        private Guna.UI2.WinForms.Guna2Button btnAddNewCustomer;
        private Guna.UI2.WinForms.Guna2Button btnFindCustomer;
        private ctrPersonInfo ctrPersonInfo1;
    }
}
