namespace CarRental_3_
{
    partial class frmAddNewEditBooking
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAddNewEditBooking));
            this.tbBooking = new System.Windows.Forms.TabPage();
            this.guna2Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.llTrancationDeteils = new System.Windows.Forms.LinkLabel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox16 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtEnd = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.dtStart = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.lblRentalPrice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblrentalDays = new System.Windows.Forms.Label();
            this.lblBookingID = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDropOffLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2PictureBox10 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2PictureBox9 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox6 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.guna2PictureBox5 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPickUpLocation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label11 = new System.Windows.Forms.Label();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.tbCustomer = new System.Windows.Forms.TabPage();
            this.guna2Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.tbVehicle = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.MainTab = new Guna.UI2.WinForms.Guna2TabControl();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrCustomerInfoWithFilter2 = new CarRental_3_.ctrCustomerInfoWithFilter();
            this.tbBooking.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            this.tbCustomer.SuspendLayout();
            this.tbVehicle.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.MainTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbBooking
            // 
            this.tbBooking.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.tbBooking.Controls.Add(this.guna2Button4);
            this.tbBooking.Controls.Add(this.btnSave);
            this.tbBooking.Controls.Add(this.groupBox2);
            this.tbBooking.Controls.Add(this.label11);
            this.tbBooking.Controls.Add(this.guna2PictureBox4);
            this.tbBooking.Controls.Add(this.lblTotalPrice);
            this.tbBooking.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbBooking.Location = new System.Drawing.Point(4, 44);
            this.tbBooking.Name = "tbBooking";
            this.tbBooking.Padding = new System.Windows.Forms.Padding(3);
            this.tbBooking.Size = new System.Drawing.Size(993, 478);
            this.tbBooking.TabIndex = 2;
            this.tbBooking.Text = "Booking ";
            this.tbBooking.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // guna2Button4
            // 
            this.guna2Button4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button4.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Button4.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button4.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button4.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button4.ForeColor = System.Drawing.Color.White;
            this.guna2Button4.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button4.Image")));
            this.guna2Button4.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button4.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button4.Location = new System.Drawing.Point(542, 423);
            this.guna2Button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Button4.Name = "guna2Button4";
            this.guna2Button4.Size = new System.Drawing.Size(158, 48);
            this.guna2Button4.TabIndex = 75;
            this.guna2Button4.Text = "Close";
            this.guna2Button4.Click += new System.EventHandler(this.guna2Button4_Click);
            // 
            // btnSave
            // 
            this.btnSave.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSave.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnSave.ImageSize = new System.Drawing.Size(40, 40);
            this.btnSave.Location = new System.Drawing.Point(816, 425);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(170, 47);
            this.btnSave.TabIndex = 74;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.llTrancationDeteils);
            this.groupBox2.Controls.Add(this.guna2PictureBox3);
            this.groupBox2.Controls.Add(this.guna2PictureBox16);
            this.groupBox2.Controls.Add(this.txtNote);
            this.groupBox2.Controls.Add(this.dtEnd);
            this.groupBox2.Controls.Add(this.dtStart);
            this.groupBox2.Controls.Add(this.lblRentalPrice);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.lblrentalDays);
            this.groupBox2.Controls.Add(this.lblBookingID);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtDropOffLocation);
            this.groupBox2.Controls.Add(this.guna2PictureBox10);
            this.groupBox2.Controls.Add(this.guna2PictureBox1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.guna2PictureBox9);
            this.groupBox2.Controls.Add(this.guna2PictureBox6);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.guna2PictureBox5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtPickUpLocation);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.guna2PictureBox2);
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox2.Location = new System.Drawing.Point(12, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(974, 400);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Booking Information";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // llTrancationDeteils
            // 
            this.llTrancationDeteils.AutoSize = true;
            this.llTrancationDeteils.Enabled = false;
            this.llTrancationDeteils.LinkColor = System.Drawing.Color.DarkOrange;
            this.llTrancationDeteils.Location = new System.Drawing.Point(17, 346);
            this.llTrancationDeteils.Name = "llTrancationDeteils";
            this.llTrancationDeteils.Size = new System.Drawing.Size(150, 20);
            this.llTrancationDeteils.TabIndex = 84;
            this.llTrancationDeteils.TabStop = true;
            this.llTrancationDeteils.Text = "Transaction Detailes";
            this.llTrancationDeteils.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llTrancationDeteils_LinkClicked);
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(207, 285);
            this.guna2PictureBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(37, 28);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 83;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox16
            // 
            this.guna2PictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox16.Image")));
            this.guna2PictureBox16.ImageRotate = 0F;
            this.guna2PictureBox16.Location = new System.Drawing.Point(172, 34);
            this.guna2PictureBox16.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox16.Name = "guna2PictureBox16";
            this.guna2PictureBox16.Size = new System.Drawing.Size(37, 31);
            this.guna2PictureBox16.TabIndex = 82;
            this.guna2PictureBox16.TabStop = false;
            // 
            // txtNote
            // 
            this.txtNote.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.txtNote.Location = new System.Drawing.Point(256, 295);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(697, 71);
            this.txtNote.TabIndex = 81;
            // 
            // dtEnd
            // 
            this.dtEnd.BorderThickness = 1;
            this.dtEnd.Checked = true;
            this.dtEnd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtEnd.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtEnd.Location = new System.Drawing.Point(751, 81);
            this.dtEnd.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtEnd.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.Size = new System.Drawing.Size(209, 36);
            this.dtEnd.TabIndex = 80;
            this.dtEnd.Value = new System.DateTime(2023, 12, 17, 11, 33, 22, 582);
            this.dtEnd.ValueChanged += new System.EventHandler(this.dtEnd_ValueChanged);
            // 
            // dtStart
            // 
            this.dtStart.BorderThickness = 1;
            this.dtStart.Checked = true;
            this.dtStart.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtStart.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtStart.Location = new System.Drawing.Point(221, 76);
            this.dtStart.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtStart.MinDate = new System.DateTime(2023, 12, 17, 11, 34, 43, 0);
            this.dtStart.Name = "dtStart";
            this.dtStart.Size = new System.Drawing.Size(210, 36);
            this.dtStart.TabIndex = 79;
            this.dtStart.Value = new System.DateTime(2023, 12, 17, 11, 34, 43, 0);
            // 
            // lblRentalPrice
            // 
            this.lblRentalPrice.AutoSize = true;
            this.lblRentalPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRentalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblRentalPrice.Location = new System.Drawing.Point(747, 235);
            this.lblRentalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRentalPrice.Name = "lblRentalPrice";
            this.lblRentalPrice.Size = new System.Drawing.Size(61, 23);
            this.lblRentalPrice.TabIndex = 78;
            this.lblRentalPrice.Text = "[???]";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label12.Location = new System.Drawing.Point(14, 285);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(167, 23);
            this.label12.TabIndex = 75;
            this.label12.Text = "Addtional Note :";
            // 
            // lblrentalDays
            // 
            this.lblrentalDays.AutoSize = true;
            this.lblrentalDays.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrentalDays.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblrentalDays.Location = new System.Drawing.Point(263, 235);
            this.lblrentalDays.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrentalDays.Name = "lblrentalDays";
            this.lblrentalDays.Size = new System.Drawing.Size(61, 23);
            this.lblrentalDays.TabIndex = 69;
            this.lblrentalDays.Text = "[???]";
            // 
            // lblBookingID
            // 
            this.lblBookingID.AutoSize = true;
            this.lblBookingID.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookingID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblBookingID.Location = new System.Drawing.Point(217, 34);
            this.lblBookingID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookingID.Name = "lblBookingID";
            this.lblBookingID.Size = new System.Drawing.Size(61, 23);
            this.lblBookingID.TabIndex = 47;
            this.lblBookingID.Text = "[???]";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(34, 34);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(130, 23);
            this.label7.TabIndex = 46;
            this.label7.Text = "Booking ID :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(536, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(160, 19);
            this.label5.TabIndex = 66;
            this.label5.Text = "Drop off Location :";
            // 
            // txtDropOffLocation
            // 
            this.txtDropOffLocation.AutoRoundedCorners = true;
            this.txtDropOffLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDropOffLocation.BorderRadius = 17;
            this.txtDropOffLocation.BorderThickness = 2;
            this.txtDropOffLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtDropOffLocation.DefaultText = "";
            this.txtDropOffLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDropOffLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDropOffLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDropOffLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDropOffLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.txtDropOffLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDropOffLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtDropOffLocation.ForeColor = System.Drawing.Color.White;
            this.txtDropOffLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDropOffLocation.Location = new System.Drawing.Point(751, 160);
            this.txtDropOffLocation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtDropOffLocation.Name = "txtDropOffLocation";
            this.txtDropOffLocation.PasswordChar = '\0';
            this.txtDropOffLocation.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtDropOffLocation.PlaceholderText = "";
            this.txtDropOffLocation.SelectedText = "";
            this.txtDropOffLocation.Size = new System.Drawing.Size(213, 37);
            this.txtDropOffLocation.TabIndex = 67;
            this.txtDropOffLocation.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingEmptyTextBox);
            // 
            // guna2PictureBox10
            // 
            this.guna2PictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox10.Image")));
            this.guna2PictureBox10.ImageRotate = 0F;
            this.guna2PictureBox10.Location = new System.Drawing.Point(704, 169);
            this.guna2PictureBox10.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox10.Name = "guna2PictureBox10";
            this.guna2PictureBox10.Size = new System.Drawing.Size(37, 28);
            this.guna2PictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox10.TabIndex = 68;
            this.guna2PictureBox10.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(707, 86);
            this.guna2PictureBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(37, 31);
            this.guna2PictureBox1.TabIndex = 64;
            this.guna2PictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(546, 87);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 19);
            this.label1.TabIndex = 63;
            this.label1.Text = "Rental End Date :";
            // 
            // guna2PictureBox9
            // 
            this.guna2PictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox9.Image")));
            this.guna2PictureBox9.ImageRotate = 0F;
            this.guna2PictureBox9.Location = new System.Drawing.Point(177, 235);
            this.guna2PictureBox9.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox9.Name = "guna2PictureBox9";
            this.guna2PictureBox9.Size = new System.Drawing.Size(37, 28);
            this.guna2PictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox9.TabIndex = 59;
            this.guna2PictureBox9.TabStop = false;
            // 
            // guna2PictureBox6
            // 
            this.guna2PictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox6.Image")));
            this.guna2PictureBox6.ImageRotate = 0F;
            this.guna2PictureBox6.Location = new System.Drawing.Point(701, 235);
            this.guna2PictureBox6.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox6.Name = "guna2PictureBox6";
            this.guna2PictureBox6.Size = new System.Drawing.Size(38, 28);
            this.guna2PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox6.TabIndex = 50;
            this.guna2PictureBox6.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(533, 235);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(169, 23);
            this.label8.TabIndex = 49;
            this.label8.Text = "Rental Price\\D  :";
            // 
            // guna2PictureBox5
            // 
            this.guna2PictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox5.Image")));
            this.guna2PictureBox5.ImageRotate = 0F;
            this.guna2PictureBox5.Location = new System.Drawing.Point(177, 81);
            this.guna2PictureBox5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox5.Name = "guna2PictureBox5";
            this.guna2PictureBox5.Size = new System.Drawing.Size(37, 31);
            this.guna2PictureBox5.TabIndex = 40;
            this.guna2PictureBox5.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(26, 169);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 19);
            this.label2.TabIndex = 23;
            this.label2.Text = "Pick Up Location :";
            // 
            // txtPickUpLocation
            // 
            this.txtPickUpLocation.AutoRoundedCorners = true;
            this.txtPickUpLocation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPickUpLocation.BorderRadius = 17;
            this.txtPickUpLocation.BorderThickness = 2;
            this.txtPickUpLocation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.txtPickUpLocation.DefaultText = "";
            this.txtPickUpLocation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPickUpLocation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPickUpLocation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickUpLocation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPickUpLocation.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.txtPickUpLocation.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPickUpLocation.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.txtPickUpLocation.ForeColor = System.Drawing.Color.White;
            this.txtPickUpLocation.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPickUpLocation.Location = new System.Drawing.Point(224, 160);
            this.txtPickUpLocation.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtPickUpLocation.Name = "txtPickUpLocation";
            this.txtPickUpLocation.PasswordChar = '\0';
            this.txtPickUpLocation.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.txtPickUpLocation.PlaceholderText = "";
            this.txtPickUpLocation.SelectedText = "";
            this.txtPickUpLocation.Size = new System.Drawing.Size(207, 37);
            this.txtPickUpLocation.TabIndex = 24;
            this.txtPickUpLocation.Validating += new System.ComponentModel.CancelEventHandler(this.ValidatingEmptyTextBox);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 19);
            this.label3.TabIndex = 25;
            this.label3.Text = "Rental Start Date :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(9, 235);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 19);
            this.label4.TabIndex = 30;
            this.label4.Text = "Initial Rental Days :";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(177, 169);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(37, 28);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 31;
            this.guna2PictureBox2.TabStop = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label11.Location = new System.Drawing.Point(15, 429);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(196, 23);
            this.label11.TabIndex = 71;
            this.label11.Text = "Total Due Amount :";
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(219, 424);
            this.guna2PictureBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(37, 28);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 72;
            this.guna2PictureBox4.TabStop = false;
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPrice.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTotalPrice.Location = new System.Drawing.Point(264, 429);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(61, 23);
            this.lblTotalPrice.TabIndex = 73;
            this.lblTotalPrice.Text = "[???]";
            // 
            // tbCustomer
            // 
            this.tbCustomer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.tbCustomer.Controls.Add(this.ctrCustomerInfoWithFilter2);
            this.tbCustomer.Controls.Add(this.guna2Button3);
            this.tbCustomer.Controls.Add(this.btnNext);
            this.tbCustomer.Location = new System.Drawing.Point(4, 44);
            this.tbCustomer.Name = "tbCustomer";
            this.tbCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.tbCustomer.Size = new System.Drawing.Size(993, 478);
            this.tbCustomer.TabIndex = 1;
            this.tbCustomer.Text = "Customer";
            this.tbCustomer.Click += new System.EventHandler(this.tbCustomer_Click);
            // 
            // guna2Button3
            // 
            this.guna2Button3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button3.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Button3.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button3.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button3.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button3.ForeColor = System.Drawing.Color.White;
            this.guna2Button3.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button3.Image")));
            this.guna2Button3.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button3.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button3.Location = new System.Drawing.Point(7, 426);
            this.guna2Button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Button3.Name = "guna2Button3";
            this.guna2Button3.Size = new System.Drawing.Size(158, 48);
            this.guna2Button3.TabIndex = 50;
            this.guna2Button3.Text = "Cancle";
            // 
            // btnNext
            // 
            this.btnNext.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnNext.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(816, 423);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(170, 48);
            this.btnNext.TabIndex = 46;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbVehicle
            // 
            this.tbVehicle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.tbVehicle.Controls.Add(this.groupBox1);
            this.tbVehicle.Controls.Add(this.guna2Button1);
            this.tbVehicle.Controls.Add(this.guna2Button2);
            this.tbVehicle.Location = new System.Drawing.Point(4, 44);
            this.tbVehicle.Name = "tbVehicle";
            this.tbVehicle.Padding = new System.Windows.Forms.Padding(3);
            this.tbVehicle.Size = new System.Drawing.Size(993, 478);
            this.tbVehicle.TabIndex = 0;
            this.tbVehicle.Text = "Vehicle";
            this.tbVehicle.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.flowLayoutPanel1);
            this.groupBox1.Location = new System.Drawing.Point(3, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 19);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(984, 399);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            this.flowLayoutPanel1.DoubleClick += new System.EventHandler(this.flowLayoutPanel1_DoubleClick);
            // 
            // guna2Button1
            // 
            this.guna2Button1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button1.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button1.Image")));
            this.guna2Button1.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.guna2Button1.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button1.Location = new System.Drawing.Point(3, 430);
            this.guna2Button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(158, 48);
            this.guna2Button1.TabIndex = 49;
            this.guna2Button1.Text = "Cancle";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // guna2Button2
            // 
            this.guna2Button2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.guna2Button2.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Image = ((System.Drawing.Image)(resources.GetObject("guna2Button2.Image")));
            this.guna2Button2.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.guna2Button2.ImageSize = new System.Drawing.Size(40, 40);
            this.guna2Button2.Location = new System.Drawing.Point(820, 424);
            this.guna2Button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(170, 48);
            this.guna2Button2.TabIndex = 48;
            this.guna2Button2.Text = "Next";
            this.guna2Button2.Click += new System.EventHandler(this.guna2Button2_Click);
            // 
            // MainTab
            // 
            this.MainTab.Controls.Add(this.tbVehicle);
            this.MainTab.Controls.Add(this.tbCustomer);
            this.MainTab.Controls.Add(this.tbBooking);
            this.MainTab.ItemSize = new System.Drawing.Size(180, 40);
            this.MainTab.Location = new System.Drawing.Point(2, 0);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1001, 526);
            this.MainTab.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.MainTab.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.MainTab.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainTab.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.MainTab.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.MainTab.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.MainTab.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MainTab.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainTab.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.MainTab.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MainTab.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.MainTab.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.MainTab.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.MainTab.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.MainTab.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.MainTab.TabButtonSize = new System.Drawing.Size(180, 40);
            this.MainTab.TabIndex = 0;
            this.MainTab.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.MainTab.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // ctrCustomerInfoWithFilter2
            // 
            this.ctrCustomerInfoWithFilter2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.ctrCustomerInfoWithFilter2.Location = new System.Drawing.Point(31, 6);
            this.ctrCustomerInfoWithFilter2.Name = "ctrCustomerInfoWithFilter2";
            this.ctrCustomerInfoWithFilter2.Size = new System.Drawing.Size(937, 411);
            this.ctrCustomerInfoWithFilter2.TabIndex = 51;
            this.ctrCustomerInfoWithFilter2.CustomerInfo += new System.EventHandler<CarRental_3_.ctrCustomerInfoWithFilter.clsCustomerInfoFoundArgs>(this.ctrCustomerInfoWithFilter2_CustomerInfo);
            // 
            // frmAddNewEditBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.ClientSize = new System.Drawing.Size(1005, 527);
            this.Controls.Add(this.MainTab);
            this.Name = "frmAddNewEditBooking";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddNewEditBooking";
            this.Load += new System.EventHandler(this.frmAddNewEditBooking_Load);
            this.Shown += new System.EventHandler(this.frmAddNewEditBooking_Shown);
            this.tbBooking.ResumeLayout(false);
            this.tbBooking.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            this.tbCustomer.ResumeLayout(false);
            this.tbVehicle.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.MainTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tbBooking;
        private Guna.UI2.WinForms.Guna2Button guna2Button4;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtEnd;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtStart;
        private System.Windows.Forms.Label lblRentalPrice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblrentalDays;
        private System.Windows.Forms.Label lblBookingID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtDropOffLocation;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox10;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox9;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox6;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox5;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPickUpLocation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.TabPage tbCustomer;
        private Guna.UI2.WinForms.Guna2Button guna2Button3;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private ctrCustomerInfoWithFilter ctrCustomerInfoWithFilter1;
        private System.Windows.Forms.TabPage tbVehicle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2TabControl MainTab;
        private System.Windows.Forms.TextBox txtNote;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox16;
        private System.Windows.Forms.LinkLabel llTrancationDeteils;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private ctrCustomerInfoWithFilter ctrCustomerInfoWithFilter2;
    }
}