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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        RSA rsa = RSA.Instance;
        

        private void kryptonButton1_Click(object sender, EventArgs e)
        {
            int d = int.Parse(durationBox.Text);
            rsa.LoadKeyFromXML(keyPathBox.Text);
            rsa.MakeCert(nameBox.Text, rsa, d,passBox.Text);
        }

        private void kryptonButton2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            keyPathBox.Text = openFileDialog1.FileName;
        }

        
    }
}
