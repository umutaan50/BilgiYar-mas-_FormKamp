using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgiYarışması_FormKamp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruNo; 
        int doğruAdedi = 0;
        int yanlışAdedi = 0;
        int süre = 20;
        private void buttonBaşla_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            süre = 20;
            labelSüre.Text = süre.ToString();
            panel1.Visible = false;

            buttonBaşla.Text = "İlerle";
            soruNo = Convert.ToInt32(labelSoruNo.Text);
            soruNo++;
            
            labelSoruNo.Text = soruNo.ToString();
            button1.Enabled = true;
            button2.Enabled = true; 
            button3.Enabled = true;
            button4.Enabled = true;


            if (soruNo == 1)
            {
                richTextBox1.Text = "Mustafa Kemal kaç yılıda doğmuştur?";
                button1.Text = "1880";
                button2.Text = "1881";
                button3.Text = "1882";
                button4.Text = "1883";
                labelDoğruCevap.Text = "1881";
            }
            if (soruNo==2)
            {
                richTextBox1.Text = "Türkiye Cumhuriyeti kaç yılında kuruluştur?";
                button1.Text = "1920";
                button1.Text = "1921";
                button1.Text = "1922";
                button1.Text = "1923";
                labelDoğruCevap.Text = "1923";
            }
            if (soruNo==3)
            {
                richTextBox1.Text = "Türkiyede kaç adet il bulunmaktadır?";
                button1.Text = "81";
                button2.Text = "82";
                button3.Text = "83";
                button4.Text = "84";
                labelDoğruCevap.Text = "81";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            labelVerilenCevap.Text = button1.Text;
            if (labelDoğruCevap.Text==labelVerilenCevap.Text)
            {
                doğruAdedi++;
                labelDoğruSayısı.Text = doğruAdedi.ToString();
            }
            else
            {
                yanlışAdedi++;
                labelYanlışSayısı.Text = yanlışAdedi.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            labelVerilenCevap.Text = button2.Text;
            if (labelDoğruCevap.Text == labelVerilenCevap.Text)
            {
                doğruAdedi++;
                labelDoğruSayısı.Text = doğruAdedi.ToString();
            }
            else
            {
                yanlışAdedi++;
                labelYanlışSayısı.Text = yanlışAdedi.ToString();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            labelVerilenCevap.Text = button3.Text;
            if (labelDoğruCevap.Text == labelVerilenCevap.Text)
            {
                doğruAdedi++;
                labelDoğruSayısı.Text = doğruAdedi.ToString();
            }
            else
            {
                yanlışAdedi++;
                labelYanlışSayısı.Text = yanlışAdedi.ToString();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer1.Enabled = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;

            labelVerilenCevap.Text = button4.Text;
            if (labelDoğruCevap.Text == labelVerilenCevap.Text)
            {
                doğruAdedi++;
                labelDoğruSayısı.Text = doğruAdedi.ToString();
            }
            else
            {
                yanlışAdedi++;
                labelYanlışSayısı.Text = yanlışAdedi.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            süre = Convert.ToInt32(labelSüre.Text);

            süre -= 1;
            labelSüre.Text = süre.ToString();
            if (süre==0)
            {
                timer1.Enabled = false;
            }

        }
    }
}
