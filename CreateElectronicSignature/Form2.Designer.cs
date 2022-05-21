namespace CreateElectronicSignature
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel7 = new Krypton.Toolkit.KryptonLabel();
            this.SignImagePanel = new Krypton.Toolkit.KryptonPanel();
            this.SignButton = new Krypton.Toolkit.KryptonButton();
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonRichTextBox4 = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox2 = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox3 = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.PickFilePanel = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox5 = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.dataTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.selectFileButton = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.SignLocationPanel = new System.Windows.Forms.Panel();
            this.pdfDocumentView1 = new Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignImagePanel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickFilePanel)).BeginInit();
            this.PickFilePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonLabel7);
            this.kryptonPanel1.Controls.Add(this.SignImagePanel);
            this.kryptonPanel1.Controls.Add(this.SignButton);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel4);
            this.kryptonPanel1.Controls.Add(this.PickFilePanel);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(831, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(326, 954);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonLabel7
            // 
            this.kryptonLabel7.Location = new System.Drawing.Point(111, 472);
            this.kryptonLabel7.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel7.Name = "kryptonLabel7";
            this.kryptonLabel7.Size = new System.Drawing.Size(94, 31);
            this.kryptonLabel7.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel7.TabIndex = 40;
            this.kryptonLabel7.Values.Text = "Sign Here";
            // 
            // SignImagePanel
            // 
            this.SignImagePanel.Location = new System.Drawing.Point(3, 506);
            this.SignImagePanel.Name = "SignImagePanel";
            this.SignImagePanel.Size = new System.Drawing.Size(323, 212);
            this.SignImagePanel.StateCommon.Color1 = System.Drawing.Color.White;
            this.SignImagePanel.TabIndex = 38;
            this.SignImagePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.kryptonPanel3_Paint);
            this.SignImagePanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel3_MouseDown);
            this.SignImagePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kryptonPanel3_MouseMove);
            // 
            // SignButton
            // 
            this.SignButton.Location = new System.Drawing.Point(111, 733);
            this.SignButton.Name = "SignButton";
            this.SignButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SignButton.Size = new System.Drawing.Size(123, 47);
            this.SignButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignButton.StateCommon.Border.Rounding = 15F;
            this.SignButton.StateCommon.Border.Width = 1;
            this.SignButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignButton.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.SignButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignButton.StatePressed.Border.Rounding = 15F;
            this.SignButton.StatePressed.Border.Width = 1;
            this.SignButton.TabIndex = 37;
            this.SignButton.Values.Text = "Sign";
            this.SignButton.Click += new System.EventHandler(this.SignButton_Click);
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.kryptonRichTextBox4);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel4.Controls.Add(this.kryptonRichTextBox2);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel4.Controls.Add(this.kryptonRichTextBox3);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel4.Location = new System.Drawing.Point(0, 234);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.Size = new System.Drawing.Size(326, 221);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.kryptonPanel4.TabIndex = 1;
            // 
            // kryptonRichTextBox4
            // 
            this.kryptonRichTextBox4.Location = new System.Drawing.Point(15, 171);
            this.kryptonRichTextBox4.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonRichTextBox4.Name = "kryptonRichTextBox4";
            this.kryptonRichTextBox4.Size = new System.Drawing.Size(284, 39);
            this.kryptonRichTextBox4.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBox4.StateCommon.Border.Rounding = 15F;
            this.kryptonRichTextBox4.StateCommon.Border.Width = 1;
            this.kryptonRichTextBox4.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonRichTextBox4.TabIndex = 39;
            this.kryptonRichTextBox4.Text = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(15, 146);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(149, 31);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 38;
            this.kryptonLabel5.Values.Text = "Signer\'s Contact";
            // 
            // kryptonRichTextBox2
            // 
            this.kryptonRichTextBox2.Location = new System.Drawing.Point(15, 98);
            this.kryptonRichTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonRichTextBox2.Name = "kryptonRichTextBox2";
            this.kryptonRichTextBox2.Size = new System.Drawing.Size(284, 39);
            this.kryptonRichTextBox2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBox2.StateCommon.Border.Rounding = 15F;
            this.kryptonRichTextBox2.StateCommon.Border.Width = 1;
            this.kryptonRichTextBox2.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonRichTextBox2.TabIndex = 37;
            this.kryptonRichTextBox2.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(15, 73);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(73, 31);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 36;
            this.kryptonLabel3.Values.Text = "Reason";
            // 
            // kryptonRichTextBox3
            // 
            this.kryptonRichTextBox3.Location = new System.Drawing.Point(15, 29);
            this.kryptonRichTextBox3.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonRichTextBox3.Name = "kryptonRichTextBox3";
            this.kryptonRichTextBox3.Size = new System.Drawing.Size(284, 39);
            this.kryptonRichTextBox3.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBox3.StateCommon.Border.Rounding = 15F;
            this.kryptonRichTextBox3.StateCommon.Border.Width = 1;
            this.kryptonRichTextBox3.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonRichTextBox3.TabIndex = 35;
            this.kryptonRichTextBox3.Text = "";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(15, 4);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(133, 31);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 34;
            this.kryptonLabel4.Values.Text = "Signer\'s Name";
            // 
            // PickFilePanel
            // 
            this.PickFilePanel.Controls.Add(this.kryptonLabel6);
            this.PickFilePanel.Controls.Add(this.kryptonRichTextBox5);
            this.PickFilePanel.Controls.Add(this.kryptonLabel2);
            this.PickFilePanel.Controls.Add(this.kryptonRichTextBox1);
            this.PickFilePanel.Controls.Add(this.kryptonButton1);
            this.PickFilePanel.Controls.Add(this.dataTextBox);
            this.PickFilePanel.Controls.Add(this.selectFileButton);
            this.PickFilePanel.Controls.Add(this.kryptonLabel1);
            this.PickFilePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.PickFilePanel.Location = new System.Drawing.Point(0, 0);
            this.PickFilePanel.Name = "PickFilePanel";
            this.PickFilePanel.Size = new System.Drawing.Size(326, 234);
            this.PickFilePanel.StateCommon.Color1 = System.Drawing.SystemColors.ActiveCaption;
            this.PickFilePanel.TabIndex = 0;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(15, 150);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(184, 31);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 37;
            this.kryptonLabel6.Values.Text = "Certificate Password";
            // 
            // kryptonRichTextBox5
            // 
            this.kryptonRichTextBox5.Location = new System.Drawing.Point(15, 181);
            this.kryptonRichTextBox5.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonRichTextBox5.Name = "kryptonRichTextBox5";
            this.kryptonRichTextBox5.Size = new System.Drawing.Size(188, 39);
            this.kryptonRichTextBox5.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBox5.StateCommon.Border.Rounding = 15F;
            this.kryptonRichTextBox5.StateCommon.Border.Width = 1;
            this.kryptonRichTextBox5.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonRichTextBox5.TabIndex = 36;
            this.kryptonRichTextBox5.Text = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(15, 72);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(99, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 34;
            this.kryptonLabel2.Values.Text = "Certificate";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(15, 103);
            this.kryptonRichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(188, 39);
            this.kryptonRichTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBox1.StateCommon.Border.Rounding = 15F;
            this.kryptonRichTextBox1.StateCommon.Border.Width = 1;
            this.kryptonRichTextBox1.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonRichTextBox1.TabIndex = 33;
            this.kryptonRichTextBox1.Text = "";
            this.kryptonRichTextBox1.TextChanged += new System.EventHandler(this.kryptonRichTextBox1_TextChanged);
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(218, 103);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(81, 39);
            this.kryptonButton1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StateCommon.Border.Rounding = 15F;
            this.kryptonButton1.StateCommon.Border.Width = 1;
            this.kryptonButton1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton1.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.kryptonButton1.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton1.StatePressed.Border.Rounding = 15F;
            this.kryptonButton1.StatePressed.Border.Width = 1;
            this.kryptonButton1.TabIndex = 32;
            this.kryptonButton1.Values.Text = "Select";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(15, 34);
            this.dataTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(188, 39);
            this.dataTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataTextBox.StateCommon.Border.Rounding = 15F;
            this.dataTextBox.StateCommon.Border.Width = 1;
            this.dataTextBox.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dataTextBox.TabIndex = 30;
            this.dataTextBox.Text = "";
            // 
            // selectFileButton
            // 
            this.selectFileButton.Location = new System.Drawing.Point(218, 34);
            this.selectFileButton.Name = "selectFileButton";
            this.selectFileButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.selectFileButton.Size = new System.Drawing.Size(81, 39);
            this.selectFileButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.selectFileButton.StateCommon.Border.Rounding = 15F;
            this.selectFileButton.StateCommon.Border.Width = 1;
            this.selectFileButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.selectFileButton.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.selectFileButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.selectFileButton.StatePressed.Border.Rounding = 15F;
            this.selectFileButton.StatePressed.Border.Width = 1;
            this.selectFileButton.TabIndex = 29;
            this.selectFileButton.Values.Text = "Select";
            this.selectFileButton.Click += new System.EventHandler(this.selectFileButton_Click);
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(15, 9);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(41, 31);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 21;
            this.kryptonLabel1.Values.Text = "File";
            this.kryptonLabel1.Click += new System.EventHandler(this.kryptonLabel1_Click);
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.SignLocationPanel);
            this.kryptonPanel2.Controls.Add(this.pdfDocumentView1);
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(831, 954);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel2.TabIndex = 1;
            // 
            // SignLocationPanel
            // 
            this.SignLocationPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.SignLocationPanel.Location = new System.Drawing.Point(194, 447);
            this.SignLocationPanel.Name = "SignLocationPanel";
            this.SignLocationPanel.Size = new System.Drawing.Size(157, 67);
            this.SignLocationPanel.TabIndex = 1;
            this.SignLocationPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.SignLocationPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pdfDocumentView1
            // 
            this.pdfDocumentView1.AutoScroll = true;
            this.pdfDocumentView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(237)))), ((int)(((byte)(237)))));
            this.pdfDocumentView1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.pdfDocumentView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfDocumentView1.EnableContextMenu = true;
            this.pdfDocumentView1.HorizontalScrollOffset = 0;
            this.pdfDocumentView1.IsTextSearchEnabled = true;
            this.pdfDocumentView1.IsTextSelectionEnabled = true;
            this.pdfDocumentView1.Location = new System.Drawing.Point(0, 0);
            messageBoxSettings1.EnableNotification = true;
            this.pdfDocumentView1.MessageBoxSettings = messageBoxSettings1;
            this.pdfDocumentView1.MinimumZoomPercentage = 50;
            this.pdfDocumentView1.Name = "pdfDocumentView1";
            this.pdfDocumentView1.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            this.pdfDocumentView1.PrinterSettings = pdfViewerPrinterSettings1;
            this.pdfDocumentView1.ReferencePath = null;
            this.pdfDocumentView1.ScrollDisplacementValue = 0;
            this.pdfDocumentView1.ShowHorizontalScrollBar = true;
            this.pdfDocumentView1.ShowVerticalScrollBar = true;
            this.pdfDocumentView1.Size = new System.Drawing.Size(831, 954);
            this.pdfDocumentView1.SpaceBetweenPages = 8;
            this.pdfDocumentView1.TabIndex = 0;
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfDocumentView1.TextSearchSettings = textSearchSettings1;
            this.pdfDocumentView1.ThemeName = "Default";
            this.pdfDocumentView1.VerticalScrollOffset = 0;
            this.pdfDocumentView1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfDocumentView1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.FitWidth;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 954);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SignImagePanel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PickFilePanel)).EndInit();
            this.PickFilePanel.ResumeLayout(false);
            this.PickFilePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonPanel PickFilePanel;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private OpenFileDialog openFileDialog1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton selectFileButton;
        private Krypton.Toolkit.KryptonRichTextBox dataTextBox;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Syncfusion.Windows.Forms.PdfViewer.PdfDocumentView pdfDocumentView1;
        private Krypton.Toolkit.KryptonButton SignButton;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox5;
        private Krypton.Toolkit.KryptonLabel kryptonLabel7;
        private Krypton.Toolkit.KryptonPanel SignImagePanel;
        private Panel SignLocationPanel;
        private OpenFileDialog openFileDialog2;
    }
}