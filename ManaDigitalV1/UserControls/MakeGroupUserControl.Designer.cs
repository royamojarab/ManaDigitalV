
namespace ManaDigitalV1.UserControls
{
    partial class MakeGroupUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeGroupUserControl));
            this.RightPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Toppanel1 = new System.Windows.Forms.Panel();
            this.SubmitGroupbutton2 = new System.Windows.Forms.Button();
            this.GroupListbutton1 = new System.Windows.Forms.Button();
            this.MemberslistBox1 = new System.Windows.Forms.ListBox();
            this.NewGroupMemberlistBox1 = new System.Windows.Forms.ListBox();
            this.Memberslabel1 = new System.Windows.Forms.Label();
            this.GroupNamebunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.GroupNamelabel2 = new System.Windows.Forms.Label();
            this.NewGroupTextlabel1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RightPanel1
            // 
            this.RightPanel1.Location = new System.Drawing.Point(877, 70);
            this.RightPanel1.Name = "RightPanel1";
            this.RightPanel1.Size = new System.Drawing.Size(70, 560);
            this.RightPanel1.TabIndex = 5;
            // 
            // Toppanel1
            // 
            this.Toppanel1.Location = new System.Drawing.Point(0, 0);
            this.Toppanel1.Name = "Toppanel1";
            this.Toppanel1.Size = new System.Drawing.Size(947, 70);
            this.Toppanel1.TabIndex = 4;
            // 
            // SubmitGroupbutton2
            // 
            this.SubmitGroupbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SubmitGroupbutton2.BackgroundImage")));
            this.SubmitGroupbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SubmitGroupbutton2.FlatAppearance.BorderSize = 0;
            this.SubmitGroupbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitGroupbutton2.Location = new System.Drawing.Point(737, 567);
            this.SubmitGroupbutton2.Name = "SubmitGroupbutton2";
            this.SubmitGroupbutton2.Size = new System.Drawing.Size(84, 31);
            this.SubmitGroupbutton2.TabIndex = 40;
            this.SubmitGroupbutton2.UseVisualStyleBackColor = true;
            // 
            // GroupListbutton1
            // 
            this.GroupListbutton1.FlatAppearance.BorderSize = 0;
            this.GroupListbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GroupListbutton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupListbutton1.ForeColor = System.Drawing.Color.Silver;
            this.GroupListbutton1.Location = new System.Drawing.Point(35, 585);
            this.GroupListbutton1.Name = "GroupListbutton1";
            this.GroupListbutton1.Size = new System.Drawing.Size(115, 32);
            this.GroupListbutton1.TabIndex = 39;
            this.GroupListbutton1.Text = "لیست گروه ها";
            this.GroupListbutton1.UseVisualStyleBackColor = true;
            // 
            // MemberslistBox1
            // 
            this.MemberslistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.MemberslistBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MemberslistBox1.DisplayMember = "fullName";
            this.MemberslistBox1.ForeColor = System.Drawing.Color.Silver;
            this.MemberslistBox1.FormattingEnabled = true;
            this.MemberslistBox1.ItemHeight = 16;
            this.MemberslistBox1.Location = new System.Drawing.Point(201, 178);
            this.MemberslistBox1.Name = "MemberslistBox1";
            this.MemberslistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MemberslistBox1.Size = new System.Drawing.Size(196, 322);
            this.MemberslistBox1.TabIndex = 38;
            this.MemberslistBox1.ValueMember = "Id";
            // 
            // NewGroupMemberlistBox1
            // 
            this.NewGroupMemberlistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.NewGroupMemberlistBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NewGroupMemberlistBox1.DisplayMember = "fullName";
            this.NewGroupMemberlistBox1.ForeColor = System.Drawing.Color.Silver;
            this.NewGroupMemberlistBox1.FormattingEnabled = true;
            this.NewGroupMemberlistBox1.ItemHeight = 16;
            this.NewGroupMemberlistBox1.Location = new System.Drawing.Point(677, 274);
            this.NewGroupMemberlistBox1.Name = "NewGroupMemberlistBox1";
            this.NewGroupMemberlistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NewGroupMemberlistBox1.Size = new System.Drawing.Size(196, 226);
            this.NewGroupMemberlistBox1.TabIndex = 37;
            this.NewGroupMemberlistBox1.ValueMember = "Id";
            // 
            // Memberslabel1
            // 
            this.Memberslabel1.AutoSize = true;
            this.Memberslabel1.ForeColor = System.Drawing.Color.Silver;
            this.Memberslabel1.Location = new System.Drawing.Point(321, 133);
            this.Memberslabel1.Name = "Memberslabel1";
            this.Memberslabel1.Size = new System.Drawing.Size(44, 17);
            this.Memberslabel1.TabIndex = 36;
            this.Memberslabel1.Text = "کاربران";
            // 
            // GroupNamebunifuMaterialTextbox1
            // 
            this.GroupNamebunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.GroupNamebunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.GroupNamebunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.GroupNamebunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.GroupNamebunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.GroupNamebunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.HintText = "";
            this.GroupNamebunifuMaterialTextbox1.isPassword = false;
            this.GroupNamebunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.GroupNamebunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.GroupNamebunifuMaterialTextbox1.LineThickness = 3;
            this.GroupNamebunifuMaterialTextbox1.Location = new System.Drawing.Point(677, 154);
            this.GroupNamebunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.GroupNamebunifuMaterialTextbox1.MaxLength = 32767;
            this.GroupNamebunifuMaterialTextbox1.Name = "GroupNamebunifuMaterialTextbox1";
            this.GroupNamebunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupNamebunifuMaterialTextbox1.Size = new System.Drawing.Size(196, 33);
            this.GroupNamebunifuMaterialTextbox1.TabIndex = 35;
            this.GroupNamebunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // GroupNamelabel2
            // 
            this.GroupNamelabel2.AutoSize = true;
            this.GroupNamelabel2.ForeColor = System.Drawing.Color.Silver;
            this.GroupNamelabel2.Location = new System.Drawing.Point(809, 133);
            this.GroupNamelabel2.Name = "GroupNamelabel2";
            this.GroupNamelabel2.Size = new System.Drawing.Size(46, 17);
            this.GroupNamelabel2.TabIndex = 33;
            this.GroupNamelabel2.Text = "نام گروه";
            // 
            // NewGroupTextlabel1
            // 
            this.NewGroupTextlabel1.AutoSize = true;
            this.NewGroupTextlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewGroupTextlabel1.ForeColor = System.Drawing.Color.Silver;
            this.NewGroupTextlabel1.Location = new System.Drawing.Point(757, 83);
            this.NewGroupTextlabel1.Name = "NewGroupTextlabel1";
            this.NewGroupTextlabel1.Size = new System.Drawing.Size(103, 20);
            this.NewGroupTextlabel1.TabIndex = 34;
            this.NewGroupTextlabel1.Text = ":ایجاد گروه جدید";
            // 
            // MakeGroupUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.SubmitGroupbutton2);
            this.Controls.Add(this.GroupListbutton1);
            this.Controls.Add(this.MemberslistBox1);
            this.Controls.Add(this.NewGroupMemberlistBox1);
            this.Controls.Add(this.Memberslabel1);
            this.Controls.Add(this.GroupNamebunifuMaterialTextbox1);
            this.Controls.Add(this.GroupNamelabel2);
            this.Controls.Add(this.NewGroupTextlabel1);
            this.Controls.Add(this.RightPanel1);
            this.Controls.Add(this.Toppanel1);
            this.Name = "MakeGroupUserControl";
            this.Size = new System.Drawing.Size(947, 630);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel RightPanel1;
        private System.Windows.Forms.Panel Toppanel1;
        private System.Windows.Forms.Button SubmitGroupbutton2;
        private System.Windows.Forms.Button GroupListbutton1;
        private System.Windows.Forms.ListBox MemberslistBox1;
        private System.Windows.Forms.ListBox NewGroupMemberlistBox1;
        private System.Windows.Forms.Label Memberslabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox GroupNamebunifuMaterialTextbox1;
        private System.Windows.Forms.Label GroupNamelabel2;
        private System.Windows.Forms.Label NewGroupTextlabel1;
    }
}
