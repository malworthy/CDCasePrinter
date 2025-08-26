using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDCasePrinter;
public partial class PrintPreviewForm : Form
{
    public PrintDocument? Document
    {
        get
        {
            return printPreviewControl1.Document;
        }
        set
        {
            printPreviewControl1.Document = value;
        }
    }

    public PrintPreviewForm()
    {
        InitializeComponent();
    }

    private void FormPrintPreview_Load(object sender, EventArgs e)
    {
        foreach (string printer in PrinterSettings.InstalledPrinters)
        {
            cboPrinters.Items.Add(printer);
        }
        cboPrinters.Text = Document?.PrinterSettings.PrinterName;

    }

    private void toolStripButton1_Click(object sender, EventArgs e)
    {
        if (Document == null)
        {
            return;
        }
        Document.PrinterSettings.PrinterName = cboPrinters.Text;
        if (!Document.PrinterSettings.IsValid)
        {
            MessageBox.Show($"Unable to print to printer {Document.PrinterSettings.PrinterName} at the moment.  Please select another printer (PDF Printer Recommended)");
            return;
        }
        try
        {
            Document.Print();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Could not print");
        }

    }

    private void btnClose_Click(object sender, EventArgs e)
    {
        Close();
    }
}
