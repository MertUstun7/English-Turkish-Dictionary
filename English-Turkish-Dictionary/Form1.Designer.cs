namespace ingilizce_turkce_sozluk
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            ekle = new Button();
            guncelle = new Button();
            sil = new Button();
            kelime_list = new ListBox();
            button1 = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label1.Location = new Point(5, 31);
            label1.Name = "label1";
            label1.Size = new Size(66, 20);
            label1.TabIndex = 0;
            label1.Text = "İngilizce";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            label2.Location = new Point(5, 77);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 0;
            label2.Text = "Türkçe";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(75, 28);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(75, 77);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(182, 27);
            textBox2.TabIndex = 2;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // ekle
            // 
            ekle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            ekle.Location = new Point(486, 28);
            ekle.Name = "ekle";
            ekle.Size = new Size(101, 45);
            ekle.TabIndex = 3;
            ekle.Text = "EKLE";
            ekle.UseVisualStyleBackColor = true;
            ekle.Click += ekle_Click;
            // 
            // guncelle
            // 
            guncelle.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            guncelle.Location = new Point(366, 87);
            guncelle.Name = "guncelle";
            guncelle.Size = new Size(101, 47);
            guncelle.TabIndex = 4;
            guncelle.Text = "GÜNCELLE";
            guncelle.UseVisualStyleBackColor = true;
            guncelle.Click += guncelle_Click;
            // 
            // sil
            // 
            sil.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold);
            sil.Location = new Point(486, 157);
            sil.Name = "sil";
            sil.Size = new Size(101, 59);
            sil.TabIndex = 5;
            sil.Text = "SİL";
            sil.UseVisualStyleBackColor = true;
            sil.Click += sil_Click;
            // 
            // kelime_list
            // 
            kelime_list.FormattingEnabled = true;
            kelime_list.Location = new Point(5, 157);
            kelime_list.Name = "kelime_list";
            kelime_list.Size = new Size(441, 144);
            kelime_list.Sorted = true;
            kelime_list.TabIndex = 6;
            // 
            // button1
            // 
            button1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 162);
            button1.Location = new Point(486, 240);
            button1.Name = "button1";
            button1.Size = new Size(101, 61);
            button1.TabIndex = 7;
            button1.Text = "Tema Değiştir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(473, 87);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(131, 24);
            radioButton1.TabIndex = 8;
            radioButton1.TabStop = true;
            radioButton1.Text = "Türkçe-İngilizce";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(473, 110);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(131, 24);
            radioButton2.TabIndex = 9;
            radioButton2.TabStop = true;
            radioButton2.Text = "İngilizce-Türkçe";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(263, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(34, 27);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.image;
            pictureBox2.Location = new Point(263, 77);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(34, 27);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            ClientSize = new Size(599, 313);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(button1);
            Controls.Add(kelime_list);
            Controls.Add(sil);
            Controls.Add(guncelle);
            Controls.Add(ekle);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "İngilizce-Türkçe Sözlük";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button ekle;
        private Button guncelle;
        private Button sil;
        private ListBox kelime_list;
        private Button button1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private System.Windows.Forms.Timer timer1;
    }
}
