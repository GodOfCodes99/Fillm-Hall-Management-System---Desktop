namespace Film_Hall_Management_System
{
    partial class contact
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(contact));
            this.view = new Guna.UI2.WinForms.Guna2GradientButton();
            this.label2 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.datatable1 = new System.Windows.Forms.DataGridView();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
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
            this.view.Location = new System.Drawing.Point(455, 115);
            this.view.Name = "view";
            this.view.ShadowDecoration.Parent = this.view;
            this.view.Size = new System.Drawing.Size(179, 57);
            this.view.TabIndex = 62;
            this.view.Text = "View";
            this.view.Click += new System.EventHandler(this.view_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 22.2F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(329, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(505, 51);
            this.label2.TabIndex = 59;
            this.label2.Text = "View Contact Us Requests";
            // 
            // datatable1
            // 
            this.datatable1.BackgroundColor = System.Drawing.Color.White;
            this.datatable1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatable1.Location = new System.Drawing.Point(129, 203);
            this.datatable1.Name = "datatable1";
            this.datatable1.RowHeadersWidth = 51;
            this.datatable1.RowTemplate.Height = 24;
            this.datatable1.Size = new System.Drawing.Size(889, 468);
            this.datatable1.TabIndex = 63;
            this.datatable1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datatable1_CellContentClick);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(931, 20);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 71);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 64;
            this.pictureBox2.TabStop = false;
            // 
            // contact
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1153, 768);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.datatable1);
            this.Controls.Add(this.view);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "contact";
            this.Text = "contact";
            this.Load += new System.EventHandler(this.contact_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datatable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton view;
        private System.Windows.Forms.Label label2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView datatable1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}