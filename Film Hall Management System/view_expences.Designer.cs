namespace Film_Hall_Management_System
{
    partial class viewexpences
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewexpences));
            this.txtinvoice = new Guna.UI2.WinForms.Guna2TextBox();
            this.nic = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear = new Guna.UI2.WinForms.Guna2GradientButton();
            this.view = new Guna.UI2.WinForms.Guna2GradientButton();
            this.datatable1 = new System.Windows.Forms.DataGridView();
            this.print = new Guna.UI2.WinForms.Guna2GradientButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtinvoice
            // 
            this.txtinvoice.BackColor = System.Drawing.Color.Transparent;
            this.txtinvoice.BorderColor = System.Drawing.Color.Black;
            this.txtinvoice.BorderRadius = 16;
            this.txtinvoice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtinvoice.DefaultText = "";
            this.txtinvoice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtinvoice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtinvoice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtinvoice.DisabledState.Parent = this.txtinvoice;
            this.txtinvoice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtinvoice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtinvoice.FocusedState.Parent = this.txtinvoice;
            this.txtinvoice.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtinvoice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtinvoice.HoverState.Parent = this.txtinvoice;
            this.txtinvoice.Location = new System.Drawing.Point(203, 139);
            this.txtinvoice.Name = "txtinvoice";
            this.txtinvoice.PasswordChar = '\0';
            this.txtinvoice.PlaceholderText = "";
            this.txtinvoice.SelectedText = "";
            this.txtinvoice.ShadowDecoration.Parent = this.txtinvoice;
            this.txtinvoice.Size = new System.Drawing.Size(539, 47);
            this.txtinvoice.TabIndex = 34;
            // 
            // nic
            // 
            this.nic.AutoSize = true;
            this.nic.BackColor = System.Drawing.Color.Transparent;
            this.nic.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold);
            this.nic.Location = new System.Drawing.Point(29, 145);
            this.nic.Name = "nic";
            this.nic.Size = new System.Drawing.Size(158, 38);
            this.nic.TabIndex = 33;
            this.nic.Text = "Invoice No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(398, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 51);
            this.label2.TabIndex = 32;
            this.label2.Text = "View Expences";
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
            this.clear.Location = new System.Drawing.Point(943, 132);
            this.clear.Name = "clear";
            this.clear.ShadowDecoration.Parent = this.clear;
            this.clear.Size = new System.Drawing.Size(148, 57);
            this.clear.TabIndex = 39;
            this.clear.Text = "Clear";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.Color.Transparent;
            this.view.BorderRadius = 10;
            this.view.BorderThickness = 1;
            this.view.CheckedState.Parent = this.view;
            this.view.Cursor = System.Windows.Forms.Cursors.Hand;
            this.view.CustomBorderColor = System.Drawing.Color.Black;
            this.view.CustomImages.Parent = this.view;
            this.view.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.view.ForeColor = System.Drawing.Color.White;
            this.view.HoverState.Parent = this.view;
            this.view.Location = new System.Drawing.Point(767, 132);
            this.view.Name = "view";
            this.view.ShadowDecoration.Parent = this.view;
            this.view.Size = new System.Drawing.Size(148, 57);
            this.view.TabIndex = 38;
            this.view.Text = "View";
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // datatable1
            // 
            this.datatable1.AllowUserToAddRows = false;
            this.datatable1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.datatable1.BackgroundColor = System.Drawing.Color.White;
            this.datatable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable1.Location = new System.Drawing.Point(102, 219);
            this.datatable1.Name = "datatable1";
            this.datatable1.RowHeadersWidth = 51;
            this.datatable1.RowTemplate.Height = 24;
            this.datatable1.Size = new System.Drawing.Size(960, 450);
            this.datatable1.TabIndex = 40;
            // 
            // print
            // 
            this.print.BackColor = System.Drawing.Color.Transparent;
            this.print.BorderRadius = 10;
            this.print.BorderThickness = 1;
            this.print.CheckedState.Parent = this.print;
            this.print.Cursor = System.Windows.Forms.Cursors.Hand;
            this.print.CustomBorderColor = System.Drawing.Color.Black;
            this.print.CustomImages.Parent = this.print;
            this.print.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.print.ForeColor = System.Drawing.Color.White;
            this.print.HoverState.Parent = this.print;
            this.print.Location = new System.Drawing.Point(102, 675);
            this.print.Name = "print";
            this.print.ShadowDecoration.Parent = this.print;
            this.print.Size = new System.Drawing.Size(163, 57);
            this.print.TabIndex = 41;
            this.print.Text = "Print Report";
            this.print.Click += new System.EventHandler(this.print_Click);
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
            // viewexpences
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.print);
            this.Controls.Add(this.datatable1);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.view);
            this.Controls.Add(this.txtinvoice);
            this.Controls.Add(this.nic);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewexpences";
            this.Text = "Form13";
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox txtinvoice;
        private System.Windows.Forms.Label nic;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2GradientButton clear;
        private Guna.UI2.WinForms.Guna2GradientButton view;
        private System.Windows.Forms.DataGridView datatable1;
        private Guna.UI2.WinForms.Guna2GradientButton print;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}