namespace Hamburger
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menu = new System.Windows.Forms.Label();
            this.cmb_menu = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sogan_chk = new System.Windows.Forms.CheckBox();
            this.domates_chk = new System.Windows.Forms.CheckBox();
            this.peynir_chk = new System.Windows.Forms.CheckBox();
            this.ketcap_chk = new System.Windows.Forms.CheckBox();
            this.tursu_chk = new System.Windows.Forms.CheckBox();
            this.mayonez_chk = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_siparis = new System.Windows.Forms.Button();
            this.btn_hesap = new System.Windows.Forms.Button();
            this.list_siparisler = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Size = new System.Drawing.Size(336, 145);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menu
            // 
            this.menu.AutoSize = true;
            this.menu.Location = new System.Drawing.Point(28, 209);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(34, 13);
            this.menu.TabIndex = 1;
            this.menu.Text = "Menu";
            // 
            // cmb_menu
            // 
            this.cmb_menu.FormattingEnabled = true;
            this.cmb_menu.Items.AddRange(new object[] {
            "Hamburger (85,00 TL)",
            "CheeseBurger (89,00 TL)",
            "ChickenBurger (83,00 TL)"});
            this.cmb_menu.Location = new System.Drawing.Point(125, 209);
            this.cmb_menu.Name = "cmb_menu";
            this.cmb_menu.Size = new System.Drawing.Size(133, 21);
            this.cmb_menu.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Boyut";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(125, 256);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(45, 17);
            this.radioButton1.TabIndex = 4;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Orta";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(191, 256);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Büyük";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(261, 256);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(46, 17);
            this.radioButton3.TabIndex = 6;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "King";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.mayonez_chk);
            this.groupBox1.Controls.Add(this.tursu_chk);
            this.groupBox1.Controls.Add(this.ketcap_chk);
            this.groupBox1.Controls.Add(this.peynir_chk);
            this.groupBox1.Controls.Add(this.domates_chk);
            this.groupBox1.Controls.Add(this.sogan_chk);
            this.groupBox1.Location = new System.Drawing.Point(31, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ekstralar";
            // 
            // sogan_chk
            // 
            this.sogan_chk.AutoSize = true;
            this.sogan_chk.Location = new System.Drawing.Point(6, 19);
            this.sogan_chk.Name = "sogan_chk";
            this.sogan_chk.Size = new System.Drawing.Size(57, 17);
            this.sogan_chk.TabIndex = 8;
            this.sogan_chk.Text = "Soğan";
            this.sogan_chk.UseVisualStyleBackColor = true;
            // 
            // domates_chk
            // 
            this.domates_chk.AutoSize = true;
            this.domates_chk.Location = new System.Drawing.Point(6, 64);
            this.domates_chk.Name = "domates_chk";
            this.domates_chk.Size = new System.Drawing.Size(68, 17);
            this.domates_chk.TabIndex = 9;
            this.domates_chk.Text = "Domates";
            this.domates_chk.UseVisualStyleBackColor = true;
            // 
            // peynir_chk
            // 
            this.peynir_chk.AutoSize = true;
            this.peynir_chk.Location = new System.Drawing.Point(153, 19);
            this.peynir_chk.Name = "peynir_chk";
            this.peynir_chk.Size = new System.Drawing.Size(55, 17);
            this.peynir_chk.TabIndex = 10;
            this.peynir_chk.Text = "Peynir";
            this.peynir_chk.UseVisualStyleBackColor = true;
            // 
            // ketcap_chk
            // 
            this.ketcap_chk.AutoSize = true;
            this.ketcap_chk.Location = new System.Drawing.Point(151, 64);
            this.ketcap_chk.Name = "ketcap_chk";
            this.ketcap_chk.Size = new System.Drawing.Size(60, 17);
            this.ketcap_chk.TabIndex = 11;
            this.ketcap_chk.Text = "Ketçap";
            this.ketcap_chk.UseVisualStyleBackColor = true;
            // 
            // tursu_chk
            // 
            this.tursu_chk.AutoSize = true;
            this.tursu_chk.Location = new System.Drawing.Point(6, 116);
            this.tursu_chk.Name = "tursu_chk";
            this.tursu_chk.Size = new System.Drawing.Size(53, 17);
            this.tursu_chk.TabIndex = 12;
            this.tursu_chk.Text = "Turşu";
            this.tursu_chk.UseVisualStyleBackColor = true;
            // 
            // mayonez_chk
            // 
            this.mayonez_chk.AutoSize = true;
            this.mayonez_chk.Location = new System.Drawing.Point(148, 116);
            this.mayonez_chk.Name = "mayonez_chk";
            this.mayonez_chk.Size = new System.Drawing.Size(69, 17);
            this.mayonez_chk.TabIndex = 13;
            this.mayonez_chk.Text = "Mayonez";
            this.mayonez_chk.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 463);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Adet";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 455);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(64, 21);
            this.comboBox1.TabIndex = 9;
            this.comboBox1.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 485);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(316, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Büyük Menu Farkı 2 TL King Menu 4 TL.Ekstralar için 0.50 kuruş.";
            // 
            // btn_siparis
            // 
            this.btn_siparis.Location = new System.Drawing.Point(438, 463);
            this.btn_siparis.Name = "btn_siparis";
            this.btn_siparis.Size = new System.Drawing.Size(75, 23);
            this.btn_siparis.TabIndex = 11;
            this.btn_siparis.Text = "Sipariş Al";
            this.btn_siparis.UseVisualStyleBackColor = true;
            this.btn_siparis.Click += new System.EventHandler(this.btn_siparis_Click);
            // 
            // btn_hesap
            // 
            this.btn_hesap.Location = new System.Drawing.Point(608, 463);
            this.btn_hesap.Name = "btn_hesap";
            this.btn_hesap.Size = new System.Drawing.Size(75, 23);
            this.btn_hesap.TabIndex = 12;
            this.btn_hesap.Text = "Hesap";
            this.btn_hesap.UseVisualStyleBackColor = true;
            // 
            // list_siparisler
            // 
            this.list_siparisler.FormattingEnabled = true;
            this.list_siparisler.Location = new System.Drawing.Point(359, 12);
            this.list_siparisler.Name = "list_siparisler";
            this.list_siparisler.Size = new System.Drawing.Size(395, 420);
            this.list_siparisler.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 507);
            this.Controls.Add(this.list_siparisler);
            this.Controls.Add(this.btn_hesap);
            this.Controls.Add(this.btn_siparis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.radioButton3);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_menu);
            this.Controls.Add(this.menu);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label menu;
        private System.Windows.Forms.ComboBox cmb_menu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox mayonez_chk;
        private System.Windows.Forms.CheckBox tursu_chk;
        private System.Windows.Forms.CheckBox ketcap_chk;
        private System.Windows.Forms.CheckBox peynir_chk;
        private System.Windows.Forms.CheckBox domates_chk;
        private System.Windows.Forms.CheckBox sogan_chk;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_siparis;
        private System.Windows.Forms.Button btn_hesap;
        private System.Windows.Forms.ListBox list_siparisler;
    }
}

