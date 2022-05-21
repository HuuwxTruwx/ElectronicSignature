using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreateElectronicSignature
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        RSA rsa = RSA.Instance;
        byte[] sign;

        private void SignDataButton_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(dataTextBox.Text);

            sign = rsa.GenarateSignature(data);
            signatureTextBox.Text = System.Text.Encoding.UTF8.GetString(sign);
        }

        private void SaveKeyButton_Click(object sender, EventArgs e)
        {            
            rsa.SaveKeyToXML(kryptonRichTextBox1.Text);
        }

        private void LoadKeyButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            rsa.LoadKeyFromXML(openFileDialog1.FileName);
            publickeyText.Text = rsa.GetPublicKeyXML();
            privatekeyText.Text = rsa.GetPrivateKeyXML();
        }

        private void GeneraKeyButton_Click(object sender, EventArgs e)
        {
            rsa.GenerateKeys();
            publickeyText.Text = rsa.GetPublicKeyXML();
            privatekeyText.Text = rsa.GetPrivateKeyXML();

        }

        private void VertifyButton_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(vertifydataTextBox.Text);
            //byte[] sign = Encoding.ASCII.GetBytes(richTextBox4.Text);
            bool trust = rsa.VerifySignature(data, sign);
            MessageBox.Show(trust.ToString());
        }

       
    }
}
