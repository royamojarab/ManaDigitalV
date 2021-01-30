
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
            this.Registerbutton = new System.Windows.Forms.Button();
            this.DLogopanel = new System.Windows.Forms.Panel();
            this.Searchbutton = new System.Windows.Forms.Button();
            this.Slidepanel1 = new System.Windows.Forms.Panel();
            this.Groupsbutton = new System.Windows.Forms.Button();
            this.DLeftpanel = new System.Windows.Forms.Panel();
            this.Userpanel = new System.Windows.Forms.Panel();
            this.searchUserControl1 = new ManaDigitalV1.UserControls.SearchUserControl();
            this.registerUserControl1 = new ManaDigitalV1.UserControls.RegisterUserControl();
            this.groupListUserControl1 = new ManaDigitalV1.UserControls.GroupListUserControl();
            this.DLeftpanel.SuspendLayout();
            this.Userpanel.SuspendLayout();
            this.SuspendLayout();
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
            // DLogopanel
            // 
            this.DLogopanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DLogopanel.BackgroundImage")));
            this.DLogopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.DLogopanel.Location = new System.Drawing.Point(0, 0);
            this.DLogopanel.Name = "DLogopanel";
            this.DLogopanel.Size = new System.Drawing.Size(240, 156);
            this.DLogopanel.TabIndex = 0;
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
            // Slidepanel1
            // 
            this.Slidepanel1.BackColor = System.Drawing.Color.Yellow;
            this.Slidepanel1.Location = new System.Drawing.Point(246, 195);
            this.Slidepanel1.Name = "Slidepanel1";
            this.Slidepanel1.Size = new System.Drawing.Size(10, 62);
            this.Slidepanel1.TabIndex = 1;
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
            // DLeftpanel
            // 
            this.DLeftpanel.Controls.Add(this.Groupsbutton);
            this.DLeftpanel.Controls.Add(this.Searchbutton);
            this.DLeftpanel.Controls.Add(this.DLogopanel);
            this.DLeftpanel.Controls.Add(this.Registerbutton);
            this.DLeftpanel.Location = new System.Drawing.Point(0, 0);
            this.DLeftpanel.Name = "DLeftpanel";
            this.DLeftpanel.Size = new System.Drawing.Size(240, 739);
            this.DLeftpanel.TabIndex = 0;
            // 
            // Userpanel
            // 
            this.Userpanel.Controls.Add(this.groupListUserControl1);
            this.Userpanel.Controls.Add(this.searchUserControl1);
            this.Userpanel.Controls.Add(this.registerUserControl1);
            this.Userpanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.Userpanel.Location = new System.Drawing.Point(278, 0);
            this.Userpanel.Name = "Userpanel";
            this.Userpanel.Size = new System.Drawing.Size(914, 740);
            this.Userpanel.TabIndex = 1;
            // 
            // searchUserControl1
            // 
            this.searchUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.searchUserControl1.Location = new System.Drawing.Point(3, 0);
            this.searchUserControl1.Name = "searchUserControl1";
            this.searchUserControl1.Size = new System.Drawing.Size(908, 736);
            this.searchUserControl1.TabIndex = 2;
            // 
            // registerUserControl1
            // 
            this.registerUserControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.registerUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.registerUserControl1.ForeColor = System.Drawing.Color.Silver;
            this.registerUserControl1.Location = new System.Drawing.Point(3, 12);
            this.registerUserControl1.Name = "registerUserControl1";
            this.registerUserControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.registerUserControl1.Size = new System.Drawing.Size(888, 716);
            this.registerUserControl1.TabIndex = 1;
            // 
            // groupListUserControl1
            // 
            this.groupListUserControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.groupListUserControl1.Location = new System.Drawing.Point(-3, 3);
            this.groupListUserControl1.Name = "groupListUserControl1";
            this.groupListUserControl1.Size = new System.Drawing.Size(914, 740);
            this.groupListUserControl1.TabIndex = 3;
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(1192, 740);
            this.Controls.Add(this.Userpanel);
            this.Controls.Add(this.Slidepanel1);
            this.Controls.Add(this.DLeftpanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Silver;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "v";
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.DLeftpanel.ResumeLayout(false);
            this.Userpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.Panel DLogopanel;
        private System.Windows.Forms.Button Searchbutton;
        private System.Windows.Forms.Panel Slidepanel1;
        private System.Windows.Forms.Button Groupsbutton;
        private System.Windows.Forms.Panel DLeftpanel;
        private System.Windows.Forms.Panel Userpanel;
        private UserControls.RegisterUserControl registerUserControl1;
        private UserControls.SearchUserControl searchUserControl1;
        private UserControls.GroupListUserControl groupListUserControl1;
    }
}