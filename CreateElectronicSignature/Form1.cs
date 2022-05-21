using System.Text;

namespace CreateElectronicSignature
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            Form3 form3 = new Form3();
            openChildFormInPanel(form3);
        }    
        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            childForm.Size = panelChild.Size;
            panelChild.Controls.Add(childForm);
            panelChild.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
       

        private void button3_Click(object sender, EventArgs e)
        {
            //rsa.LoadKeyFromXML(richTextBox1.Text);
            //richTextBox1.Text = rsa.GetPublicAndPrivateKey();
        }
     
       
        private void button1_Click(object sender, EventArgs e)
        {
           
            Form2 form2 = new Form2();
            
            openChildFormInPanel(form2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            openChildFormInPanel(form3);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            openChildFormInPanel(form4);
        }
    }
}