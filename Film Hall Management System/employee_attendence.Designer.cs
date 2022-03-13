namespace Film_Hall_Management_System
{
    partial class employee_attendence
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(employee_attendence));
            this.txtworktime = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.txtarrival = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtnic = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.clear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.add = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtworktime
            // 
            this.txtworktime.BackColor = System.Drawing.Color.Transparent;
            this.txtworktime.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtworktime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtworktime.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtworktime.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtworktime.FocusedState.Parent = this.txtworktime;
            this.txtworktime.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtworktime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtworktime.HoverState.Parent = this.txtworktime;
            this.txtworktime.ItemHeight = 30;
            this.txtworktime.Items.AddRange(new object[] {
            "Full Day",
            "Half Day"});
            this.txtworktime.ItemsAppearance.Parent = this.txtworktime;
            this.txtworktime.Location = new System.Drawing.Point(425, 359);
            this.txtworktime.Name = "txtworktime";
            this.txtworktime.ShadowDecoration.Parent = this.txtworktime;
            this.txtworktime.Size = new System.Drawing.Size(539, 36);
            this.txtworktime.TabIndex = 32;
            // 
            // txtdate
            // 
            this.txtdate.BackColor = System.Drawing.Color.Transparent;
            this.txtdate.BorderRadius = 10;
            this.txtdate.CheckedState.Parent = this.txtdate;
            this.txtdate.FillColor = System.Drawing.Color.White;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdate.HoverState.Parent = this.txtdate;
            this.txtdate.Location = new System.Drawing.Point(425, 196);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.ShadowDecoration.Parent = this.txtdate;
            this.txtdate.Size = new System.Drawing.Size(539, 47);
            this.txtdate.TabIndex = 31;
            this.txtdate.Value = new System.DateTime(2020, 11, 1, 0, 0, 0, 0);
            // 
            // txtarrival
            // 
            this.txtarrival.BackColor = System.Drawing.Color.Transparent;
            this.txtarrival.BorderRadius = 15;
            this.txtarrival.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtarrival.DefaultText = "";
            this.txtarrival.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtarrival.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtarrival.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtarrival.DisabledState.Parent = this.txtarrival;
            this.txtarrival.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtarrival.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtarrival.FocusedState.Parent = this.txtarrival;
            this.txtarrival.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtarrival.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtarrival.HoverState.Parent = this.txtarrival;
            this.txtarrival.Location = new System.Drawing.Point(425, 275);
            this.txtarrival.Name = "txtarrival";
            this.txtarrival.PasswordChar = '\0';
            this.txtarrival.PlaceholderText = "";
            this.txtarrival.SelectedText = "";
            this.txtarrival.ShadowDecoration.Parent = this.txtarrival;
            this.txtarrival.Size = new System.Drawing.Size(539, 47);
            this.txtarrival.TabIndex = 30;
            // 
            // txtnic
            // 
            this.txtnic.BackColor = System.Drawing.Color.Transparent;
            this.txtnic.BorderRadius = 15;
            this.txtnic.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtnic.DefaultText = "";
            this.txtnic.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtnic.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtnic.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnic.DisabledState.Parent = this.txtnic;
            this.txtnic.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtnic.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnic.FocusedState.Parent = this.txtnic;
            this.txtnic.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtnic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnic.HoverState.Parent = this.txtnic;
            this.txtnic.Location = new System.Drawing.Point(425, 119);
            this.txtnic.Name = "txtnic";
            this.txtnic.PasswordChar = '\0';
            this.txtnic.PlaceholderText = "";
            this.txtnic.SelectedText = "";
            this.txtnic.ShadowDecoration.Parent = this.txtnic;
            this.txtnic.Size = new System.Drawing.Size(539, 47);
            this.txtnic.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(179, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 38);
            this.label4.TabIndex = 36;
            this.label4.Text = "Work Time";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(179, 275);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 38);
            this.label3.TabIndex = 35;
            this.label3.Text = "Arrival Time";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(179, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 38);
            this.label2.TabIndex = 34;
            this.label2.Text = "Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(179, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 38);
            this.label1.TabIndex = 33;
            this.label1.Text = "NIC Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(416, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(346, 51);
            this.label5.TabIndex = 37;
            this.label5.Text = "Mark Attendence";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(67, 469);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 38;
            this.pictureBox1.TabStop = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BorderRadius = 10;
            this.clear.BorderThickness = 1;
            this.clear.CheckedState.Parent = this.clear;
            this.clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear.CustomBorderColor = System.Drawing.Color.Black;
            this.clear.CustomImages.Parent = this.clear;
            this.clear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.HoverState.Parent = this.clear;
            this.clear.Location = new System.Drawing.Point(774, 449);
            this.clear.Name = "clear";
            this.clear.ShadowDecoration.Parent = this.clear;
            this.clear.Size = new System.Drawing.Size(148, 57);
            this.clear.TabIndex = 40;
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // add
            // 
            this.add.BackColor = System.Drawing.Color.Transparent;
            this.add.BorderRadius = 10;
            this.add.BorderThickness = 1;
            this.add.CheckedState.Parent = this.add;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.CustomBorderColor = System.Drawing.Color.Black;
            this.add.CustomImages.Parent = this.add;
            this.add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.Parent = this.add;
            this.add.Location = new System.Drawing.Point(423, 449);
            this.add.Name = "add";
            this.add.ShadowDecoration.Parent = this.add;
            this.add.Size = new System.Drawing.Size(148, 57);
            this.add.TabIndex = 39;
            this.add.Text = "Mark";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(931, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 44;
            this.pictureBox2.TabStop = false;
            // 
            // employee_attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.add);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtworktime);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.txtarrival);
            this.Controls.Add(this.txtnic);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "employee_attendence";
            this.Text = "employee_attendence";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox txtworktime;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private Guna.UI2.WinForms.Guna2TextBox txtarrival;
        private Guna.UI2.WinForms.Guna2TextBox txtnic;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton clear;
        private Guna.UI2.WinForms.Guna2GradientButton add;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}