namespace İF_ELSE_HESAPLAMA_4_1473
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSayı1 = new System.Windows.Forms.TextBox();
            this.txtSayı2 = new System.Windows.Forms.TextBox();
            this.rbTopla = new System.Windows.Forms.RadioButton();
            this.rbCıkar = new System.Windows.Forms.RadioButton();
            this.rbCarp = new System.Windows.Forms.RadioButton();
            this.rbBol = new System.Windows.Forms.RadioButton();
            this.btnHsapla = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "SAYI1=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "SAYI2=";
            // 
            // txtSayı1
            // 
            this.txtSayı1.Location = new System.Drawing.Point(116, 29);
            this.txtSayı1.Name = "txtSayı1";
            this.txtSayı1.Size = new System.Drawing.Size(100, 20);
            this.txtSayı1.TabIndex = 2;
            // 
            // txtSayı2
            // 
            this.txtSayı2.Location = new System.Drawing.Point(116, 80);
            this.txtSayı2.Name = "txtSayı2";
            this.txtSayı2.Size = new System.Drawing.Size(100, 20);
            this.txtSayı2.TabIndex = 3;
            // 
            // rbTopla
            // 
            this.rbTopla.AutoSize = true;
            this.rbTopla.Location = new System.Drawing.Point(39, 133);
            this.rbTopla.Name = "rbTopla";
            this.rbTopla.Size = new System.Drawing.Size(60, 17);
            this.rbTopla.TabIndex = 4;
            this.rbTopla.TabStop = true;
            this.rbTopla.Text = "TOPLA";
            this.rbTopla.UseVisualStyleBackColor = true;
            // 
            // rbCıkar
            // 
            this.rbCıkar.AutoSize = true;
            this.rbCıkar.Location = new System.Drawing.Point(159, 133);
            this.rbCıkar.Name = "rbCıkar";
            this.rbCıkar.Size = new System.Drawing.Size(57, 17);
            this.rbCıkar.TabIndex = 5;
            this.rbCıkar.TabStop = true;
            this.rbCıkar.Text = "ÇIKAR";
            this.rbCıkar.UseVisualStyleBackColor = true;
            // 
            // rbCarp
            // 
            this.rbCarp.AutoSize = true;
            this.rbCarp.Location = new System.Drawing.Point(39, 189);
            this.rbCarp.Name = "rbCarp";
            this.rbCarp.Size = new System.Drawing.Size(54, 17);
            this.rbCarp.TabIndex = 6;
            this.rbCarp.TabStop = true;
            this.rbCarp.Text = "ÇARP";
            this.rbCarp.UseVisualStyleBackColor = true;
            // 
            // rbBol
            // 
            this.rbBol.AutoSize = true;
            this.rbBol.Location = new System.Drawing.Point(159, 189);
            this.rbBol.Name = "rbBol";
            this.rbBol.Size = new System.Drawing.Size(46, 17);
            this.rbBol.TabIndex = 7;
            this.rbBol.TabStop = true;
            this.rbBol.Text = "BÖL";
            this.rbBol.UseVisualStyleBackColor = true;
            // 
            // btnHsapla
            // 
            this.btnHsapla.Location = new System.Drawing.Point(39, 235);
            this.btnHsapla.Name = "btnHsapla";
            this.btnHsapla.Size = new System.Drawing.Size(177, 59);
            this.btnHsapla.TabIndex = 8;
            this.btnHsapla.Text = "HESAPLAMA";
            this.btnHsapla.UseVisualStyleBackColor = true;
            this.btnHsapla.Click += new System.EventHandler(this.btnHsapla_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(73, 310);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(87, 25);
            this.lblSonuc.TabIndex = 9;
            this.lblSonuc.Text = "SONUÇ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(255, 358);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnHsapla);
            this.Controls.Add(this.rbBol);
            this.Controls.Add(this.rbCarp);
            this.Controls.Add(this.rbCıkar);
            this.Controls.Add(this.rbTopla);
            this.Controls.Add(this.txtSayı2);
            this.Controls.Add(this.txtSayı1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSayı1;
        private System.Windows.Forms.TextBox txtSayı2;
        private System.Windows.Forms.RadioButton rbTopla;
        private System.Windows.Forms.RadioButton rbCıkar;
        private System.Windows.Forms.RadioButton rbCarp;
        private System.Windows.Forms.RadioButton rbBol;
        private System.Windows.Forms.Button btnHsapla;
        private System.Windows.Forms.Label lblSonuc;
    }
}

