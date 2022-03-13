namespace Film_Hall_Management_System
{
    partial class issueticket
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(issueticket));
            this.issue = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtticketnum = new Guna.UI2.WinForms.Guna2TextBox();
            this.ticketgenerate = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2GradientButton1 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtgenerate = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2GradientButton2 = new Guna.UI2.WinForms.Guna2GradientButton();
            this.txtbox = new Guna.UI2.WinForms.Guna2RadioButton();
            this.txtnormal = new Guna.UI2.WinForms.Guna2RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdate = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.datatable1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).BeginInit();
            this.SuspendLayout();
            // 
            // issue
            // 
            this.issue.BackColor = System.Drawing.Color.Transparent;
            this.issue.BorderRadius = 10;
            this.issue.BorderThickness = 1;
            this.issue.CheckedState.Parent = this.issue;
            this.issue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.issue.CustomBorderColor = System.Drawing.Color.Black;
            this.issue.CustomImages.Parent = this.issue;
            this.issue.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.issue.ForeColor = System.Drawing.Color.White;
            this.issue.HoverState.Parent = this.issue;
            this.issue.Location = new System.Drawing.Point(341, 578);
            this.issue.Name = "issue";
            this.issue.ShadowDecoration.Parent = this.issue;
            this.issue.Size = new System.Drawing.Size(148, 57);
            this.issue.TabIndex = 34;
            this.issue.Text = "Issue";
            this.issue.Click += new System.EventHandler(this.issue_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(445, 22);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 51);
            this.label6.TabIndex = 33;
            this.label6.Text = "Issue Ticket";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 38);
            this.label1.TabIndex = 32;
            this.label1.Text = "Ticket Number";
            // 
            // txtticketnum
            // 
            this.txtticketnum.BackColor = System.Drawing.Color.Transparent;
            this.txtticketnum.BorderRadius = 10;
            this.txtticketnum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtticketnum.DefaultText = "";
            this.txtticketnum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtticketnum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtticketnum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtticketnum.DisabledState.Parent = this.txtticketnum;
            this.txtticketnum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtticketnum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtticketnum.FocusedState.Parent = this.txtticketnum;
            this.txtticketnum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtticketnum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtticketnum.HoverState.Parent = this.txtticketnum;
            this.txtticketnum.Location = new System.Drawing.Point(350, 258);
            this.txtticketnum.Name = "txtticketnum";
            this.txtticketnum.PasswordChar = '\0';
            this.txtticketnum.PlaceholderText = "";
            this.txtticketnum.SelectedText = "";
            this.txtticketnum.ShadowDecoration.Parent = this.txtticketnum;
            this.txtticketnum.Size = new System.Drawing.Size(330, 45);
            this.txtticketnum.TabIndex = 31;
            // 
            // ticketgenerate
            // 
            this.ticketgenerate.BackColor = System.Drawing.Color.Transparent;
            this.ticketgenerate.BorderRadius = 10;
            this.ticketgenerate.BorderThickness = 1;
            this.ticketgenerate.CheckedState.Parent = this.ticketgenerate;
            this.ticketgenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ticketgenerate.CustomBorderColor = System.Drawing.Color.Black;
            this.ticketgenerate.CustomImages.Parent = this.ticketgenerate;
            this.ticketgenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketgenerate.ForeColor = System.Drawing.Color.White;
            this.ticketgenerate.HoverState.Parent = this.ticketgenerate;
            this.ticketgenerate.Location = new System.Drawing.Point(350, 179);
            this.ticketgenerate.Name = "ticketgenerate";
            this.ticketgenerate.ShadowDecoration.Parent = this.ticketgenerate;
            this.ticketgenerate.Size = new System.Drawing.Size(298, 57);
            this.ticketgenerate.TabIndex = 36;
            this.ticketgenerate.Text = "View Ticket Numbers";
            this.ticketgenerate.Click += new System.EventHandler(this.ticketgenerate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(47, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 38);
            this.label2.TabIndex = 37;
            this.label2.Text = "Ticket Type";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(45, 572);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 151);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // guna2GradientButton1
            // 
            this.guna2GradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton1.BorderRadius = 10;
            this.guna2GradientButton1.BorderThickness = 1;
            this.guna2GradientButton1.CheckedState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton1.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GradientButton1.CustomImages.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton1.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton1.HoverState.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Location = new System.Drawing.Point(341, 666);
            this.guna2GradientButton1.Name = "guna2GradientButton1";
            this.guna2GradientButton1.ShadowDecoration.Parent = this.guna2GradientButton1;
            this.guna2GradientButton1.Size = new System.Drawing.Size(148, 57);
            this.guna2GradientButton1.TabIndex = 40;
            this.guna2GradientButton1.Text = "Print";
            this.guna2GradientButton1.Click += new System.EventHandler(this.guna2GradientButton1_Click);
            // 
            // txtgenerate
            // 
            this.txtgenerate.BackColor = System.Drawing.Color.Transparent;
            this.txtgenerate.BorderRadius = 10;
            this.txtgenerate.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtgenerate.DefaultText = "";
            this.txtgenerate.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtgenerate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtgenerate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgenerate.DisabledState.Parent = this.txtgenerate;
            this.txtgenerate.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtgenerate.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgenerate.FocusedState.Parent = this.txtgenerate;
            this.txtgenerate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtgenerate.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtgenerate.HoverState.Parent = this.txtgenerate;
            this.txtgenerate.Location = new System.Drawing.Point(45, 507);
            this.txtgenerate.Name = "txtgenerate";
            this.txtgenerate.PasswordChar = '\0';
            this.txtgenerate.PlaceholderText = "";
            this.txtgenerate.SelectedText = "";
            this.txtgenerate.ShadowDecoration.Parent = this.txtgenerate;
            this.txtgenerate.Size = new System.Drawing.Size(626, 45);
            this.txtgenerate.TabIndex = 41;
            // 
            // guna2GradientButton2
            // 
            this.guna2GradientButton2.BackColor = System.Drawing.Color.Transparent;
            this.guna2GradientButton2.BorderRadius = 10;
            this.guna2GradientButton2.BorderThickness = 1;
            this.guna2GradientButton2.CheckedState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2GradientButton2.CustomBorderColor = System.Drawing.Color.Black;
            this.guna2GradientButton2.CustomImages.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2GradientButton2.ForeColor = System.Drawing.Color.White;
            this.guna2GradientButton2.HoverState.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Location = new System.Drawing.Point(355, 435);
            this.guna2GradientButton2.Name = "guna2GradientButton2";
            this.guna2GradientButton2.ShadowDecoration.Parent = this.guna2GradientButton2;
            this.guna2GradientButton2.Size = new System.Drawing.Size(245, 57);
            this.guna2GradientButton2.TabIndex = 42;
            this.guna2GradientButton2.Text = "Generate Information";
            this.guna2GradientButton2.Click += new System.EventHandler(this.guna2GradientButton2_Click);
            // 
            // txtbox
            // 
            this.txtbox.AutoSize = true;
            this.txtbox.BackColor = System.Drawing.Color.Transparent;
            this.txtbox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox.CheckedState.BorderThickness = 0;
            this.txtbox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtbox.CheckedState.InnerColor = System.Drawing.Color.White;
            this.txtbox.CheckedState.InnerOffset = -4;
            this.txtbox.FlatAppearance.BorderSize = 0;
            this.txtbox.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox.ForeColor = System.Drawing.Color.Black;
            this.txtbox.Location = new System.Drawing.Point(557, 84);
            this.txtbox.Name = "txtbox";
            this.txtbox.Size = new System.Drawing.Size(108, 48);
            this.txtbox.TabIndex = 48;
            this.txtbox.Text = "Box";
            this.txtbox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtbox.UncheckedState.BorderThickness = 2;
            this.txtbox.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.txtbox.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.txtbox.UseVisualStyleBackColor = false;
            // 
            // txtnormal
            // 
            this.txtnormal.AutoSize = true;
            this.txtnormal.BackColor = System.Drawing.Color.Transparent;
            this.txtnormal.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnormal.CheckedState.BorderThickness = 0;
            this.txtnormal.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtnormal.CheckedState.InnerColor = System.Drawing.Color.White;
            this.txtnormal.CheckedState.InnerOffset = -4;
            this.txtnormal.FlatAppearance.BorderSize = 0;
            this.txtnormal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.txtnormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnormal.ForeColor = System.Drawing.Color.Black;
            this.txtnormal.Location = new System.Drawing.Point(355, 74);
            this.txtnormal.Name = "txtnormal";
            this.txtnormal.Size = new System.Drawing.Size(170, 48);
            this.txtnormal.TabIndex = 45;
            this.txtnormal.Text = "Normal";
            this.txtnormal.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txtnormal.UncheckedState.BorderThickness = 2;
            this.txtnormal.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.txtnormal.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.txtnormal.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(47, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 38);
            this.label3.TabIndex = 49;
            this.label3.Text = "Date";
            // 
            // txtdate
            // 
            this.txtdate.CheckedState.Parent = this.txtdate;
            this.txtdate.FillColor = System.Drawing.Color.White;
            this.txtdate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtdate.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.txtdate.HoverState.Parent = this.txtdate;
            this.txtdate.Location = new System.Drawing.Point(349, 348);
            this.txtdate.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.txtdate.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.txtdate.Name = "txtdate";
            this.txtdate.ShadowDecoration.Parent = this.txtdate;
            this.txtdate.Size = new System.Drawing.Size(331, 48);
            this.txtdate.TabIndex = 50;
            this.txtdate.Value = new System.DateTime(2021, 4, 4, 12, 26, 41, 667);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(931, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 51;
            this.pictureBox2.TabStop = false;
            // 
            // datatable1
            // 
            this.datatable1.BackgroundColor = System.Drawing.Color.White;
            this.datatable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable1.Location = new System.Drawing.Point(749, 179);
            this.datatable1.Name = "datatable1";
            this.datatable1.RowHeadersWidth = 51;
            this.datatable1.RowTemplate.Height = 24;
            this.datatable1.Size = new System.Drawing.Size(367, 521);
            this.datatable1.TabIndex = 44;
            this.datatable1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatable1_CellContentClick);
            this.datatable1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatable1_CellContentDoubleClick);
            this.datatable1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatable1_CellDoubleClick);
            // 
            // issueticket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 766);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txtdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox);
            this.Controls.Add(this.txtnormal);
            this.Controls.Add(this.datatable1);
            this.Controls.Add(this.guna2GradientButton2);
            this.Controls.Add(this.txtgenerate);
            this.Controls.Add(this.guna2GradientButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ticketgenerate);
            this.Controls.Add(this.issue);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtticketnum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "issueticket";
            this.Text = "Form15";
            this.Load += new System.EventHandler(this.issueticket_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2GradientButton issue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtticketnum;
        private Guna.UI2.WinForms.Guna2GradientButton ticketgenerate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton1;
        private Guna.UI2.WinForms.Guna2TextBox txtgenerate;
        private Guna.UI2.WinForms.Guna2GradientButton guna2GradientButton2;
        private Guna.UI2.WinForms.Guna2RadioButton txtbox;
        private Guna.UI2.WinForms.Guna2RadioButton txtnormal;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2DateTimePicker txtdate;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView datatable1;
    }
}