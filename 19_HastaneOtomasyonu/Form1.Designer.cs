namespace _19_HastaneOtomasyonu
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
            btnTest = new Button();
            lstvList = new ListView();
            btnListele = new Button();
            btnDoktorEkle = new Button();
            SuspendLayout();
            // 
            // btnTest
            // 
            btnTest.Location = new Point(12, 12);
            btnTest.Name = "btnTest";
            btnTest.Size = new Size(386, 40);
            btnTest.TabIndex = 0;
            btnTest.Text = "TEST";
            btnTest.UseVisualStyleBackColor = true;
            btnTest.Click += btnTest_Click;
            // 
            // lstvList
            // 
            lstvList.Location = new Point(12, 65);
            lstvList.Name = "lstvList";
            lstvList.Size = new Size(386, 158);
            lstvList.TabIndex = 1;
            lstvList.UseCompatibleStateImageBehavior = false;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(12, 248);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(185, 53);
            btnListele.TabIndex = 2;
            btnListele.Text = "Listele Formunu Aç";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // btnDoktorEkle
            // 
            btnDoktorEkle.Location = new Point(221, 248);
            btnDoktorEkle.Name = "btnDoktorEkle";
            btnDoktorEkle.Size = new Size(177, 53);
            btnDoktorEkle.TabIndex = 3;
            btnDoktorEkle.Text = "Doktor Ekleme Sayfasını Aç";
            btnDoktorEkle.UseVisualStyleBackColor = true;
            btnDoktorEkle.Click += btnDoktorEkle_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(410, 322);
            Controls.Add(btnDoktorEkle);
            Controls.Add(btnListele);
            Controls.Add(lstvList);
            Controls.Add(btnTest);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btnTest;
        private ListView lstvList;
        private Button btnListele;
        private Button btnDoktorEkle;
    }
}
