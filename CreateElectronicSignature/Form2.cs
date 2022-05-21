
using Syncfusion.Pdf.Parsing;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateElectronicSignature
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void kryptonLabel1_Click(object sender, EventArgs e)
        {

        }

        private void selectFileButton_Click(object sender, EventArgs e)
        {
           
            openFileDialog1.ShowDialog();
            dataTextBox.Text = openFileDialog1.FileName;
            pdfDocumentView1.Load(dataTextBox.Text);
           
        }

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            kryptonRichTextBox1.Text = openFileDialog2.FileName;
           
        }

        private void SignButton_Click(object sender, EventArgs e)
        {
            Image bmp = new Bitmap(SignImagePanel.Width, SignImagePanel.Height);
           
            var gg = Graphics.FromImage(bmp);
            var rect = SignImagePanel.RectangleToScreen(SignImagePanel.ClientRectangle);
            gg.CopyFromScreen(rect.Location, Point.Empty, SignImagePanel.Size);
            bmp.Save("Test.jpg", ImageFormat.Jpeg);
            SignPdf signPdf = new SignPdf();
            signPdf.Sign2(dataTextBox.Text, kryptonRichTextBox1.Text, kryptonRichTextBox5.Text, bmp,SignLocationPanel);
        }

        private void kryptonRichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }



        float PointX, PointY, LastX, LastY;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                SignLocationPanel.Left += e.X - point.X;
                SignLocationPanel.Top += e.Y - point.Y;
            }
        }

        Point point;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            point = e.Location;
        }

        private void kryptonPanel3_Paint(object sender, PaintEventArgs e)
        {
            Graphics G = SignImagePanel.CreateGraphics();
            G.DrawLine(Pens.Black,PointX,PointY,LastX,LastY);
            LastX = PointX;
            LastY = PointY;

        }

        private void kryptonPanel3_MouseDown(object sender, MouseEventArgs e)
        {
            LastX = e.X;
            LastY = e.Y;
        }

        private void kryptonPanel3_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                PointX = e.X;
                PointY = e.Y;
                kryptonPanel3_Paint(this, null);
            }

        }
    }
}
