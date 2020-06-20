namespace Rezarvasyon_onur_otel
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TC_No_TextBox = new System.Windows.Forms.TextBox();
            this.Ad_Soyad_TextBox = new System.Windows.Forms.TextBox();
            this.Uyruk_ComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Bekar = new System.Windows.Forms.CheckBox();
            this.evli = new System.Windows.Forms.CheckBox();
            this.Kaydet = new System.Windows.Forms.Button();
            this.Yeni_musteri = new System.Windows.Forms.Button();
            this.Musteri_Sil = new System.Windows.Forms.Button();
            this.Tum_Musteri_Sil = new System.Windows.Forms.Button();
            this.Secileni_Sil = new System.Windows.Forms.Button();
            this.Ara = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.listView1.CheckBoxes = true;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(13, 313);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(636, 321);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "T.C No";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "AD-Soyad";
            // 
            // TC_No_TextBox
            // 
            this.TC_No_TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.TC_No_TextBox.Location = new System.Drawing.Point(147, 13);
            this.TC_No_TextBox.Name = "TC_No_TextBox";
            this.TC_No_TextBox.Size = new System.Drawing.Size(162, 20);
            this.TC_No_TextBox.TabIndex = 3;
            // 
            // Ad_Soyad_TextBox
            // 
            this.Ad_Soyad_TextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.Ad_Soyad_TextBox.Location = new System.Drawing.Point(147, 62);
            this.Ad_Soyad_TextBox.Name = "Ad_Soyad_TextBox";
            this.Ad_Soyad_TextBox.Size = new System.Drawing.Size(162, 20);
            this.Ad_Soyad_TextBox.TabIndex = 4;
            // 
            // Uyruk_ComboBox
            // 
            this.Uyruk_ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Uyruk_ComboBox.FormattingEnabled = true;
            this.Uyruk_ComboBox.Location = new System.Drawing.Point(147, 111);
            this.Uyruk_ComboBox.Name = "Uyruk_ComboBox";
            this.Uyruk_ComboBox.Size = new System.Drawing.Size(162, 21);
            this.Uyruk_ComboBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 22);
            this.label3.TabIndex = 6;
            this.label3.Text = "Uyruk";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Bekar);
            this.groupBox1.Controls.Add(this.evli);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox1.Location = new System.Drawing.Point(353, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(280, 118);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Medeni Durumu";
            // 
            // Bekar
            // 
            this.Bekar.AutoSize = true;
            this.Bekar.Location = new System.Drawing.Point(17, 66);
            this.Bekar.Name = "Bekar";
            this.Bekar.Size = new System.Drawing.Size(84, 28);
            this.Bekar.TabIndex = 1;
            this.Bekar.Text = "Bekar";
            this.Bekar.UseVisualStyleBackColor = true;
            // 
            // evli
            // 
            this.evli.AutoSize = true;
            this.evli.Location = new System.Drawing.Point(17, 32);
            this.evli.Name = "evli";
            this.evli.Size = new System.Drawing.Size(64, 28);
            this.evli.TabIndex = 0;
            this.evli.Text = "Evli";
            this.evli.UseVisualStyleBackColor = true;
            // 
            // Kaydet
            // 
            this.Kaydet.Location = new System.Drawing.Point(17, 243);
            this.Kaydet.Name = "Kaydet";
            this.Kaydet.Size = new System.Drawing.Size(121, 41);
            this.Kaydet.TabIndex = 8;
            this.Kaydet.Text = "Müşteri Kayıt";
            this.Kaydet.UseVisualStyleBackColor = true;
            this.Kaydet.Click += new System.EventHandler(this.Kaydet_Click);
            // 
            // Yeni_musteri
            // 
            this.Yeni_musteri.Location = new System.Drawing.Point(147, 243);
            this.Yeni_musteri.Name = "Yeni_musteri";
            this.Yeni_musteri.Size = new System.Drawing.Size(121, 41);
            this.Yeni_musteri.TabIndex = 9;
            this.Yeni_musteri.Text = "Yeni Müşteri ";
            this.Yeni_musteri.UseVisualStyleBackColor = true;
            this.Yeni_musteri.Click += new System.EventHandler(this.Yeni_musteri_Click);
            // 
            // Musteri_Sil
            // 
            this.Musteri_Sil.Location = new System.Drawing.Point(274, 243);
            this.Musteri_Sil.Name = "Musteri_Sil";
            this.Musteri_Sil.Size = new System.Drawing.Size(121, 41);
            this.Musteri_Sil.TabIndex = 10;
            this.Musteri_Sil.Text = "Müşteri Sil";
            this.Musteri_Sil.UseVisualStyleBackColor = true;
            this.Musteri_Sil.Click += new System.EventHandler(this.Musteri_Sil_Click);
            // 
            // Tum_Musteri_Sil
            // 
            this.Tum_Musteri_Sil.Location = new System.Drawing.Point(401, 243);
            this.Tum_Musteri_Sil.Name = "Tum_Musteri_Sil";
            this.Tum_Musteri_Sil.Size = new System.Drawing.Size(121, 41);
            this.Tum_Musteri_Sil.TabIndex = 11;
            this.Tum_Musteri_Sil.Text = "Tüm Müşterileri Sil";
            this.Tum_Musteri_Sil.UseVisualStyleBackColor = true;
            this.Tum_Musteri_Sil.Click += new System.EventHandler(this.Tum_Musteri_Sil_Click);
            // 
            // Secileni_Sil
            // 
            this.Secileni_Sil.Location = new System.Drawing.Point(528, 243);
            this.Secileni_Sil.Name = "Secileni_Sil";
            this.Secileni_Sil.Size = new System.Drawing.Size(121, 41);
            this.Secileni_Sil.TabIndex = 12;
            this.Secileni_Sil.Text = "Seçilen Müşterileri Sil";
            this.Secileni_Sil.UseVisualStyleBackColor = true;
            this.Secileni_Sil.Click += new System.EventHandler(this.Secileni_Sil_Click);
            // 
            // Ara
            // 
            this.Ara.Location = new System.Drawing.Point(163, 154);
            this.Ara.Name = "Ara";
            this.Ara.Size = new System.Drawing.Size(121, 41);
            this.Ara.TabIndex = 13;
            this.Ara.Text = "Müşteriyi Ara";
            this.Ara.UseVisualStyleBackColor = true;
            this.Ara.Click += new System.EventHandler(this.Ara_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(654, 646);
            this.Controls.Add(this.Ara);
            this.Controls.Add(this.Secileni_Sil);
            this.Controls.Add(this.Tum_Musteri_Sil);
            this.Controls.Add(this.Musteri_Sil);
            this.Controls.Add(this.Yeni_musteri);
            this.Controls.Add(this.Kaydet);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Uyruk_ComboBox);
            this.Controls.Add(this.Ad_Soyad_TextBox);
            this.Controls.Add(this.TC_No_TextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Name = "Form1";
            this.Text = "Otel Müşteri Kayıt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TC_No_TextBox;
        private System.Windows.Forms.TextBox Ad_Soyad_TextBox;
        private System.Windows.Forms.ComboBox Uyruk_ComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox Bekar;
        private System.Windows.Forms.CheckBox evli;
        private System.Windows.Forms.Button Kaydet;
        private System.Windows.Forms.Button Yeni_musteri;
        private System.Windows.Forms.Button Musteri_Sil;
        private System.Windows.Forms.Button Tum_Musteri_Sil;
        private System.Windows.Forms.Button Secileni_Sil;
        private System.Windows.Forms.Button Ara;
    }
}

