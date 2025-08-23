namespace CDCasePrinter
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
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            button1 = new Button();
            txtFrontCoverText = new TextBox();
            txtCoverArt = new TextBox();
            label1 = new Label();
            txtArtist = new TextBox();
            txtAlbum = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBackCover = new TextBox();
            label5 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // button1
            // 
            button1.Location = new Point(67, 594);
            button1.Margin = new Padding(3, 4, 3, 4);
            button1.Name = "button1";
            button1.Size = new Size(86, 31);
            button1.TabIndex = 0;
            button1.Text = "Print";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtFrontCoverText
            // 
            txtFrontCoverText.Location = new Point(67, 268);
            txtFrontCoverText.Margin = new Padding(3, 4, 3, 4);
            txtFrontCoverText.Multiline = true;
            txtFrontCoverText.Name = "txtFrontCoverText";
            txtFrontCoverText.Size = new Size(365, 293);
            txtFrontCoverText.TabIndex = 1;
            // 
            // txtCoverArt
            // 
            txtCoverArt.Location = new Point(67, 80);
            txtCoverArt.Name = "txtCoverArt";
            txtCoverArt.Size = new Size(362, 27);
            txtCoverArt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 51);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Cover Art";
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(67, 142);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(364, 27);
            txtArtist.TabIndex = 4;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(67, 205);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(362, 27);
            txtAlbum.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 119);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 182);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Album";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 244);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "Front insert";
            // 
            // txtBackCover
            // 
            txtBackCover.Location = new Point(493, 80);
            txtBackCover.Margin = new Padding(3, 4, 3, 4);
            txtBackCover.Multiline = true;
            txtBackCover.Name = "txtBackCover";
            txtBackCover.Size = new Size(513, 481);
            txtBackCover.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 44);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 10;
            label5.Text = "Back Cover";
            // 
            // button2
            // 
            button2.Location = new Point(159, 594);
            button2.Name = "button2";
            button2.Size = new Size(143, 31);
            button2.TabIndex = 11;
            button2.Text = "Select Folder";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1060, 655);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(txtBackCover);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtAlbum);
            Controls.Add(txtArtist);
            Controls.Add(label1);
            Controls.Add(txtCoverArt);
            Controls.Add(txtFrontCoverText);
            Controls.Add(button1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CD Case Printer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button button1;
        private TextBox txtFrontCoverText;
        private TextBox txtCoverArt;
        private Label label1;
        private TextBox txtArtist;
        private TextBox txtAlbum;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtBackCover;
        private Label label5;
        private Button button2;
    }
}
