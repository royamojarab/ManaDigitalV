
namespace ManaDigitalV1
{
    partial class DashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            this.DLeftpanel = new System.Windows.Forms.Panel();
            this.Groupsbutton = new System.Windows.Forms.Button();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.DLogopanel = new System.Windows.Forms.Panel();
            this.Userpanel = new System.Windows.Forms.Panel();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.Slidepanel1 = new System.Windows.Forms.Panel();
            this.DLeftpanel.SuspendLayout();
            this.DLogopanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DLeftpanel
            // 
            this.DLeftpanel.Controls.Add(this.Groupsbutton);
            this.DLeftpanel.Controls.Add(this.Searchbutton);
            this.DLeftpanel.Controls.Add(this.DLogopanel);
            this.DLeftpanel.Controls.Add(this.Registerbutton);
            this.DLeftpanel.Location = new System.Drawing.Point(0, 0);
            this.DLeftpanel.Name = "DLeftpanel";
            this.DLeftpanel.Size = new System.Drawing.Size(240, 630);
            this.DLeftpanel.TabIndex = 0;
            // 
            // Groupsbutton
            // 
            this.Groupsbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Groupsbutton.BackgroundImage")));
            this.Groupsbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Groupsbutton.FlatAppearance.BorderSize = 0;
            this.Groupsbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Groupsbutton.Location = new System.Drawing.Point(3, 409);
            this.Groupsbutton.Name = "Groupsbutton";
            this.Groupsbutton.Size = new System.Drawing.Size(240, 54);
            this.Groupsbutton.TabIndex = 2;
            this.Groupsbutton.Text = "گروه ها";
            this.Groupsbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Groupsbutton.UseVisualStyleBackColor = true;
            this.Groupsbutton.Click += new System.EventHandler(this.Groupsbutton_Click);
            // 
            // Searchbutton
            // 
            this.Searchbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Searchbutton.BackgroundImage")));
            this.Searchbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Searchbutton.FlatAppearance.BorderSize = 0;
            this.Searchbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Searchbutton.Location = new System.Drawing.Point(3, 306);
            this.Searchbutton.Name = "Searchbutton";
            this.Searchbutton.Size = new System.Drawing.Size(240, 54);
            this.Searchbutton.TabIndex = 1;
            this.Searchbutton.Text = "جستجو کاربر";
            this.Searchbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Searchbutton.UseVisualStyleBackColor = true;
            this.Searchbutton.Click += new System.EventHandler(this.Searchbutton_Click);
            // 
            // DLogopanel
            // 
            this.DLogopanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DLogopanel.BackgroundImage")));
            this.DLogopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DLogopanel.Controls.Add(this.Userpanel);
            this.DLogopanel.Location = new System.Drawing.Point(0, 0);
            this.DLogopanel.Name = "DLogopanel";
            this.DLogopanel.Size = new System.Drawing.Size(240, 156);
            this.DLogopanel.TabIndex = 0;
            // 
            // Userpanel
            // 
            this.Userpanel.Location = new System.Drawing.Point(246, 0);
            this.Userpanel.Name = "Userpanel";
            this.Userpanel.Size = new System.Drawing.Size(947, 630);
            this.Userpanel.TabIndex = 1;
            // 
            // Registerbutton
            // 
            this.Registerbutton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Registerbutton.BackgroundImage")));
            this.Registerbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Registerbutton.FlatAppearance.BorderSize = 0;
            this.Registerbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Registerbutton.Location = new System.Drawing.Point(0, 203);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(240, 54);
            this.Registerbutton.TabIndex = 0;
            this.Registerbutton.Text = "ثبت کاربر";
            this.Registerbutton.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // Slidepanel1
            // 
            this.Slidepanel1.BackColor = System.Drawing.Color.Yellow;
            this.Slidepanel1.Location = new System.Drawing.Point(246, 203);
            this.Slidepanel1.Name = "Slidepanel1";
            this.Slidepanel1.Size = new System.Drawing.Size(10, 62);
            this.Slidepanel1.TabIndex = 1;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1192, 630);
            this.Controls.Add(this.Slidepanel1);
            this.Controls.Add(this.DLeftpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.DLeftpanel.ResumeLayout(false);
            this.DLogopanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel DLeftpanel;
        private System.Windows.Forms.Button Groupsbutton;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Panel DLogopanel;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Panel Userpanel;
        private System.Windows.Forms.Panel Slidepanel1;
    }
}