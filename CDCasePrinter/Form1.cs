using System.Drawing.Drawing2D;

namespace CDCasePrinter
{
    public partial class Form1 : Form
    {
        private int page = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            if (e.Graphics is null) return;
            e.Graphics.PageUnit = GraphicsUnit.Millimeter;
            page++;
            if (page == 1)
            {
                PrintFrontCover(e.Graphics);
                e.HasMorePages = true;
            }
            else if (page == 2) 
            {
                PrintBackCover(e.Graphics);
                e.HasMorePages = false;
                page = 0;
            }
        }

        private void PrintBackCover(Graphics g)
        {
            string title = $"{txtArtist.Text} - {txtAlbum.Text}";
            var spineFont = new Font("Ariel", 12);
            var artistFont = new Font("Ariel", 14, FontStyle.Bold);
            var albumFont = new Font("Ariel", 12);
            var recPen = new Pen(Color.Black, 0.5f);
            float marginX = 25;
            float marginY = 25;
            float border = 10;
            g.DrawRectangle(recPen, new RectangleF(new PointF(marginX, marginY), new SizeF(151, 118)));
            g.DrawLine(recPen, marginX + 6, marginY, marginX + 6, marginY + 118);
            g.DrawLine(recPen, marginX + 151-6, marginY, marginX + 151-6, marginY + 118);

            var drawFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            var size = g.MeasureString(title, spineFont, new PointF(0, 0), drawFormat);
            g.DrawString(title, spineFont, Brushes.Black, marginX + 151 - 5, marginY + (118 / 2 - size.Height / 2), drawFormat);

            var state = g.Save();
            g.ResetTransform();
            g.RotateTransform(270);
            g.TranslateTransform(marginX + 1, marginY + (118 / 2 + size.Height / 2), MatrixOrder.Append);
            g.DrawString(title, spineFont, Brushes.Black, 0, 0);
            g.Restore(state);

            g.DrawString(txtArtist.Text, artistFont, Brushes.Black, 
                new PointF(marginX + border, marginY + border));
        }

        private void PrintFrontCover(Graphics g)
        {
            var recPen = new Pen(Color.Black, 0.5f);
            float marginX = 45;
            float marginY = 25;

            g.DrawRectangle(recPen, new RectangleF(new PointF(marginX, marginY), new SizeF(120, 240)));
            g.DrawLine(recPen, marginX, marginY + 120, marginX + 120, marginY + 120);
            if(!string.IsNullOrEmpty(txtCoverArt.Text) && File.Exists(txtCoverArt.Text))
            {
                var bmp = (Bitmap)Bitmap.FromFile(txtCoverArt.Text);
                bmp.RotateFlip(RotateFlipType.Rotate270FlipXY);
                g.DrawImage(bmp, new RectangleF(marginX, marginY + 120, 120, 120));
            }

            var drawFormat = new StringFormat(StringFormatFlags.DirectionVertical | StringFormatFlags.DirectionRightToLeft);

            g.DrawString(txtFrontCoverText.Text, new Font("Ariel", 10), Brushes.Black, new RectangleF(marginX, marginY,120,120), drawFormat);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using var printerSelector = new PrintDialog();
            if (printerSelector.ShowDialog() == DialogResult.OK)
            {
                printDocument1.PrinterSettings = printerSelector.PrinterSettings;
                using var pp = new PrintPreviewDialog();
                pp.Document = printDocument1;

                pp.ShowDialog();
            }
        }
    }
}
