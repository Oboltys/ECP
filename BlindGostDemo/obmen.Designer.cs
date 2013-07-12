namespace BlindGostDemo
{
    partial class obmen
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
            this.button1 = new System.Windows.Forms.Button();
            this.txtBIn = new System.Windows.Forms.TextBox();
            this.rTxtBOut = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBDecrypt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBPublicKey = new System.Windows.Forms.Label();
            this.txtBSecretKey = new System.Windows.Forms.Label();
            this.lblTest = new System.Windows.Forms.Label();
            this.txtBTest = new System.Windows.Forms.Label();
            this.numP = new System.Windows.Forms.TextBox();
            this.numG = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBIn
            // 
            this.txtBIn.Location = new System.Drawing.Point(13, 37);
            this.txtBIn.Name = "txtBIn";
            this.txtBIn.Size = new System.Drawing.Size(346, 20);
            this.txtBIn.TabIndex = 1;
            this.txtBIn.TextChanged += new System.EventHandler(this.txtBIn_TextChanged);
            // 
            // rTxtBOut
            // 
            this.rTxtBOut.Location = new System.Drawing.Point(13, 104);
            this.rTxtBOut.Name = "rTxtBOut";
            this.rTxtBOut.Size = new System.Drawing.Size(346, 20);
            this.rTxtBOut.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Текст сообщения";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Зашифрованное сообщение";
            // 
            // txtBDecrypt
            // 
            this.txtBDecrypt.Location = new System.Drawing.Point(13, 178);
            this.txtBDecrypt.Name = "txtBDecrypt";
            this.txtBDecrypt.Size = new System.Drawing.Size(346, 20);
            this.txtBDecrypt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Расшифрованное сообщение";
            // 
            // txtBPublicKey
            // 
            this.txtBPublicKey.AutoSize = true;
            this.txtBPublicKey.Location = new System.Drawing.Point(384, 18);
            this.txtBPublicKey.Name = "txtBPublicKey";
            this.txtBPublicKey.Size = new System.Drawing.Size(35, 13);
            this.txtBPublicKey.TabIndex = 7;
            this.txtBPublicKey.Text = "label4";
            // 
            // txtBSecretKey
            // 
            this.txtBSecretKey.AutoSize = true;
            this.txtBSecretKey.Location = new System.Drawing.Point(381, 85);
            this.txtBSecretKey.Name = "txtBSecretKey";
            this.txtBSecretKey.Size = new System.Drawing.Size(35, 13);
            this.txtBSecretKey.TabIndex = 8;
            this.txtBSecretKey.Text = "label4";
            // 
            // lblTest
            // 
            this.lblTest.AutoSize = true;
            this.lblTest.Location = new System.Drawing.Point(384, 178);
            this.lblTest.Name = "lblTest";
            this.lblTest.Size = new System.Drawing.Size(35, 13);
            this.lblTest.TabIndex = 9;
            this.lblTest.Text = "label4";
            // 
            // txtBTest
            // 
            this.txtBTest.AutoSize = true;
            this.txtBTest.Location = new System.Drawing.Point(387, 207);
            this.txtBTest.Name = "txtBTest";
            this.txtBTest.Size = new System.Drawing.Size(35, 13);
            this.txtBTest.TabIndex = 10;
            this.txtBTest.Text = "label4";
            // 
            // numP
            // 
            this.numP.Location = new System.Drawing.Point(384, 37);
            this.numP.Name = "numP";
            this.numP.Size = new System.Drawing.Size(100, 20);
            this.numP.TabIndex = 11;
            // 
            // numG
            // 
            this.numG.Location = new System.Drawing.Point(384, 104);
            this.numG.Name = "numG";
            this.numG.Size = new System.Drawing.Size(100, 20);
            this.numG.TabIndex = 12;
            // 
            // obmen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 318);
            this.Controls.Add(this.numG);
            this.Controls.Add(this.numP);
            this.Controls.Add(this.txtBTest);
            this.Controls.Add(this.lblTest);
            this.Controls.Add(this.txtBSecretKey);
            this.Controls.Add(this.txtBPublicKey);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBDecrypt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rTxtBOut);
            this.Controls.Add(this.txtBIn);
            this.Controls.Add(this.button1);
            this.Name = "obmen";
            this.Text = "obmen";
            this.Load += new System.EventHandler(this.obmen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtBIn;
        private System.Windows.Forms.TextBox rTxtBOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBDecrypt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label txtBPublicKey;
        private System.Windows.Forms.Label txtBSecretKey;
        private System.Windows.Forms.Label lblTest;
        private System.Windows.Forms.Label txtBTest;
        private System.Windows.Forms.TextBox numP;
        private System.Windows.Forms.TextBox numG;
    }
}