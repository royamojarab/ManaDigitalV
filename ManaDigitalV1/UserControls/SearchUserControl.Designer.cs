
namespace ManaDigitalV1.UserControls
{
    partial class SearchUserControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUserControl));
            this.Searchlabel1 = new System.Windows.Forms.Label();
            this.SearchbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SearchlistBox1 = new System.Windows.Forms.ListBox();
            this.CVbutton1 = new System.Windows.Forms.Button();
            this.SaveEditbutton2 = new System.Windows.Forms.Button();
            this.parametercomboBox1 = new System.Windows.Forms.ComboBox();
            this.AddressbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PhonebunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.RelationbunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.NamebunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.Agelabel5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Phonelabel3 = new System.Windows.Forms.Label();
            this.Addresslabel4 = new System.Windows.Forms.Label();
            this.Relationlabel2 = new System.Windows.Forms.Label();
            this.Namelabel1 = new System.Windows.Forms.Label();
            this.SaveCVbutton2 = new System.Windows.Forms.Button();
            this.ChooseCVbutton2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AgenumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.rightLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Searchlabel1
            // 
            this.Searchlabel1.AutoSize = true;
            this.Searchlabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchlabel1.ForeColor = System.Drawing.Color.Silver;
            this.Searchlabel1.Location = new System.Drawing.Point(775, 54);
            this.Searchlabel1.Name = "Searchlabel1";
            this.Searchlabel1.Size = new System.Drawing.Size(47, 20);
            this.Searchlabel1.TabIndex = 12;
            this.Searchlabel1.Text = "جستجو";
            // 
            // SearchbunifuMaterialTextbox1
            // 
            this.SearchbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SearchbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SearchbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SearchbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SearchbunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.SearchbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SearchbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.HintText = "";
            this.SearchbunifuMaterialTextbox1.isPassword = false;
            this.SearchbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.SearchbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.SearchbunifuMaterialTextbox1.LineThickness = 3;
            this.SearchbunifuMaterialTextbox1.Location = new System.Drawing.Point(603, 79);
            this.SearchbunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.SearchbunifuMaterialTextbox1.MaxLength = 32767;
            this.SearchbunifuMaterialTextbox1.Name = "SearchbunifuMaterialTextbox1";
            this.SearchbunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchbunifuMaterialTextbox1.Size = new System.Drawing.Size(196, 33);
            this.SearchbunifuMaterialTextbox1.TabIndex = 13;
            this.SearchbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SearchlistBox1
            // 
            this.SearchlistBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.SearchlistBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SearchlistBox1.DisplayMember = "fullName";
            this.SearchlistBox1.ForeColor = System.Drawing.Color.Silver;
            this.SearchlistBox1.FormattingEnabled = true;
            this.SearchlistBox1.ItemHeight = 16;
            this.SearchlistBox1.Location = new System.Drawing.Point(602, 161);
            this.SearchlistBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchlistBox1.Name = "SearchlistBox1";
            this.SearchlistBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.SearchlistBox1.Size = new System.Drawing.Size(197, 226);
            this.SearchlistBox1.TabIndex = 14;
            this.SearchlistBox1.ValueMember = "Id";
            // 
            // CVbutton1
            // 
            this.CVbutton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CVbutton1.FlatAppearance.BorderSize = 0;
            this.CVbutton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CVbutton1.ForeColor = System.Drawing.Color.Silver;
            this.CVbutton1.Location = new System.Drawing.Point(130, 519);
            this.CVbutton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CVbutton1.Name = "CVbutton1";
            this.CVbutton1.Size = new System.Drawing.Size(98, 38);
            this.CVbutton1.TabIndex = 49;
            this.CVbutton1.Text = "مشاهده رزومه";
            this.CVbutton1.UseVisualStyleBackColor = true;
            // 
            // SaveEditbutton2
            // 
            this.SaveEditbutton2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SaveEditbutton2.BackgroundImage")));
            this.SaveEditbutton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveEditbutton2.FlatAppearance.BorderSize = 0;
            this.SaveEditbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveEditbutton2.Location = new System.Drawing.Point(3, 678);
            this.SaveEditbutton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SaveEditbutton2.Name = "SaveEditbutton2";
            this.SaveEditbutton2.Size = new System.Drawing.Size(84, 31);
            this.SaveEditbutton2.TabIndex = 48;
            this.SaveEditbutton2.UseVisualStyleBackColor = true;
            // 
            // parametercomboBox1
            // 
            this.parametercomboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.parametercomboBox1.ForeColor = System.Drawing.Color.Silver;
            this.parametercomboBox1.FormattingEnabled = true;
            this.parametercomboBox1.Location = new System.Drawing.Point(297, 447);
            this.parametercomboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.parametercomboBox1.Name = "parametercomboBox1";
            this.parametercomboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.parametercomboBox1.Size = new System.Drawing.Size(121, 24);
            this.parametercomboBox1.TabIndex = 45;
            // 
            // AddressbunifuMaterialTextbox1
            // 
            this.AddressbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AddressbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AddressbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AddressbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AddressbunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.AddressbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.HintText = "";
            this.AddressbunifuMaterialTextbox1.isPassword = false;
            this.AddressbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.AddressbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.AddressbunifuMaterialTextbox1.LineThickness = 3;
            this.AddressbunifuMaterialTextbox1.Location = new System.Drawing.Point(213, 283);
            this.AddressbunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.AddressbunifuMaterialTextbox1.MaxLength = 32767;
            this.AddressbunifuMaterialTextbox1.Name = "AddressbunifuMaterialTextbox1";
            this.AddressbunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AddressbunifuMaterialTextbox1.Size = new System.Drawing.Size(205, 33);
            this.AddressbunifuMaterialTextbox1.TabIndex = 43;
            this.AddressbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // PhonebunifuMaterialTextbox1
            // 
            this.PhonebunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PhonebunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PhonebunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PhonebunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PhonebunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PhonebunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.HintText = "";
            this.PhonebunifuMaterialTextbox1.isPassword = false;
            this.PhonebunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.PhonebunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.PhonebunifuMaterialTextbox1.LineThickness = 3;
            this.PhonebunifuMaterialTextbox1.Location = new System.Drawing.Point(213, 213);
            this.PhonebunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.PhonebunifuMaterialTextbox1.MaxLength = 32767;
            this.PhonebunifuMaterialTextbox1.Name = "PhonebunifuMaterialTextbox1";
            this.PhonebunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.PhonebunifuMaterialTextbox1.Size = new System.Drawing.Size(205, 33);
            this.PhonebunifuMaterialTextbox1.TabIndex = 42;
            this.PhonebunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RelationbunifuMaterialTextbox1
            // 
            this.RelationbunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.RelationbunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.RelationbunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.RelationbunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.RelationbunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.RelationbunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.HintText = "";
            this.RelationbunifuMaterialTextbox1.isPassword = false;
            this.RelationbunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.RelationbunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.RelationbunifuMaterialTextbox1.LineThickness = 3;
            this.RelationbunifuMaterialTextbox1.Location = new System.Drawing.Point(213, 143);
            this.RelationbunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.RelationbunifuMaterialTextbox1.MaxLength = 32767;
            this.RelationbunifuMaterialTextbox1.Name = "RelationbunifuMaterialTextbox1";
            this.RelationbunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RelationbunifuMaterialTextbox1.Size = new System.Drawing.Size(205, 33);
            this.RelationbunifuMaterialTextbox1.TabIndex = 41;
            this.RelationbunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // NamebunifuMaterialTextbox1
            // 
            this.NamebunifuMaterialTextbox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.NamebunifuMaterialTextbox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.NamebunifuMaterialTextbox1.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.NamebunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.NamebunifuMaterialTextbox1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.NamebunifuMaterialTextbox1.ForeColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.HintText = "";
            this.NamebunifuMaterialTextbox1.isPassword = false;
            this.NamebunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.NamebunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Silver;
            this.NamebunifuMaterialTextbox1.LineThickness = 3;
            this.NamebunifuMaterialTextbox1.Location = new System.Drawing.Point(213, 73);
            this.NamebunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5);
            this.NamebunifuMaterialTextbox1.MaxLength = 32767;
            this.NamebunifuMaterialTextbox1.Name = "NamebunifuMaterialTextbox1";
            this.NamebunifuMaterialTextbox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NamebunifuMaterialTextbox1.Size = new System.Drawing.Size(205, 33);
            this.NamebunifuMaterialTextbox1.TabIndex = 40;
            this.NamebunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NamebunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.NamebunifuMaterialTextbox1_OnValueChanged);
            // 
            // Agelabel5
            // 
            this.Agelabel5.AutoSize = true;
            this.Agelabel5.ForeColor = System.Drawing.Color.Silver;
            this.Agelabel5.Location = new System.Drawing.Point(419, 356);
            this.Agelabel5.Name = "Agelabel5";
            this.Agelabel5.Size = new System.Drawing.Size(23, 17);
            this.Agelabel5.TabIndex = 38;
            this.Agelabel5.Text = "سن";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Silver;
            this.label6.Location = new System.Drawing.Point(411, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 37;
            this.label6.Text = "گروه";
            // 
            // Phonelabel3
            // 
            this.Phonelabel3.AutoSize = true;
            this.Phonelabel3.ForeColor = System.Drawing.Color.Silver;
            this.Phonelabel3.Location = new System.Drawing.Point(382, 192);
            this.Phonelabel3.Name = "Phonelabel3";
            this.Phonelabel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Phonelabel3.Size = new System.Drawing.Size(60, 17);
            this.Phonelabel3.TabIndex = 36;
            this.Phonelabel3.Text = "شماره تلفن ";
            // 
            // Addresslabel4
            // 
            this.Addresslabel4.AutoSize = true;
            this.Addresslabel4.ForeColor = System.Drawing.Color.Silver;
            this.Addresslabel4.Location = new System.Drawing.Point(407, 262);
            this.Addresslabel4.Name = "Addresslabel4";
            this.Addresslabel4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Addresslabel4.Size = new System.Drawing.Size(35, 17);
            this.Addresslabel4.TabIndex = 35;
            this.Addresslabel4.Text = "آدرس";
            // 
            // Relationlabel2
            // 
            this.Relationlabel2.AutoSize = true;
            this.Relationlabel2.ForeColor = System.Drawing.Color.Silver;
            this.Relationlabel2.Location = new System.Drawing.Point(379, 122);
            this.Relationlabel2.Name = "Relationlabel2";
            this.Relationlabel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Relationlabel2.Size = new System.Drawing.Size(63, 17);
            this.Relationlabel2.TabIndex = 34;
            this.Relationlabel2.Text = "عنوان شغلی";
            // 
            // Namelabel1
            // 
            this.Namelabel1.AutoSize = true;
            this.Namelabel1.ForeColor = System.Drawing.Color.Silver;
            this.Namelabel1.Location = new System.Drawing.Point(352, 52);
            this.Namelabel1.Name = "Namelabel1";
            this.Namelabel1.Size = new System.Drawing.Size(90, 17);
            this.Namelabel1.TabIndex = 33;
            this.Namelabel1.Text = "نام و نام خانوادگی";
            // 
            // SaveCVbutton2
            // 
            this.SaveCVbutton2.FlatAppearance.BorderSize = 0;
            this.SaveCVbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveCVbutton2.ForeColor = System.Drawing.Color.Silver;
            this.SaveCVbutton2.Location = new System.Drawing.Point(297, 563);
            this.SaveCVbutton2.Name = "SaveCVbutton2";
            this.SaveCVbutton2.Size = new System.Drawing.Size(121, 33);
            this.SaveCVbutton2.TabIndex = 52;
            this.SaveCVbutton2.Text = "ذخیره";
            this.SaveCVbutton2.UseVisualStyleBackColor = true;
            // 
            // ChooseCVbutton2
            // 
            this.ChooseCVbutton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChooseCVbutton2.ForeColor = System.Drawing.Color.Silver;
            this.ChooseCVbutton2.Location = new System.Drawing.Point(297, 520);
            this.ChooseCVbutton2.Name = "ChooseCVbutton2";
            this.ChooseCVbutton2.Size = new System.Drawing.Size(121, 37);
            this.ChooseCVbutton2.TabIndex = 51;
            this.ChooseCVbutton2.Text = "انتخاب فایل";
            this.ChooseCVbutton2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(376, 489);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 50;
            this.label1.Text = "آپلود رزومه ";
            // 
            // AgenumericUpDown1
            // 
            this.AgenumericUpDown1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.AgenumericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AgenumericUpDown1.ForeColor = System.Drawing.Color.Silver;
            this.AgenumericUpDown1.Location = new System.Drawing.Point(297, 387);
            this.AgenumericUpDown1.Name = "AgenumericUpDown1";
            this.AgenumericUpDown1.Size = new System.Drawing.Size(121, 18);
            this.AgenumericUpDown1.TabIndex = 53;
            // 
            // rightLayoutPanel1
            // 
            this.rightLayoutPanel1.Location = new System.Drawing.Point(836, 3);
            this.rightLayoutPanel1.Name = "rightLayoutPanel1";
            this.rightLayoutPanel1.Size = new System.Drawing.Size(75, 737);
            this.rightLayoutPanel1.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 50);
            this.panel1.TabIndex = 54;
            // 
            // SearchUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.rightLayoutPanel1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AgenumericUpDown1);
            this.Controls.Add(this.SaveCVbutton2);
            this.Controls.Add(this.ChooseCVbutton2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CVbutton1);
            this.Controls.Add(this.SaveEditbutton2);
            this.Controls.Add(this.parametercomboBox1);
            this.Controls.Add(this.AddressbunifuMaterialTextbox1);
            this.Controls.Add(this.PhonebunifuMaterialTextbox1);
            this.Controls.Add(this.RelationbunifuMaterialTextbox1);
            this.Controls.Add(this.NamebunifuMaterialTextbox1);
            this.Controls.Add(this.Agelabel5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Phonelabel3);
            this.Controls.Add(this.Addresslabel4);
            this.Controls.Add(this.Relationlabel2);
            this.Controls.Add(this.Namelabel1);
            this.Controls.Add(this.Searchlabel1);
            this.Controls.Add(this.SearchbunifuMaterialTextbox1);
            this.Controls.Add(this.SearchlistBox1);
            this.Name = "SearchUserControl";
            this.Size = new System.Drawing.Size(914, 740);
            this.Load += new System.EventHandler(this.SearchUserControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AgenumericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Searchlabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SearchbunifuMaterialTextbox1;
        private System.Windows.Forms.ListBox SearchlistBox1;
        private System.Windows.Forms.Button CVbutton1;
        private System.Windows.Forms.Button SaveEditbutton2;
        private System.Windows.Forms.ComboBox parametercomboBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox AddressbunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PhonebunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox RelationbunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox NamebunifuMaterialTextbox1;
        private System.Windows.Forms.Label Agelabel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Phonelabel3;
        private System.Windows.Forms.Label Addresslabel4;
        private System.Windows.Forms.Label Relationlabel2;
        private System.Windows.Forms.Label Namelabel1;
        private System.Windows.Forms.Button SaveCVbutton2;
        private System.Windows.Forms.Button ChooseCVbutton2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown AgenumericUpDown1;
        private System.Windows.Forms.FlowLayoutPanel rightLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
    }
}
