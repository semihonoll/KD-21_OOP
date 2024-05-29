namespace _06_Kapsulleme3
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
            label1 = new Label();
            txtAd = new TextBox();
            txtSoyad = new TextBox();
            label2 = new Label();
            txtTc = new TextBox();
            label3 = new Label();
            btnKaydet = new Button();
            btnSil = new Button();
            lstKayit = new ListView();
            columnHeader2 = new ColumnHeader();
            columnHeader1 = new ColumnHeader();
            columnHeader3 = new ColumnHeader();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(36, 71);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "Ad:";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(119, 70);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(176, 23);
            txtAd.TabIndex = 1;
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(119, 119);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(176, 23);
            txtSoyad.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(36, 120);
            label2.Name = "label2";
            label2.Size = new Size(42, 15);
            label2.TabIndex = 2;
            label2.Text = "Soyad:";
            // 
            // txtTc
            // 
            txtTc.Location = new Point(119, 170);
            txtTc.Name = "txtTc";
            txtTc.Size = new Size(176, 23);
            txtTc.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(36, 171);
            label3.Name = "label3";
            label3.Size = new Size(23, 15);
            label3.TabIndex = 4;
            label3.Text = "TC:";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(119, 224);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(75, 23);
            btnKaydet.TabIndex = 6;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // btnSil
            // 
            btnSil.Location = new Point(220, 224);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(75, 23);
            btnSil.TabIndex = 7;
            btnSil.Text = "Sil";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // lstKayit
            // 
            lstKayit.Columns.AddRange(new ColumnHeader[] { columnHeader2, columnHeader1, columnHeader3 });
            lstKayit.Dock = DockStyle.Bottom;
            lstKayit.FullRowSelect = true;
            lstKayit.GridLines = true;
            lstKayit.Location = new Point(0, 288);
            lstKayit.Name = "lstKayit";
            lstKayit.Size = new Size(390, 162);
            lstKayit.TabIndex = 8;
            lstKayit.UseCompatibleStateImageBehavior = false;
            lstKayit.View = View.Details;
            // 
            // columnHeader2
            // 
            columnHeader2.Text = "TC";
            columnHeader2.Width = 100;
            // 
            // columnHeader1
            // 
            columnHeader1.Text = "Ad";
            columnHeader1.Width = 100;
            // 
            // columnHeader3
            // 
            columnHeader3.Text = "Soyad";
            columnHeader3.Width = 100;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(390, 450);
            Controls.Add(lstKayit);
            Controls.Add(btnSil);
            Controls.Add(btnKaydet);
            Controls.Add(txtTc);
            Controls.Add(label3);
            Controls.Add(txtSoyad);
            Controls.Add(label2);
            Controls.Add(txtAd);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtAd;
        private TextBox txtSoyad;
        private Label label2;
        private TextBox txtTc;
        private Label label3;
        private Button btnKaydet;
        private Button btnSil;
        private ListView lstKayit;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader3;
    }
}
