
namespace BilgiYarışması_FormKamp
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonBaşla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelSoruNo = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.labelDoğruCevap = new System.Windows.Forms.Label();
            this.labelVerilenCevap = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelYanlışSayısı = new System.Windows.Forms.Label();
            this.labelDoğruSayısı = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.labelSüre = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button1.Location = new System.Drawing.Point(350, 212);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 84);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button2.Location = new System.Drawing.Point(594, 212);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 84);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button3.Location = new System.Drawing.Point(350, 322);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(154, 84);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button4.Location = new System.Drawing.Point(593, 322);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 84);
            this.button4.TabIndex = 3;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonBaşla
            // 
            this.buttonBaşla.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBaşla.Location = new System.Drawing.Point(49, 106);
            this.buttonBaşla.Name = "buttonBaşla";
            this.buttonBaşla.Size = new System.Drawing.Size(154, 84);
            this.buttonBaşla.TabIndex = 4;
            this.buttonBaşla.Text = "BAŞLAT";
            this.buttonBaşla.UseVisualStyleBackColor = true;
            this.buttonBaşla.Click += new System.EventHandler(this.buttonBaşla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(59, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "SORU:";
            // 
            // labelSoruNo
            // 
            this.labelSoruNo.AutoSize = true;
            this.labelSoruNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSoruNo.Location = new System.Drawing.Point(133, 47);
            this.labelSoruNo.Name = "labelSoruNo";
            this.labelSoruNo.Size = new System.Drawing.Size(24, 25);
            this.labelSoruNo.TabIndex = 6;
            this.labelSoruNo.Text = "0";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.richTextBox1.Location = new System.Drawing.Point(355, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 139);
            this.richTextBox1.TabIndex = 7;
            this.richTextBox1.Text = "";
            // 
            // labelDoğruCevap
            // 
            this.labelDoğruCevap.AutoSize = true;
            this.labelDoğruCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelDoğruCevap.Location = new System.Drawing.Point(163, 16);
            this.labelDoğruCevap.Name = "labelDoğruCevap";
            this.labelDoğruCevap.Size = new System.Drawing.Size(21, 20);
            this.labelDoğruCevap.TabIndex = 8;
            this.labelDoğruCevap.Text = "...";
            // 
            // labelVerilenCevap
            // 
            this.labelVerilenCevap.AutoSize = true;
            this.labelVerilenCevap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.labelVerilenCevap.Location = new System.Drawing.Point(163, 44);
            this.labelVerilenCevap.Name = "labelVerilenCevap";
            this.labelVerilenCevap.Size = new System.Drawing.Size(21, 20);
            this.labelVerilenCevap.TabIndex = 9;
            this.labelVerilenCevap.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelDoğruSayısı);
            this.groupBox1.Controls.Add(this.labelYanlışSayısı);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.groupBox1.Location = new System.Drawing.Point(781, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 188);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Puan Tablosu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(40, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "DOĞRU:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(40, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 25);
            this.label3.TabIndex = 1;
            this.label3.Text = "YANLIŞ:";
            // 
            // labelYanlışSayısı
            // 
            this.labelYanlışSayısı.AutoSize = true;
            this.labelYanlışSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelYanlışSayısı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelYanlışSayısı.Location = new System.Drawing.Point(136, 95);
            this.labelYanlışSayısı.Name = "labelYanlışSayısı";
            this.labelYanlışSayısı.Size = new System.Drawing.Size(23, 25);
            this.labelYanlışSayısı.TabIndex = 2;
            this.labelYanlışSayısı.Text = "0";
            // 
            // labelDoğruSayısı
            // 
            this.labelDoğruSayısı.AutoSize = true;
            this.labelDoğruSayısı.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelDoğruSayısı.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelDoğruSayısı.Location = new System.Drawing.Point(136, 49);
            this.labelDoğruSayısı.Name = "labelDoğruSayısı";
            this.labelDoğruSayısı.Size = new System.Drawing.Size(23, 25);
            this.labelDoğruSayısı.TabIndex = 2;
            this.labelDoğruSayısı.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(15, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Doğru Cevap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(15, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Verilen Cevap:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.labelVerilenCevap);
            this.panel1.Controls.Add(this.labelDoğruCevap);
            this.panel1.Location = new System.Drawing.Point(25, 258);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 93);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(820, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Süre:";
            // 
            // labelSüre
            // 
            this.labelSüre.AutoSize = true;
            this.labelSüre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSüre.Location = new System.Drawing.Point(899, 312);
            this.labelSüre.Name = "labelSüre";
            this.labelSüre.Size = new System.Drawing.Size(34, 25);
            this.labelSüre.TabIndex = 15;
            this.labelSüre.Text = "20";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1091, 561);
            this.Controls.Add(this.labelSüre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.labelSoruNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBaşla);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonBaşla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelSoruNo;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label labelDoğruCevap;
        private System.Windows.Forms.Label labelVerilenCevap;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelDoğruSayısı;
        private System.Windows.Forms.Label labelYanlışSayısı;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelSüre;
        private System.Windows.Forms.Timer timer1;
    }
}

