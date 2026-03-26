namespace CarRental_3_
{
    partial class frmBookingDetailes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBookingDetailes));
            this.btnCancle = new Guna.UI2.WinForms.Guna2Button();
            this.label20 = new System.Windows.Forms.Label();
            this.ctrBookingInfo1 = new CarRental_3_.ctrBookingInfo();
            this.SuspendLayout();
            // 
            // btnCancle
            // 
            this.btnCancle.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancle.CustomBorderThickness = new System.Windows.Forms.Padding(2);
            this.btnCancle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(35)))), ((int)(((byte)(50)))));
            this.btnCancle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancle.ForeColor = System.Drawing.Color.White;
            this.btnCancle.Image = ((System.Drawing.Image)(resources.GetObject("btnCancle.Image")));
            this.btnCancle.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnCancle.ImageSize = new System.Drawing.Size(40, 40);
            this.btnCancle.Location = new System.Drawing.Point(693, 464);
            this.btnCancle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnCancle.Name = "btnCancle";
            this.btnCancle.Size = new System.Drawing.Size(158, 43);
            this.btnCancle.TabIndex = 77;
            this.btnCancle.Text = "Close";
            this.btnCancle.Click += new System.EventHandler(this.btnCancle_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label20.Location = new System.Drawing.Point(257, 9);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(296, 39);
            this.label20.TabIndex = 103;
            this.label20.Text = "Booking Detailes ";
            // 
            // ctrBookingInfo1
            // 
            this.ctrBookingInfo1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ctrBookingInfo1.Location = new System.Drawing.Point(1, 60);
            this.ctrBookingInfo1.Name = "ctrBookingInfo1";
            this.ctrBookingInfo1.Size = new System.Drawing.Size(850, 433);
            this.ctrBookingInfo1.TabIndex = 104;
            // 
            // frmBookingDetailes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.ClientSize = new System.Drawing.Size(853, 513);
            this.Controls.Add(this.btnCancle);
            this.Controls.Add(this.ctrBookingInfo1);
            this.Controls.Add(this.label20);
            this.Name = "frmBookingDetailes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmBookingDetailes";
            this.Load += new System.EventHandler(this.frmBookingDetailes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button btnCancle;
        private System.Windows.Forms.Label label20;
        private ctrBookingInfo ctrBookingInfo1;
    }
}