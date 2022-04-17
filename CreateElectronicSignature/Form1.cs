using System.Text;

namespace CreateElectronicSignature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        RSA rsa = RSA.Instance;
        byte[] sign;
        private void button1_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(richTextBox1.Text);

            sign = rsa.GenarateSignature(data);
            richTextBox4.Text = Encoding.ASCII.GetString(sign);          

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] data = Encoding.ASCII.GetBytes(richTextBox5.Text);
            //byte[] sign = Encoding.ASCII.GetBytes(richTextBox4.Text);
            bool trust = rsa.VerifySignature(data, sign);
            MessageBox.Show(trust.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //rsa.LoadKeyFromXML(richTextBox1.Text);
            //richTextBox1.Text = rsa.GetPublicAndPrivateKey();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rsa.SaveKeyToXML();
        }

        private void button5_Click(object sender, EventArgs e)
        {          
            rsa.LoadKeyFromXML();
            richTextBox2.Text =rsa.GetPublicKeyXML();
            richTextBox3.Text = rsa.GetPrivateKeyXML();
            
        }

       

        private void button3_Click_1(object sender, EventArgs e)
        {
            rsa.GenerateKeys();
          
            
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            rsa.MakeCert();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SignPdf signPdf = new SignPdf();
            signPdf.Sign2();
        }
    }
}