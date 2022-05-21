namespace CreateElectronicSignature
{
    partial class Form3
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
            this.kryptonPanel4 = new Krypton.Toolkit.KryptonPanel();
            this.VertifyButton = new Krypton.Toolkit.KryptonButton();
            this.vertifydataTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel5 = new Krypton.Toolkit.KryptonLabel();
            this.SignDataButton = new Krypton.Toolkit.KryptonButton();
            this.dataTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.signatureTextBox = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonLabel6 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonRichTextBox1 = new Krypton.Toolkit.KryptonRichTextBox();
            this.GeneraKeyButton = new Krypton.Toolkit.KryptonButton();
            this.LoadKeyButton = new Krypton.Toolkit.KryptonButton();
            this.SaveKeyButton = new Krypton.Toolkit.KryptonButton();
            this.publickeyText = new Krypton.Toolkit.KryptonRichTextBox();
            this.privatekeyText = new Krypton.Toolkit.KryptonRichTextBox();
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).BeginInit();
            this.kryptonPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPanel4
            // 
            this.kryptonPanel4.Controls.Add(this.VertifyButton);
            this.kryptonPanel4.Controls.Add(this.vertifydataTextBox);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel5);
            this.kryptonPanel4.Controls.Add(this.SignDataButton);
            this.kryptonPanel4.Controls.Add(this.dataTextBox);
            this.kryptonPanel4.Controls.Add(this.signatureTextBox);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel4.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel4.Location = new System.Drawing.Point(638, 13);
            this.kryptonPanel4.Name = "kryptonPanel4";
            this.kryptonPanel4.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel4.Size = new System.Drawing.Size(621, 608);
            this.kryptonPanel4.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel4.TabIndex = 35;
            // 
            // VertifyButton
            // 
            this.VertifyButton.Location = new System.Drawing.Point(469, 442);
            this.VertifyButton.Name = "VertifyButton";
            this.VertifyButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.VertifyButton.Size = new System.Drawing.Size(120, 46);
            this.VertifyButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.VertifyButton.StateCommon.Border.Rounding = 15F;
            this.VertifyButton.StateCommon.Border.Width = 1;
            this.VertifyButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VertifyButton.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.VertifyButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.VertifyButton.StatePressed.Border.Rounding = 15F;
            this.VertifyButton.StatePressed.Border.Width = 1;
            this.VertifyButton.TabIndex = 34;
            this.VertifyButton.Values.Text = "VertifyData";
            this.VertifyButton.Click += new System.EventHandler(this.VertifyButton_Click);
            // 
            // vertifydataTextBox
            // 
            this.vertifydataTextBox.Location = new System.Drawing.Point(16, 381);
            this.vertifydataTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.vertifydataTextBox.Name = "vertifydataTextBox";
            this.vertifydataTextBox.Size = new System.Drawing.Size(422, 165);
            this.vertifydataTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.vertifydataTextBox.StateCommon.Border.Rounding = 15F;
            this.vertifydataTextBox.StateCommon.Border.Width = 1;
            this.vertifydataTextBox.TabIndex = 29;
            this.vertifydataTextBox.Text = "";
            // 
            // kryptonLabel5
            // 
            this.kryptonLabel5.Location = new System.Drawing.Point(16, 355);
            this.kryptonLabel5.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel5.Name = "kryptonLabel5";
            this.kryptonLabel5.Size = new System.Drawing.Size(103, 31);
            this.kryptonLabel5.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel5.TabIndex = 29;
            this.kryptonLabel5.Values.Text = "CheckData";
            // 
            // SignDataButton
            // 
            this.SignDataButton.Location = new System.Drawing.Point(469, 252);
            this.SignDataButton.Name = "SignDataButton";
            this.SignDataButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SignDataButton.Size = new System.Drawing.Size(120, 51);
            this.SignDataButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignDataButton.StateCommon.Border.Rounding = 15F;
            this.SignDataButton.StateCommon.Border.Width = 1;
            this.SignDataButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SignDataButton.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.SignDataButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SignDataButton.StatePressed.Border.Rounding = 15F;
            this.SignDataButton.StatePressed.Border.Width = 1;
            this.SignDataButton.TabIndex = 28;
            this.SignDataButton.Values.Text = "SignData";
            this.SignDataButton.Click += new System.EventHandler(this.SignDataButton_Click);
            // 
            // dataTextBox
            // 
            this.dataTextBox.Location = new System.Drawing.Point(16, 37);
            this.dataTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.dataTextBox.Name = "dataTextBox";
            this.dataTextBox.Size = new System.Drawing.Size(422, 136);
            this.dataTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dataTextBox.StateCommon.Border.Rounding = 15F;
            this.dataTextBox.StateCommon.Border.Width = 1;
            this.dataTextBox.TabIndex = 24;
            this.dataTextBox.Text = "";
            // 
            // signatureTextBox
            // 
            this.signatureTextBox.Location = new System.Drawing.Point(16, 208);
            this.signatureTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.signatureTextBox.Name = "signatureTextBox";
            this.signatureTextBox.Size = new System.Drawing.Size(422, 132);
            this.signatureTextBox.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.signatureTextBox.StateCommon.Border.Rounding = 15F;
            this.signatureTextBox.StateCommon.Border.Width = 1;
            this.signatureTextBox.TabIndex = 26;
            this.signatureTextBox.Text = "";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.Location = new System.Drawing.Point(16, 182);
            this.kryptonLabel3.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(92, 31);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel3.TabIndex = 24;
            this.kryptonLabel3.Values.Text = "Signature";
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.Location = new System.Drawing.Point(16, 10);
            this.kryptonLabel4.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(51, 31);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel4.TabIndex = 25;
            this.kryptonLabel4.Values.Text = "Data";
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.kryptonLabel6);
            this.kryptonPanel3.Controls.Add(this.kryptonRichTextBox1);
            this.kryptonPanel3.Controls.Add(this.GeneraKeyButton);
            this.kryptonPanel3.Controls.Add(this.LoadKeyButton);
            this.kryptonPanel3.Controls.Add(this.SaveKeyButton);
            this.kryptonPanel3.Controls.Add(this.publickeyText);
            this.kryptonPanel3.Controls.Add(this.privatekeyText);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel3.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel3.Location = new System.Drawing.Point(50, 13);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.kryptonPanel3.Size = new System.Drawing.Size(507, 728);
            this.kryptonPanel3.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.kryptonPanel3.TabIndex = 34;
            // 
            // kryptonLabel6
            // 
            this.kryptonLabel6.Location = new System.Drawing.Point(202, 513);
            this.kryptonLabel6.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel6.Name = "kryptonLabel6";
            this.kryptonLabel6.Size = new System.Drawing.Size(6, 2);
            this.kryptonLabel6.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel6.TabIndex = 33;
            this.kryptonLabel6.Values.Text = "";
            // 
            // kryptonRichTextBox1
            // 
            this.kryptonRichTextBox1.Location = new System.Drawing.Point(221, 423);
            this.kryptonRichTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonRichTextBox1.Name = "kryptonRichTextBox1";
            this.kryptonRichTextBox1.Size = new System.Drawing.Size(148, 48);
            this.kryptonRichTextBox1.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kryptonRichTextBox1.StateCommon.Border.Rounding = 15F;
            this.kryptonRichTextBox1.StateCommon.Border.Width = 1;
            this.kryptonRichTextBox1.TabIndex = 32;
            this.kryptonRichTextBox1.Text = "";
            // 
            // GeneraKeyButton
            // 
            this.GeneraKeyButton.Location = new System.Drawing.Point(35, 423);
            this.GeneraKeyButton.Name = "GeneraKeyButton";
            this.GeneraKeyButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.GeneraKeyButton.Size = new System.Drawing.Size(117, 43);
            this.GeneraKeyButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GeneraKeyButton.StateCommon.Border.Rounding = 15F;
            this.GeneraKeyButton.StateCommon.Border.Width = 1;
            this.GeneraKeyButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GeneraKeyButton.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.GeneraKeyButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.GeneraKeyButton.StatePressed.Border.Rounding = 15F;
            this.GeneraKeyButton.StatePressed.Border.Width = 1;
            this.GeneraKeyButton.TabIndex = 31;
            this.GeneraKeyButton.Values.Text = "GeneraKey";
            this.GeneraKeyButton.Click += new System.EventHandler(this.GeneraKeyButton_Click);
            // 
            // LoadKeyButton
            // 
            this.LoadKeyButton.Location = new System.Drawing.Point(36, 498);
            this.LoadKeyButton.Name = "LoadKeyButton";
            this.LoadKeyButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.LoadKeyButton.Size = new System.Drawing.Size(116, 43);
            this.LoadKeyButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoadKeyButton.StateCommon.Border.Rounding = 15F;
            this.LoadKeyButton.StateCommon.Border.Width = 1;
            this.LoadKeyButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LoadKeyButton.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.LoadKeyButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.LoadKeyButton.StatePressed.Border.Rounding = 15F;
            this.LoadKeyButton.StatePressed.Border.Width = 1;
            this.LoadKeyButton.TabIndex = 30;
            this.LoadKeyButton.Values.Text = "LoadKey";
            this.LoadKeyButton.Click += new System.EventHandler(this.LoadKeyButton_Click);
            // 
            // SaveKeyButton
            // 
            this.SaveKeyButton.Location = new System.Drawing.Point(372, 428);
            this.SaveKeyButton.Name = "SaveKeyButton";
            this.SaveKeyButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.SaveKeyButton.Size = new System.Drawing.Size(117, 43);
            this.SaveKeyButton.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveKeyButton.StateCommon.Border.Rounding = 15F;
            this.SaveKeyButton.StateCommon.Border.Width = 1;
            this.SaveKeyButton.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SaveKeyButton.StatePressed.Border.Color1 = System.Drawing.Color.Cyan;
            this.SaveKeyButton.StatePressed.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.SaveKeyButton.StatePressed.Border.Rounding = 15F;
            this.SaveKeyButton.StatePressed.Border.Width = 1;
            this.SaveKeyButton.TabIndex = 29;
            this.SaveKeyButton.Values.Text = "SaveKey";
            this.SaveKeyButton.Click += new System.EventHandler(this.SaveKeyButton_Click);
            // 
            // publickeyText
            // 
            this.publickeyText.Location = new System.Drawing.Point(14, 37);
            this.publickeyText.Name = "publickeyText";
            this.publickeyText.Size = new System.Drawing.Size(475, 151);
            this.publickeyText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.publickeyText.StateCommon.Border.Rounding = 15F;
            this.publickeyText.StateCommon.Border.Width = 1;
            this.publickeyText.TabIndex = 21;
            this.publickeyText.Text = "";
            // 
            // privatekeyText
            // 
            this.privatekeyText.Location = new System.Drawing.Point(14, 219);
            this.privatekeyText.Margin = new System.Windows.Forms.Padding(0);
            this.privatekeyText.Name = "privatekeyText";
            this.privatekeyText.Size = new System.Drawing.Size(475, 151);
            this.privatekeyText.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.privatekeyText.StateCommon.Border.Rounding = 15F;
            this.privatekeyText.StateCommon.Border.Width = 1;
            this.privatekeyText.TabIndex = 23;
            this.privatekeyText.Text = "";
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.Location = new System.Drawing.Point(14, 10);
            this.kryptonLabel1.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(99, 31);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel1.TabIndex = 20;
            this.kryptonLabel1.Values.Text = "Public Key";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.Location = new System.Drawing.Point(14, 193);
            this.kryptonLabel2.Margin = new System.Windows.Forms.Padding(0);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(105, 31);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kryptonLabel2.TabIndex = 22;
            this.kryptonLabel2.Values.Text = "Private Key";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1302, 832);
            this.Controls.Add(this.kryptonPanel4);
            this.Controls.Add(this.kryptonPanel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel4)).EndInit();
            this.kryptonPanel4.ResumeLayout(false);
            this.kryptonPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            this.kryptonPanel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Krypton.Toolkit.KryptonPanel kryptonPanel4;
        private Krypton.Toolkit.KryptonButton VertifyButton;
        private Krypton.Toolkit.KryptonRichTextBox vertifydataTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel5;
        private Krypton.Toolkit.KryptonButton SignDataButton;
        private Krypton.Toolkit.KryptonRichTextBox dataTextBox;
        private Krypton.Toolkit.KryptonRichTextBox signatureTextBox;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton GeneraKeyButton;
        private Krypton.Toolkit.KryptonButton LoadKeyButton;
        private Krypton.Toolkit.KryptonButton SaveKeyButton;
        private Krypton.Toolkit.KryptonRichTextBox publickeyText;
        private Krypton.Toolkit.KryptonRichTextBox privatekeyText;
        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private OpenFileDialog openFileDialog1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel6;
        private Krypton.Toolkit.KryptonRichTextBox kryptonRichTextBox1;
    }
}