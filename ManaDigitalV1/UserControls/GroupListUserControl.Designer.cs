﻿
namespace ManaDigitalV1.UserControls
{
    partial class GroupListUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GroupListUserControl));
            this.ExitGroupListbutton1 = new System.Windows.Forms.Button();
            this.FlashLogopanel2 = new System.Windows.Forms.Panel();
            this.GroupMemberslistBox2 = new System.Windows.Forms.ListBox();
            this.GroupslistBox1 = new System.Windows.Forms.ListBox();
            this.GroupMemberslabel2 = new System.Windows.Forms.Label();
            this.Groupslabel1 = new System.Windows.Forms.Label();
            this.RightPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Toppanel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ExitGroupListbutton1
            // 
            this.ExitGroupListbutton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitGroupListbutton1.BackgroundImage")));
            this.ExitGroupListbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ExitGroupListbutton1.FlatAppearance.BorderSize = 0;
            this.ExitGroupListbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitGroupListbutton1.Location = new System.Drawing.Point(65, 530);
            this.ExitGroupListbutton1.Name = "ExitGroupListbutton1";
            this.ExitGroupListbutton1.Size = new System.Drawing.Size(29, 29);
            this.ExitGroupListbutton1.TabIndex = 20;
            this.ExitGroupListbutton1.UseVisualStyleBackColor = true;
            // 
            // FlashLogopanel2
            // 
            this.FlashLogopanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FlashLogopanel2.BackgroundImage")));
            this.FlashLogopanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.FlashLogopanel2.Location = new System.Drawing.Point(410, 125);
            this.FlashLogopanel2.Name = "FlashLogopanel2";
            this.FlashLogopanel2.Size = new System.Drawing.Size(262, 292);
            this.FlashLogopanel2.TabIndex = 19;
            // 
            // GroupMemberslistBox2
            // 
            this.GroupMemberslistBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GroupMemberslistBox2.DisplayMember = "fullName";
            this.GroupMemberslistBox2.ForeColor = System.Drawing.Color.Silver;
            this.GroupMemberslistBox2.FormattingEnabled = true;
            this.GroupMemberslistBox2.ItemHeight = 16;
            this.GroupMemberslistBox2.Location = new System.Drawing.Point(208, 125);
            this.GroupMemberslistBox2.Name = "GroupMemberslistBox2";
            this.GroupMemberslistBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupMemberslistBox2.Size = new System.Drawing.Size(196, 292);
            this.GroupMemberslistBox2.TabIndex = 18;
            this.GroupMemberslistBox2.ValueMember = "Id";
            // 
            // GroupslistBox1
            // 
            this.GroupslistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.GroupslistBox1.DisplayMember = "groupName";
            this.GroupslistBox1.ForeColor = System.Drawing.Color.Silver;
            this.GroupslistBox1.FormattingEnabled = true;
            this.GroupslistBox1.ItemHeight = 16;
            this.GroupslistBox1.Location = new System.Drawing.Point(678, 125);
            this.GroupslistBox1.Name = "GroupslistBox1";
            this.GroupslistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupslistBox1.Size = new System.Drawing.Size(196, 292);
            this.GroupslistBox1.TabIndex = 17;
            this.GroupslistBox1.ValueMember = "Id";
            // 
            // GroupMemberslabel2
            // 
            this.GroupMemberslabel2.AutoSize = true;
            this.GroupMemberslabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupMemberslabel2.ForeColor = System.Drawing.Color.Silver;
            this.GroupMemberslabel2.Location = new System.Drawing.Point(340, 72);
            this.GroupMemberslabel2.Name = "GroupMemberslabel2";
            this.GroupMemberslabel2.Size = new System.Drawing.Size(71, 17);
            this.GroupMemberslabel2.TabIndex = 16;
            this.GroupMemberslabel2.Text = "اعضاء گروه ";
            // 
            // Groupslabel1
            // 
            this.Groupslabel1.AutoSize = true;
            this.Groupslabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Groupslabel1.ForeColor = System.Drawing.Color.Silver;
            this.Groupslabel1.Location = new System.Drawing.Point(830, 74);
            this.Groupslabel1.Name = "Groupslabel1";
            this.Groupslabel1.Size = new System.Drawing.Size(44, 17);
            this.Groupslabel1.TabIndex = 15;
            this.Groupslabel1.Text = "گروه ها";
            // 
            // RightPanel1
            // 
            this.RightPanel1.Location = new System.Drawing.Point(877, 70);
            this.RightPanel1.Name = "RightPanel1";
            this.RightPanel1.Size = new System.Drawing.Size(70, 560);
            this.RightPanel1.TabIndex = 22;
            // 
            // Toppanel1
            // 
            this.Toppanel1.Location = new System.Drawing.Point(0, 0);
            this.Toppanel1.Name = "Toppanel1";
            this.Toppanel1.Size = new System.Drawing.Size(947, 70);
            this.Toppanel1.TabIndex = 21;
            // 
            // GroupListUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.RightPanel1);
            this.Controls.Add(this.Toppanel1);
            this.Controls.Add(this.ExitGroupListbutton1);
            this.Controls.Add(this.FlashLogopanel2);
            this.Controls.Add(this.GroupMemberslistBox2);
            this.Controls.Add(this.GroupslistBox1);
            this.Controls.Add(this.GroupMemberslabel2);
            this.Controls.Add(this.Groupslabel1);
            this.Name = "GroupListUserControl";
            this.Size = new System.Drawing.Size(947, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ExitGroupListbutton1;
        private System.Windows.Forms.Panel FlashLogopanel2;
        private System.Windows.Forms.ListBox GroupMemberslistBox2;
        private System.Windows.Forms.ListBox GroupslistBox1;
        private System.Windows.Forms.Label GroupMemberslabel2;
        private System.Windows.Forms.Label Groupslabel1;
        private System.Windows.Forms.FlowLayoutPanel RightPanel1;
        private System.Windows.Forms.Panel Toppanel1;
    }
}