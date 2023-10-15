namespace RandevuOdevi
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnRandevuOlustur = new Button();
            rb15 = new RadioButton();
            rb14 = new RadioButton();
            rb13 = new RadioButton();
            rb12 = new RadioButton();
            groupBox1 = new GroupBox();
            rbErkek = new RadioButton();
            rbKadın = new RadioButton();
            cboxPoliklinik = new ComboBox();
            dtTarih = new DateTimePicker();
            mtbTelefon = new MaskedTextBox();
            txtAdSoyad = new TextBox();
            txtTc = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            tabPage2 = new TabPage();
            lstRandevuKaydi = new ListBox();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            groupBox1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(8, 9);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(389, 515);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnRandevuOlustur);
            tabPage1.Controls.Add(rb15);
            tabPage1.Controls.Add(rb14);
            tabPage1.Controls.Add(rb13);
            tabPage1.Controls.Add(rb12);
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(cboxPoliklinik);
            tabPage1.Controls.Add(dtTarih);
            tabPage1.Controls.Add(mtbTelefon);
            tabPage1.Controls.Add(txtAdSoyad);
            tabPage1.Controls.Add(txtTc);
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label5);
            tabPage1.Controls.Add(label4);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(381, 487);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Randevu Oluştur";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnRandevuOlustur
            // 
            btnRandevuOlustur.Location = new Point(76, 415);
            btnRandevuOlustur.Name = "btnRandevuOlustur";
            btnRandevuOlustur.Size = new Size(189, 45);
            btnRandevuOlustur.TabIndex = 17;
            btnRandevuOlustur.Text = "Randevu Oluştur";
            btnRandevuOlustur.UseVisualStyleBackColor = true;
            btnRandevuOlustur.Click += btnRandevuOlustur_Click;
            // 
            // rb15
            // 
            rb15.AutoSize = true;
            rb15.Location = new Point(213, 353);
            rb15.Name = "rb15";
            rb15.Size = new Size(52, 19);
            rb15.TabIndex = 16;
            rb15.TabStop = true;
            rb15.Text = "15:00";
            rb15.UseVisualStyleBackColor = true;
            // 
            // rb14
            // 
            rb14.AutoSize = true;
            rb14.Location = new Point(52, 353);
            rb14.Name = "rb14";
            rb14.Size = new Size(52, 19);
            rb14.TabIndex = 15;
            rb14.TabStop = true;
            rb14.Text = "14:00";
            rb14.UseVisualStyleBackColor = true;
            // 
            // rb13
            // 
            rb13.AutoSize = true;
            rb13.Location = new Point(213, 322);
            rb13.Name = "rb13";
            rb13.Size = new Size(52, 19);
            rb13.TabIndex = 14;
            rb13.TabStop = true;
            rb13.Text = "13:00";
            rb13.UseVisualStyleBackColor = true;
            // 
            // rb12
            // 
            rb12.AutoSize = true;
            rb12.Location = new Point(52, 324);
            rb12.Name = "rb12";
            rb12.Size = new Size(52, 19);
            rb12.TabIndex = 13;
            rb12.TabStop = true;
            rb12.Text = "12:00";
            rb12.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbErkek);
            groupBox1.Controls.Add(rbKadın);
            groupBox1.Location = new Point(41, 151);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 42);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "Cinsiyet";
            // 
            // rbErkek
            // 
            rbErkek.AutoSize = true;
            rbErkek.Location = new Point(134, 19);
            rbErkek.Name = "rbErkek";
            rbErkek.Size = new Size(53, 19);
            rbErkek.TabIndex = 1;
            rbErkek.TabStop = true;
            rbErkek.Text = "Erkek";
            rbErkek.UseVisualStyleBackColor = true;
            // 
            // rbKadın
            // 
            rbKadın.AutoSize = true;
            rbKadın.Location = new Point(16, 13);
            rbKadın.Name = "rbKadın";
            rbKadın.Size = new Size(55, 19);
            rbKadın.TabIndex = 0;
            rbKadın.TabStop = true;
            rbKadın.Text = "Kadın";
            rbKadın.UseVisualStyleBackColor = true;
            // 
            // cboxPoliklinik
            // 
            cboxPoliklinik.FormattingEnabled = true;
            cboxPoliklinik.Location = new Point(108, 235);
            cboxPoliklinik.Name = "cboxPoliklinik";
            cboxPoliklinik.Size = new Size(201, 23);
            cboxPoliklinik.TabIndex = 11;
            // 
            // dtTarih
            // 
            dtTarih.Location = new Point(109, 275);
            dtTarih.Name = "dtTarih";
            dtTarih.Size = new Size(200, 23);
            dtTarih.TabIndex = 10;
            // 
            // mtbTelefon
            // 
            mtbTelefon.Location = new Point(108, 116);
            mtbTelefon.Name = "mtbTelefon";
            mtbTelefon.Size = new Size(201, 23);
            mtbTelefon.TabIndex = 9;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new Point(108, 83);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new Size(201, 23);
            txtAdSoyad.TabIndex = 8;
            // 
            // txtTc
            // 
            txtTc.Location = new Point(108, 50);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(201, 23);
            txtTc.TabIndex = 7;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(27, 272);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 6;
            label7.Text = "Tarih";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(20, 235);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 5;
            label6.Text = "Poliklinik";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 196);
            label5.Name = "label5";
            label5.Size = new Size(95, 15);
            label5.TabIndex = 4;
            label5.Text = "Randevu Bilgileri";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 124);
            label4.Name = "label4";
            label4.Size = new Size(45, 15);
            label4.TabIndex = 3;
            label4.Text = "Telefon";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 91);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 2;
            label3.Text = "Ad Soyad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 58);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 1;
            label2.Text = "TC";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 20);
            label1.Name = "label1";
            label1.Size = new Size(79, 15);
            label1.TabIndex = 0;
            label1.Text = "Hasta Bilgileri";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(lstRandevuKaydi);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(381, 487);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Randevular";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // lstRandevuKaydi
            // 
            lstRandevuKaydi.FormattingEnabled = true;
            lstRandevuKaydi.ItemHeight = 15;
            lstRandevuKaydi.Location = new Point(26, 23);
            lstRandevuKaydi.Name = "lstRandevuKaydi";
            lstRandevuKaydi.Size = new Size(319, 199);
            lstRandevuKaydi.TabIndex = 0;
            lstRandevuKaydi.SelectedIndexChanged += lstRandevuKaydi_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(441, 555);
            Controls.Add(tabControl1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            tabPage2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabPage tabPage1;
        private Button btnRandevuOlustur;
        private RadioButton rb15;
        private RadioButton rb14;
        private RadioButton rb13;
        private RadioButton rb12;
        private GroupBox groupBox1;
        private RadioButton rbErkek;
        private RadioButton rbKadın;
        private ComboBox cboxPoliklinik;
        private DateTimePicker dtTarih;
        private MaskedTextBox mtbTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TabPage tabPage2;
        public ListBox lstRandevuKaydi;
        public TabControl tabControl1;
    }
}