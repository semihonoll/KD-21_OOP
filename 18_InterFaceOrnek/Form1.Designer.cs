namespace _18_InterFaceOrnek
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
            dataGridView1 = new DataGridView();
            btnKup = new Button();
            btnDikdortgen = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(461, 150);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            // 
            // btnKup
            // 
            btnKup.Location = new Point(78, 194);
            btnKup.Name = "btnKup";
            btnKup.Size = new Size(84, 55);
            btnKup.TabIndex = 1;
            btnKup.Text = "Küp Liste";
            btnKup.UseVisualStyleBackColor = true;
            btnKup.Click += btnKup_Click;
            // 
            // btnDikdortgen
            // 
            btnDikdortgen.Location = new Point(265, 194);
            btnDikdortgen.Name = "btnDikdortgen";
            btnDikdortgen.Size = new Size(82, 55);
            btnDikdortgen.TabIndex = 2;
            btnDikdortgen.Text = "Dikdörtgen Liste";
            btnDikdortgen.UseVisualStyleBackColor = true;
            btnDikdortgen.Click += btnDikdortgen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(462, 297);
            Controls.Add(btnDikdortgen);
            Controls.Add(btnKup);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnKup;
        private Button btnDikdortgen;
    }
}
