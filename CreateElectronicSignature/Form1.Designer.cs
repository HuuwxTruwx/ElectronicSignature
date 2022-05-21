namespace CreateElectronicSignature
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.button2 = new System.Windows.Forms.Button();
            this.panelChild = new Krypton.Toolkit.KryptonPanel();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChild)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 397);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 127);
            this.button1.TabIndex = 2;
            this.button1.Text = "  SignPDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.button3);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Controls.Add(this.button2);
            this.kryptonPanel1.Controls.Add(this.button1);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(160, 836);
            this.kryptonPanel1.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(221)))), ((int)(((byte)(119)))));
            this.kryptonPanel1.TabIndex = 20;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.kryptonPanel2.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(160, 125);
            this.kryptonPanel2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(0, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(160, 127);
            this.button2.TabIndex = 3;
            this.button2.Text = "       Key";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panelChild
            // 
            this.panelChild.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChild.Location = new System.Drawing.Point(160, 0);
            this.panelChild.Name = "panelChild";
            this.panelChild.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.panelChild.Size = new System.Drawing.Size(1157, 836);
            this.panelChild.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelChild.TabIndex = 21;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(46)))), ((int)(((byte)(52)))), ((int)(((byte)(63)))));
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Palatino Linotype", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Black;
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(0, 264);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(160, 127);
            this.button3.TabIndex = 6;
            this.button3.Text = "  Certificate";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 836);
            this.Controls.Add(this.panelChild);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Electronic Signature";
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelChild)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Button button2;
        private Krypton.Toolkit.KryptonPanel panelChild;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Button button3;
    }
}