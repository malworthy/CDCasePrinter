namespace CDCasePrinter
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            btnPrint = new Button();
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
            btnFolder = new Button();
            btnSelectCoverArt = new Button();
            chkSlimline = new CheckBox();
            numFontSize = new NumericUpDown();
            label6 = new Label();
            txtQRCode = new TextBox();
            label7 = new Label();
            label8 = new Label();
            numFrontFont = new NumericUpDown();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            txtCode = new TextBox();
            label9 = new Label();
            ((System.ComponentModel.ISupportInitialize)numFontSize).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFrontFont).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(3, 37);
            btnPrint.Margin = new Padding(3, 4, 3, 4);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(77, 31);
            btnPrint.TabIndex = 0;
            btnPrint.Text = "Print";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // txtFrontCoverText
            // 
            txtFrontCoverText.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtFrontCoverText.Location = new Point(3, 24);
            txtFrontCoverText.Margin = new Padding(3, 4, 3, 4);
            txtFrontCoverText.Multiline = true;
            txtFrontCoverText.Name = "txtFrontCoverText";
            txtFrontCoverText.ScrollBars = ScrollBars.Vertical;
            txtFrontCoverText.Size = new Size(574, 329);
            txtFrontCoverText.TabIndex = 1;
            // 
            // txtCoverArt
            // 
            txtCoverArt.Location = new Point(3, 25);
            txtCoverArt.Name = "txtCoverArt";
            txtCoverArt.Size = new Size(494, 27);
            txtCoverArt.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 2);
            label1.Name = "label1";
            label1.Size = new Size(71, 20);
            label1.TabIndex = 3;
            label1.Text = "Cover Art";
            // 
            // txtArtist
            // 
            txtArtist.Location = new Point(3, 26);
            txtArtist.Name = "txtArtist";
            txtArtist.Size = new Size(494, 27);
            txtArtist.TabIndex = 4;
            // 
            // txtAlbum
            // 
            txtAlbum.Location = new Point(3, 23);
            txtAlbum.Name = "txtAlbum";
            txtAlbum.Size = new Size(494, 27);
            txtAlbum.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(3, 3);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 6;
            label2.Text = "Artist";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 7;
            label3.Text = "Album";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 0);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 8;
            label4.Text = "Front insert";
            // 
            // txtBackCover
            // 
            txtBackCover.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtBackCover.Location = new Point(3, 23);
            txtBackCover.Margin = new Padding(3, 4, 3, 4);
            txtBackCover.Multiline = true;
            txtBackCover.Name = "txtBackCover";
            txtBackCover.ScrollBars = ScrollBars.Vertical;
            txtBackCover.Size = new Size(568, 513);
            txtBackCover.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 2);
            label5.Name = "label5";
            label5.Size = new Size(82, 20);
            label5.TabIndex = 10;
            label5.Text = "Back Cover";
            // 
            // btnFolder
            // 
            btnFolder.Location = new Point(86, 37);
            btnFolder.Name = "btnFolder";
            btnFolder.Size = new Size(119, 31);
            btnFolder.TabIndex = 11;
            btnFolder.Text = "Select Folder";
            btnFolder.UseVisualStyleBackColor = true;
            btnFolder.Click += btnFolder_Click;
            // 
            // btnSelectCoverArt
            // 
            btnSelectCoverArt.Location = new Point(503, 25);
            btnSelectCoverArt.Name = "btnSelectCoverArt";
            btnSelectCoverArt.Size = new Size(51, 29);
            btnSelectCoverArt.TabIndex = 12;
            btnSelectCoverArt.Text = "...";
            btnSelectCoverArt.UseVisualStyleBackColor = true;
            btnSelectCoverArt.Click += btnSelectCoverArt_Click;
            // 
            // chkSlimline
            // 
            chkSlimline.AutoSize = true;
            chkSlimline.Location = new Point(9, 2);
            chkSlimline.Name = "chkSlimline";
            chkSlimline.Size = new Size(119, 24);
            chkSlimline.TabIndex = 13;
            chkSlimline.Text = "Slimline Case";
            chkSlimline.UseVisualStyleBackColor = true;
            // 
            // numFontSize
            // 
            numFontSize.Location = new Point(78, 1);
            numFontSize.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numFontSize.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            numFontSize.Name = "numFontSize";
            numFontSize.Size = new Size(84, 27);
            numFontSize.TabIndex = 14;
            numFontSize.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 4);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 15;
            label6.Text = "Font Size";
            // 
            // txtQRCode
            // 
            txtQRCode.Location = new Point(78, 34);
            txtQRCode.Name = "txtQRCode";
            txtQRCode.Size = new Size(499, 27);
            txtQRCode.TabIndex = 16;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(4, 37);
            label7.Name = "label7";
            label7.Size = new Size(68, 20);
            label7.TabIndex = 17;
            label7.Text = "QR Code";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(208, 6);
            label8.Name = "label8";
            label8.Size = new Size(69, 20);
            label8.TabIndex = 19;
            label8.Text = "Font Size";
            // 
            // numFrontFont
            // 
            numFrontFont.Location = new Point(283, 4);
            numFrontFont.Maximum = new decimal(new int[] { 16, 0, 0, 0 });
            numFrontFont.Minimum = new decimal(new int[] { 6, 0, 0, 0 });
            numFrontFont.Name = "numFrontFont";
            numFrontFont.Size = new Size(80, 27);
            numFrontFont.TabIndex = 18;
            numFrontFont.Value = new decimal(new int[] { 10, 0, 0, 0 });
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel5, 0, 4);
            tableLayoutPanel1.Controls.Add(panel6, 1, 0);
            tableLayoutPanel1.Controls.Add(panel7, 1, 4);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 76F));
            tableLayoutPanel1.Size = new Size(1172, 619);
            tableLayoutPanel1.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Controls.Add(txtCoverArt);
            panel1.Controls.Add(btnSelectCoverArt);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(580, 54);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(txtArtist);
            panel2.Controls.Add(label2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 63);
            panel2.Name = "panel2";
            panel2.Size = new Size(580, 54);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(label3);
            panel3.Controls.Add(txtAlbum);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 123);
            panel3.Name = "panel3";
            panel3.Size = new Size(580, 54);
            panel3.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtFrontCoverText);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 183);
            panel4.Name = "panel4";
            panel4.Size = new Size(580, 357);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(chkSlimline);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(numFrontFont);
            panel5.Controls.Add(btnPrint);
            panel5.Controls.Add(btnFolder);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 546);
            panel5.Name = "panel5";
            panel5.Size = new Size(580, 70);
            panel5.TabIndex = 4;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtBackCover);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(589, 3);
            panel6.Name = "panel6";
            tableLayoutPanel1.SetRowSpan(panel6, 4);
            panel6.Size = new Size(580, 537);
            panel6.TabIndex = 5;
            // 
            // panel7
            // 
            panel7.Controls.Add(txtCode);
            panel7.Controls.Add(label9);
            panel7.Controls.Add(label6);
            panel7.Controls.Add(txtQRCode);
            panel7.Controls.Add(label7);
            panel7.Controls.Add(numFontSize);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(589, 546);
            panel7.Name = "panel7";
            panel7.Size = new Size(580, 70);
            panel7.TabIndex = 6;
            // 
            // txtCode
            // 
            txtCode.Location = new Point(284, 0);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(293, 27);
            txtCode.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(178, 5);
            label9.Name = "label9";
            label9.Size = new Size(100, 20);
            label9.TabIndex = 18;
            label9.Text = "Code/Serial #";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1172, 619);
            Controls.Add(tableLayoutPanel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CD Case Printer";
            ((System.ComponentModel.ISupportInitialize)numFontSize).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFrontFont).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Drawing.Printing.PrintDocument printDocument1;
        private Button btnPrint;
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
        private Button btnFolder;
        private Button btnSelectCoverArt;
        private CheckBox chkSlimline;
        private NumericUpDown numFontSize;
        private Label label6;
        private TextBox txtQRCode;
        private Label label7;
        private Label label8;
        private NumericUpDown numFrontFont;
        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private TextBox txtCode;
        private Label label9;
    }
}
