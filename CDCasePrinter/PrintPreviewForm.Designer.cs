namespace CDCasePrinter;

partial class PrintPreviewForm
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
        System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintPreviewForm));
        toolStripContainer1 = new ToolStripContainer();
        printPreviewControl1 = new PrintPreviewControl();
        toolStrip1 = new ToolStrip();
        btnPrint = new ToolStripButton();
        cboPrinters = new ToolStripComboBox();
        btnClose = new ToolStripButton();
        toolStripContainer1.ContentPanel.SuspendLayout();
        toolStripContainer1.TopToolStripPanel.SuspendLayout();
        toolStripContainer1.SuspendLayout();
        toolStrip1.SuspendLayout();
        SuspendLayout();
        // 
        // toolStripContainer1
        // 
        toolStripContainer1.BottomToolStripPanelVisible = false;
        // 
        // toolStripContainer1.ContentPanel
        // 
        toolStripContainer1.ContentPanel.Controls.Add(printPreviewControl1);
        toolStripContainer1.ContentPanel.Margin = new Padding(3, 4, 3, 4);
        toolStripContainer1.ContentPanel.Size = new Size(914, 572);
        toolStripContainer1.Dock = DockStyle.Fill;
        toolStripContainer1.LeftToolStripPanelVisible = false;
        toolStripContainer1.Location = new Point(0, 0);
        toolStripContainer1.Margin = new Padding(3, 4, 3, 4);
        toolStripContainer1.Name = "toolStripContainer1";
        toolStripContainer1.RightToolStripPanelVisible = false;
        toolStripContainer1.Size = new Size(914, 600);
        toolStripContainer1.TabIndex = 0;
        toolStripContainer1.Text = "toolStripContainer1";
        // 
        // toolStripContainer1.TopToolStripPanel
        // 
        toolStripContainer1.TopToolStripPanel.Controls.Add(toolStrip1);
        // 
        // printPreviewControl1
        // 
        printPreviewControl1.Columns = 2;
        printPreviewControl1.Dock = DockStyle.Fill;
        printPreviewControl1.Location = new Point(0, 0);
        printPreviewControl1.Margin = new Padding(3, 4, 3, 4);
        printPreviewControl1.Name = "printPreviewControl1";
        printPreviewControl1.Size = new Size(914, 572);
        printPreviewControl1.TabIndex = 0;
        // 
        // toolStrip1
        // 
        toolStrip1.Dock = DockStyle.None;
        toolStrip1.ImageScalingSize = new Size(20, 20);
        toolStrip1.Items.AddRange(new ToolStripItem[] { btnPrint, cboPrinters, btnClose });
        toolStrip1.Location = new Point(4, 0);
        toolStrip1.Name = "toolStrip1";
        toolStrip1.Size = new Size(343, 28);
        toolStrip1.TabIndex = 0;
        // 
        // btnPrint
        // 
        btnPrint.DisplayStyle = ToolStripItemDisplayStyle.Image;
        btnPrint.Image = (Image)resources.GetObject("btnPrint.Image");
        btnPrint.ImageTransparentColor = Color.Magenta;
        btnPrint.Name = "btnPrint";
        btnPrint.Size = new Size(29, 25);
        btnPrint.Text = "Print";
        btnPrint.Click += toolStripButton1_Click;
        // 
        // cboPrinters
        // 
        cboPrinters.DropDownStyle = ComboBoxStyle.DropDownList;
        cboPrinters.Name = "cboPrinters";
        cboPrinters.Size = new Size(250, 28);
        // 
        // btnClose
        // 
        btnClose.DisplayStyle = ToolStripItemDisplayStyle.Text;
        btnClose.Image = (Image)resources.GetObject("btnClose.Image");
        btnClose.ImageTransparentColor = Color.Magenta;
        btnClose.Name = "btnClose";
        btnClose.Size = new Size(49, 25);
        btnClose.Text = "Close";
        btnClose.Click += btnClose_Click;
        // 
        // PrintPreviewForm
        // 
        AutoScaleDimensions = new SizeF(8F, 20F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(914, 600);
        Controls.Add(toolStripContainer1);
        Icon = (Icon)resources.GetObject("$this.Icon");
        Margin = new Padding(3, 4, 3, 4);
        Name = "PrintPreviewForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Print Preview";
        WindowState = FormWindowState.Maximized;
        Load += FormPrintPreview_Load;
        toolStripContainer1.ContentPanel.ResumeLayout(false);
        toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
        toolStripContainer1.TopToolStripPanel.PerformLayout();
        toolStripContainer1.ResumeLayout(false);
        toolStripContainer1.PerformLayout();
        toolStrip1.ResumeLayout(false);
        toolStrip1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private ToolStripContainer toolStripContainer1;
    private PrintPreviewControl printPreviewControl1;
    private ToolStrip toolStrip1;
    private ToolStripComboBox cboPrinters;
    private ToolStripButton btnPrint;
    private ToolStripButton btnClose;
}