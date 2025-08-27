using System.Drawing.Drawing2D;
using System.Reflection;
using System.Text;
using ATL;

namespace CDCasePrinter
{
    public partial class MainForm : Form
    {
        private int page = 0;
        public MainForm()
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
                PrintFooter(e.Graphics);
                e.HasMorePages = true;
            }
            else if (page == 2)
            {
                PrintBackCover(e.Graphics);
                PrintFooter(e.Graphics);
                e.HasMorePages = false;
                page = 0;
            }
        }

        private void PrintFooter(Graphics g)
        {
            var assembly = Assembly.GetExecutingAssembly();
            var fvi = System.Diagnostics.FileVersionInfo.GetVersionInfo(assembly.Location);

            var text = $"CD Case Printer - Version {fvi.FileVersion}";
            g.DrawString(text, new Font("Ariel", 9), Brushes.Gray, 10, 280);
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
            float width = 150;

            g.DrawRectangle(recPen, new RectangleF(new PointF(marginX, marginY), new SizeF(width, 118)));
            g.DrawLine(recPen, marginX + 6, marginY, marginX + 6, marginY + 118);
            g.DrawLine(recPen, marginX + width - 6, marginY, marginX + width - 6, marginY + 118);

            var drawFormat = new StringFormat(StringFormatFlags.DirectionVertical);
            var size = g.MeasureString(title, spineFont, new PointF(0, 0), drawFormat);
            g.DrawString(title,
                spineFont,
                Brushes.Black,
                marginX + width - 5.5f,
                marginY + (118 / 2 - size.Height / 2),
                drawFormat);

            var state = g.Save();
            g.ResetTransform();
            g.RotateTransform(270);
            g.TranslateTransform(marginX + 1, marginY + (118 / 2 + size.Height / 2), MatrixOrder.Append);
            g.DrawString(title, spineFont, Brushes.Black, 0, 0);
            g.Restore(state);

            var textX = marginX + border + 6;
            // artist
            g.DrawString(txtArtist.Text, artistFont, Brushes.Black,
                new PointF(textX, marginY + border));

            // album
            size = g.MeasureString(txtAlbum.Text, albumFont);
            g.DrawString(txtAlbum.Text, albumFont, Brushes.Black,
                new PointF(textX, marginY + border + size.Height));

            // songs
            g.DrawString(txtBackCover.Text, new Font("Ariel", 10), Brushes.Black,
                new RectangleF(textX, marginY + 25, 130, 100));
        }

        private void PrintFrontCover(Graphics g)
        {
            var recPen = new Pen(Color.Black, 0.5f);
            float marginX = 45;
            float marginY = 25;
            float padding = 10;

            g.DrawRectangle(recPen, new RectangleF(new PointF(marginX, marginY), new SizeF(120, 240)));
            g.DrawLine(recPen, marginX, marginY + 120, marginX + 120, marginY + 120);
            if (!string.IsNullOrEmpty(txtCoverArt.Text) && File.Exists(txtCoverArt.Text))
            {
                var bmp = (Bitmap)Bitmap.FromFile(txtCoverArt.Text);
                bmp.RotateFlip(RotateFlipType.Rotate270FlipXY);
                g.DrawImage(bmp, new RectangleF(marginX, marginY + 120, 120, 120));
                bmp.Dispose();
            }

            var drawFormat = new StringFormat(StringFormatFlags.DirectionVertical | StringFormatFlags.DirectionRightToLeft);

            g.DrawString(txtFrontCoverText.Text, new Font("Ariel", 10), Brushes.Black,
                new RectangleF(marginX,
                    marginY + padding,
                    120 - padding * 2,
                    120 - padding * 2),
                drawFormat);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                ShowPrintPreview();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Could not print");
            }
        }

        private void ShowPrintPreview()
        {
            using var pp = new PrintPreviewForm();
            pp.Document = printDocument1;
            pp.ShowDialog();
        }

        private void btnFolder_Click(object sender, EventArgs e)
        {
            // Below is the most important line of code in this entire project!
            // Remove it and you cannot print. It overcomes some issue with .NET, printers and the ATL library.
            Console.WriteLine(printDocument1.PrinterSettings.PrinterName);

            txtFrontCoverText.Text = "";
            
            using var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() != DialogResult.OK) return;
            PopulateDetails(dlg.SelectedPath);
        }

        private void PopulateDetails(string folder)
        {
            var imageFiles = new[] { ".jpg", ".jpeg", ".png", ".bmp" };
            var audioFiles = new[] { ".mp3", ".flac", ".ogg", ".wav", ".m4a" };
            var files = Directory.GetFiles(folder);
            if (files.Length == 0) return;

            var firstFile = files.FirstOrDefault(x => audioFiles.Contains(Path.GetExtension(x.ToLower())));
            var track1 = new Track(firstFile);
            txtArtist.Text = track1.Artist;
            txtAlbum.Text = track1.Album;

            var audioFormat = $"Source Audio Format: {track1.AudioFormat.Name}";
            if (track1.AudioFormat.ShortName.StartsWith("MPEG"))
            {
                if (track1.IsVBR) audioFormat += " (VBR)";
                else audioFormat += $" ({track1.Bitrate} kbps)";
            }

            var imageFile = files.FirstOrDefault(x => imageFiles.Contains(Path.GetExtension(x.ToLower())));
            txtCoverArt.Text = imageFile ?? string.Empty;
            var songs = new StringBuilder();
            var totalDuration = TimeSpan.Zero;
            foreach (var file in files)
            {
                var track = new Track(file);
                if (track.Duration > 0)
                {
                    var duration = TimeSpan.FromSeconds(track.Duration);
                    songs.AppendLine($"{track.TrackNumber}. {track.Title} {duration:m\\:ss}");
                    totalDuration += duration;
                }
            }
            songs.AppendLine($"Total Length: {totalDuration:m\\:ss}");
            songs.AppendLine();
            songs.AppendLine();
            songs.AppendLine(audioFormat);
            txtBackCover.Text = songs.ToString();
        }

        private void btnSelectCoverArt_Click(object sender, EventArgs e)
        {
            using OpenFileDialog ofd = new();
            ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtCoverArt.Text = ofd.FileName;
            }
        }

    }
}
