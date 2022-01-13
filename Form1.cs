using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace generovanihesel_kolackasimon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelPassword.Visible = false;
            textBox1.Visible = false;
        }

        int[] finalpassword;

        private void button1_Click(object sender, EventArgs e)
        {
            labelPassword.Text = "";
            Random rnd = new Random();
            int pswdlenght = rnd.Next(8, 16); //<8;15>
            int firstWord = rnd.Next(65, 91);//<65;90>
            finalpassword = new int[pswdlenght];
            for (int i = 0; i < pswdlenght; i++) 
            {
                finalpassword[i] = rnd.Next(33, 127);//<33-126> generovani pismen nebo znaku
            }
            finalpassword[0] = firstWord; //Velke pismeno
            finalpassword[pswdlenght-1] = rnd.Next(48,58); //cislice
            for (int x = 0; x < pswdlenght; x++) 
            {
                char c = Convert.ToChar(finalpassword[x]);//pretypovani z ciselných hodnot na znaky ascci tabulky
                labelPassword.Text += c;
            }
            Clipboard.SetText(labelPassword.Text);
            labelPassword.Visible = true;
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e) //popisky
        {
            textBox1.Visible = true; 
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Visible = false;
        }
    }
}
