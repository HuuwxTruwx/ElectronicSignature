namespace CreateElectronicSignature
{
    partial class Form4
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
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonButton1 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.keyPathBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonButton2 = new Krypton.Toolkit.KryptonButton();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.passBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.durationBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.nameBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonButton1);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel1.Controls.Add(this.keyPathBox);
            this.kryptonPanel1.Controls.Add(this.kryptonButton2);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel1.Controls.Add(this.passBox);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel1.Controls.Add(this.durationBox);
            this.kryptonPanel1.Controls.Add(this.nameBox);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.kryptonPanel1.Location = new System.Drawing.Point(808, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(310, 685);
            this.kryptonPanel1.TabIndex = 0;
            // 
            // kryptonButton1
            // 
            this.kryptonButton1.Location = new System.Drawing.Point(58, 428);
            this.kryptonButton1.Name = "kryptonButton1";
            this.kryptonButton1.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton1.Size = new System.Drawing.Size(169, 70);
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
            this.kryptonButton1.TabIndex = 50;
            this.kryptonButton1.Values.Text = "Create";
            this.kryptonButton1.Click += new System.EventHandler(this.kryptonButton1_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(112, 111);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(59, 31);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 49;
            this.kryptonLabel4.Values.Text = "Years";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(24, 234);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(78, 31);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 48;
            this.kryptonLabel3.Values.Text = "Rsa Key";
            // 
            // keyPathBox
            // 
            this.keyPathBox.Location = new System.Drawing.Point(24, 265);
            this.keyPathBox.Margin = new System.Windows.Forms.Padding(0);
            this.keyPathBox.Name = "keyPathBox";
            this.keyPathBox.Size = new System.Drawing.Size(188, 39);
            this.keyPathBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.keyPathBox.StateCommon.Border.Rounding = 15F;
            this.keyPathBox.StateCommon.Border.Width = 1;
            this.keyPathBox.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.keyPathBox.TabIndex = 47;
            this.keyPathBox.Text = "";
            // 
            // kryptonButton2
            // 
            this.kryptonButton2.Location = new System.Drawing.Point(227, 265);
            this.kryptonButton2.Name = "kryptonButton2";
            this.kryptonButton2.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonButton2.Size = new System.Drawing.Size(81, 39);
            this.kryptonButton2.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StateCommon.Border.Rounding = 15F;
            this.kryptonButton2.StateCommon.Border.Width = 1;
            this.kryptonButton2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonButton2.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.kryptonButton2.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonButton2.StatePressed.Border.Rounding = 15F;
            this.kryptonButton2.StatePressed.Border.Width = 1;
            this.kryptonButton2.TabIndex = 46;
            this.kryptonButton2.Values.Text = "Select";
            this.kryptonButton2.Click += new System.EventHandler(this.kryptonButton2_Click);
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(24, 158);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(184, 31);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 45;
            this.kryptonLabel6.Values.Text = "Certificate Password";
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(24, 189);
            this.passBox.Margin = new System.Windows.Forms.Padding(0);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(188, 39);
            this.passBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.passBox.StateCommon.Border.Rounding = 15F;
            this.passBox.StateCommon.Border.Width = 1;
            this.passBox.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passBox.TabIndex = 44;
            this.passBox.Text = "";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(24, 80);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(86, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 43;
            this.kryptonLabel2.Values.Text = "Duration";
            // 
            // durationBox
            // 
            this.durationBox.Location = new System.Drawing.Point(24, 111);
            this.durationBox.Margin = new System.Windows.Forms.Padding(0);
            this.durationBox.Name = "durationBox";
            this.durationBox.Size = new System.Drawing.Size(78, 39);
            this.durationBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.durationBox.StateCommon.Border.Rounding = 15F;
            this.durationBox.StateCommon.Border.Width = 1;
            this.durationBox.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.durationBox.TabIndex = 42;
            this.durationBox.Text = "5";
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(24, 42);
            this.nameBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(188, 39);
            this.nameBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.nameBox.StateCommon.Border.Rounding = 15F;
            this.nameBox.StateCommon.Border.Width = 1;
            this.nameBox.StateCommon.Content.Font = new System.Drawing.Font("Lucida Sans Unicode", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameBox.TabIndex = 40;
            this.nameBox.Text = "";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(24, 17);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(61, 31);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 38;
            this.kryptonLabel1.Values.Text = "Name";
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(808, 685);
            this.kryptonPanel2.StateCommon.Color1 = System.Drawing.Color.Silver;
            this.kryptonPanel2.TabIndex = 1;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 685);
            this.Controls.Add(this.kryptonPanel2);
            this.Controls.Add(this.kryptonPanel1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonRichTextBox keyPathBox;
        private Krypton.Toolkit.KryptonButton kryptonButton2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonRichTextBox passBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonRichTextBox durationBox;
        private Krypton.Toolkit.KryptonRichTextBox nameBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonButton kryptonButton1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private OpenFileDialog openFileDialog1;
    }
}