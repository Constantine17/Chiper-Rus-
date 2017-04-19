using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace WindowsFormsApplication1
{   
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox3.Text.Length == 0) { textBox3.Text = "3"; }
                string wor = textBox1.Text;
                string sdvig = textBox3.Text;
                int sdvigCH = Convert.ToInt32(sdvig);
                Computing word1 = new Computing(wor, sdvigCH);
                string q;
                q = word1.PrintWord();
                textBox2.Text = q;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                string wor = textBox1.Text;
                Pad word2 = new Pad(wor);
                string q;
                q = word2.PrintWord();
                textBox2.Text = q;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                string wor = textBox1.Text;
                string key = textBox3.Text;
                Vigenere word3 = new Vigenere(wor, key, 0);
                string q;
                q = word3.PrintWord();
                textBox2.Text = q;
            }
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //  by default
        {
            comboBox1.SelectedIndex = 0;
            //textBox3.Text = "3";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && (e.KeyChar < 97 || e.KeyChar > 122)) // only latin 
                e.Handled = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                if (textBox3.Text.Length == 0) { textBox3.Text = "3"; }
                string wor = textBox1.Text;
                string sdvig = textBox3.Text;
                int sdvigCH = Convert.ToInt16(sdvig);
                Computing word1 = new Computing(wor, -sdvigCH);
                string q;
                q = word1.PrintWord();
                textBox2.Text = q;
            }

            if (comboBox1.SelectedIndex == 1)
            {
                string wor = textBox1.Text;
                Pad word2 = new Pad(wor);
                string q;
                q = word2.PrintWord();
                textBox2.Text = q;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                string wor = textBox1.Text;
                string key = textBox3.Text;
                Vigenere word3 = new Vigenere(wor, key, 1);
                string q;
                q = word3.PrintWord();
                textBox2.Text = q;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            { 
                if (e.KeyChar != 8 && (e.KeyChar < 49 || e.KeyChar > 57)) // only 1-9
                    e.Handled = true; 
            }
            if (comboBox1.SelectedIndex == 2)
            {
                if (e.KeyChar != 8 && (e.KeyChar < 97 || e.KeyChar > 122)) // only latin
                    e.Handled = true; 
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        { }

        private void label3_Click(object sender, EventArgs e)
        { }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0) { textBox3.Visible = true; textBox4.Text = "Ведите сдвиг:  "; textBox3.MaxLength = 1; textBox3.Text = ""; }
            if (comboBox1.SelectedIndex == 1) { textBox3.Visible = false; textBox4.Text = " "; }
            if (comboBox1.SelectedIndex == 2) { textBox4.Text = "Ключ:  "; ; textBox3.Visible = true; textBox3.Text = ""; textBox3.MaxLength = 26; textBox3.Text = ""; }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            abaut ab = new abaut();
            ab.ShowDialog();
        }


    }
}
