
namespace ManaDigitalV1
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.Leftpanel = new System.Windows.Forms.Panel();
            this.Lgopanel = new System.Windows.Forms.Panel();
            this.Userlabel = new System.Windows.Forms.Label();
            this.Passlabel = new System.Windows.Forms.Label();
            this.UserbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PassbunifuMaterialTextbox2 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Leftpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Leftpanel
            // 
            this.Leftpanel.Controls.Add(this.Lgopanel);
            this.Leftpanel.Location = new System.Drawing.Point(0, 0);
            this.Leftpanel.Name = "Leftpanel";
            this.Leftpanel.Size = new System.Drawing.Size(243, 608);
            this.Leftpanel.TabIndex = 0;
            // 
            // Lgopanel
            // 
            this.Lgopanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Lgopanel.BackgroundImage")));
            this.Lgopanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Lgopanel.Location = new System.Drawing.Point(0, 0);
            this.Lgopanel.Name = "Lgopanel";
            this.Lgopanel.Size = new System.Drawing.Size(240, 549);
            this.Lgopanel.TabIndex = 0;
            // 
            // Userlabel
            // 
            this.Userlabel.AutoSize = true;
            this.Userlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Userlabel.ForeColor = System.Drawing.Color.Silver;
            this.Userlabel.Location = new System.Drawing.Point(938, 102);
            this.Userlabel.Name = "Userlabel";
            this.Userlabel.Size = new System.Drawing.Size(63, 18);
            this.Userlabel.TabIndex = 1;
            this.Userlabel.Text = "نام کاربری";
            // 
            // Passlabel
            // 
            this.Passlabel.AutoSize = true;
            this.Passlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Passlabel.ForeColor = System.Drawing.Color.Silver;
            this.Passlabel.Location = new System.Drawing.Point(944, 196);
            this.Passlabel.Name = "Passlabel";
            this.Passlabel.Size = new System.Drawing.Size(57, 18);
            this.Passlabel.TabIndex = 2;
            this.Passlabel.Text = "رمز عبور";
            // 
            // UserbunifuMaterialTextbox1
            // 
            this.UserbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UserbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UserbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UserbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserbunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.HintText = "";
            this.UserbunifuMaterialTextbox1.isPassword = false;
            this.UserbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.UserbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.UserbunifuMaterialTextbox1.LineThickness = 3;
            this.UserbunifuMaterialTextbox1.Location = new System.Drawing.Point(728, 124);
            this.UserbunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(4);
            this.UserbunifuMaterialTextbox1.MaxLength = 32767;
            this.UserbunifuMaterialTextbox1.Name = "UserbunifuMaterialTextbox1";
            this.UserbunifuMaterialTextbox1.Size = new System.Drawing.Size(226, 33);
            this.UserbunifuMaterialTextbox1.TabIndex = 3;
            this.UserbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PassbunifuMaterialTextbox2
            // 
            this.PassbunifuMaterialTextbox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PassbunifuMaterialTextbox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PassbunifuMaterialTextbox2.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PassbunifuMaterialTextbox2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassbunifuMaterialTextbox2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassbunifuMaterialTextbox2.ForeColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.HintForeColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.HintText = "";
            this.PassbunifuMaterialTextbox2.isPassword = false;
            this.PassbunifuMaterialTextbox2.LineFocusedColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.LineIdleColor = System.Drawing.Color.Gray;
            this.PassbunifuMaterialTextbox2.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.PassbunifuMaterialTextbox2.LineThickness = 3;
            this.PassbunifuMaterialTextbox2.Location = new System.Drawing.Point(728, 236);
            this.PassbunifuMaterialTextbox2.Margin = new System.Windows.Forms.Padding(4);
            this.PassbunifuMaterialTextbox2.MaxLength = 32767;
            this.PassbunifuMaterialTextbox2.Name = "PassbunifuMaterialTextbox2";
            this.PassbunifuMaterialTextbox2.Size = new System.Drawing.Size(226, 33);
            this.PassbunifuMaterialTextbox2.TabIndex = 4;
            this.PassbunifuMaterialTextbox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Loginbutton
            // 
            this.Loginbutton.BackColor = System.Drawing.Color.Silver;
            this.Loginbutton.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Loginbutton.FlatAppearance.BorderSize = 0;
            this.Loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Loginbutton.Location = new System.Drawing.Point(292, 503);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(170, 46);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "ورود";
            this.Loginbutton.UseVisualStyleBackColor = false;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1078, 607);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PassbunifuMaterialTextbox2);
            this.Controls.Add(this.UserbunifuMaterialTextbox1);
            this.Controls.Add(this.Passlabel);
            this.Controls.Add(this.Userlabel);
            this.Controls.Add(this.Leftpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.Leftpanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Leftpanel;
        private System.Windows.Forms.Panel Lgopanel;
        private System.Windows.Forms.Label Userlabel;
        private System.Windows.Forms.Label Passlabel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserbunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassbunifuMaterialTextbox2;
        private System.Windows.Forms.Button Loginbutton;
    }
}

