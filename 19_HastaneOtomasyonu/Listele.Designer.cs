namespace _19_HastaneOtomasyonu
{
    partial class Listele
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
            lstvDoktorlar = new ListBox();
            SuspendLayout();
            // 
            // lstvDoktorlar
            // 
            lstvDoktorlar.Dock = DockStyle.Fill;
            lstvDoktorlar.FormattingEnabled = true;
            lstvDoktorlar.ItemHeight = 15;
            lstvDoktorlar.Location = new Point(0, 0);
            lstvDoktorlar.Name = "lstvDoktorlar";
            lstvDoktorlar.Size = new Size(305, 323);
            lstvDoktorlar.TabIndex = 0;
            // 
            // Listele
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(305, 323);
            Controls.Add(lstvDoktorlar);
            Name = "Listele";
            Text = "Listele";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstvDoktorlar;
    }
}