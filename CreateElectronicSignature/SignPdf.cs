using Syncfusion.Pdf.Graphics;
using Syncfusion.Pdf.Parsing;
using Syncfusion.Pdf.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateElectronicSignature
{
    internal class SignPdf
    {

       public void Sign(string filePath,string certPath, string certPass)
        {
            PdfLoadedDocument document = new PdfLoadedDocument(filePath);

            //Load digital ID with password.
            PdfCertificate certificate = new PdfCertificate(certPath, certPass);

            //Create a signature with loaded digital ID.
            PdfSignature signature = new PdfSignature(document, document.Pages[0], certificate, "DigitalSignature");

            //Save the PDF document.
            document.Save(@"D:\RSA\SignedDocument.pdf");

            //Close the document.
            document.Close(true);
        }

        public void Sign2(string filePath, string certPath, string certPass, Image signImage , Panel signLocation)
        {
            PdfLoadedDocument document = new PdfLoadedDocument(filePath);

            //Load digital ID with password.
            PdfCertificate certificate = new PdfCertificate(certPath, certPass);

            //Create a signature with loaded digital ID.
            PdfSignature signature = new PdfSignature(document, document.Pages[0], certificate, "DigitalSignature");
            //Set bounds to the signature.
            signature.Bounds = new System.Drawing.RectangleF(signLocation.Left, signLocation.Top, signLocation.Width, signLocation.Height);
            //signature.Bounds = new RectangleF(signLocation.Left, signLocation.Top, signLocation.Width, signLocation.Height);

            //Load image from file.
            //PdfImage image = PdfImage.FromFile(@"D:\RSA\sign.png");
            PdfImage image = PdfImage.FromImage(signImage);
            //Create a font to draw text.
            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 15);

            //Drawing text, shape, and image into the signature appearance.
            //signature.Appearance.Normal.Graphics.DrawRectangle(PdfPens.Black, PdfBrushes.White, new System.Drawing.RectangleF(50, 0, 300, 100));
            signature.Appearance.Normal.Graphics.DrawImage(image, 0, 0, signLocation.Width, signLocation.Height);
            //signature.Appearance.Normal.Graphics.DrawString("Digitally Signed by NguyenHuuTru", font, PdfBrushes.Black, 120, 17);
            //signature.Appearance.Normal.Graphics.DrawString("Reason: Testing signature", font, PdfBrushes.Black, 120, 39);
            //signature.Appearance.Normal.Graphics.DrawString("Location: VietNam", font, PdfBrushes.Black, 120, 60);
            //signature.Appearance.Normal.Graphics.DrawString("Time: " + DateTime.Now, font, PdfBrushes.Black, 120, 80);

            //Save the PDF document.
            document.Save(@"D:\RSA\SignedDocument.pdf");
            //Close the document.
            document.Close(true);
        }
    }
}
