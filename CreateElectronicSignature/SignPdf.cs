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

       public void Sign()
        {
            PdfLoadedDocument document = new PdfLoadedDocument(@"D:\RSA\test.pdf");

            //Load digital ID with password.
            PdfCertificate certificate = new PdfCertificate(@"D:\RSA\mycert.pfx", "123456");

            //Create a signature with loaded digital ID.
            PdfSignature signature = new PdfSignature(document, document.Pages[0], certificate, "DigitalSignature");

            //Save the PDF document.
            document.Save(@"D:\RSA\SignedDocument.pdf");

            //Close the document.
            document.Close(true);
        }

        public void Sign2()
        {
            PdfLoadedDocument document = new PdfLoadedDocument(@"D:\RSA\test.pdf");

            //Load digital ID with password.
            PdfCertificate certificate = new PdfCertificate(@"D:\RSA\mycert.pfx", "123456");

            //Create a signature with loaded digital ID.
            PdfSignature signature = new PdfSignature(document, document.Pages[0], certificate, "DigitalSignature");
            //Set bounds to the signature.
            signature.Bounds = new System.Drawing.RectangleF(40, 40, 350, 100);

            //Load image from file.
            PdfImage image = PdfImage.FromFile(@"D:\RSA\sign.png");
            //Create a font to draw text.
            PdfStandardFont font = new PdfStandardFont(PdfFontFamily.Helvetica, 15);

            //Drawing text, shape, and image into the signature appearance.
            signature.Appearance.Normal.Graphics.DrawRectangle(PdfPens.Black, PdfBrushes.White, new System.Drawing.RectangleF(50, 0, 300, 100));
            signature.Appearance.Normal.Graphics.DrawImage(image, 0, 0, 100, 100);
            signature.Appearance.Normal.Graphics.DrawString("Digitally Signed by NguyenHuuTru", font, PdfBrushes.Black, 120, 17);
            signature.Appearance.Normal.Graphics.DrawString("Reason: Testing signature", font, PdfBrushes.Black, 120, 39);
            signature.Appearance.Normal.Graphics.DrawString("Location: VietNam", font, PdfBrushes.Black, 120, 60);

            //Save the PDF document.
            document.Save(@"D:\RSA\SignedDocument.pdf");

            //Close the document.
            document.Close(true);
        }
    }
}
