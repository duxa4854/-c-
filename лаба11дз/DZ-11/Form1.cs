using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_11
{
    public partial class Form1 : Form
    {
        string[] words = { "яблоко", "кот", "машина", "окно", "книга", "солнце", "дом", "река", "лес", "звезда" };
        Random random = new Random();
        int correct = 0;
        int errors = 0;

        public Form1()
        {
            InitializeComponent();
            NewWord();
        }
        private void intupBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string userText = intupBox1.Text.Trim().ToLower();
                string currentWord = wordLabel.Text.ToLower();

                if (userText == currentWord)
                    correct++;
                else
                    errors++;

                scoreLabel.Text = $"Правильно: {correct} | Ошибок: {errors}";
                intupBox1.Clear();
                NewWord();
            }
        }
        private void NewWord()
        {
            int index = random.Next(words.Length);
            wordLabel.Text = words[index];
            intupBox1.Focus();
        }
    }
}
