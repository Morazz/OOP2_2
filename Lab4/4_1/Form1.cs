using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)//удаление подстроки
        {
            try
            {
                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentException();
                }

                Form3 form3 = new Form3();
                form3.ShowDialog();

                if (form3.str.Length > 0)
                {
                    if (textbox.Text.IndexOf(form3.str) == -1)
                    {
                        throw new ArgumentException();
                    }
                    int n = textbox.Text.IndexOf(form3.str);
                    result.Text = textbox.Text.Remove(n, form3.str.Length);
                }
                else
                    result.Text = textbox.Text;
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Substring doesn't exist");
            }

        }

        private void button3_Click(object sender, EventArgs e)//символ по индексу
        {
            try
            {

                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentNullException();
                }

                string str = textbox.Text;

                Form4 form4 = new Form4();
                form4.ShowDialog();

                if (form4.index >= 0 && form4.index < textbox.Text.Length)
                {
                    result.Text = $"Required symbol: {str.ElementAt(form4.index)}";
                }
                else
                    throw new ArgumentException();
            }

            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid index");
            }
        }

        private void button4_Click(object sender, EventArgs e)//длина строки
        {
            try
            {
                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentNullException();
                }

                result.Text = $"String length: {textbox.Text.Length}";
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
        }

        private void button5_Click(object sender, EventArgs e)//гласные
        {
            try
            {
                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentNullException("The string doesn't exist");
                }

                int count = 0;
                char[] arr = { 'e', 'y', 'u', 'i', 'o', 'a',
                'E', 'Y', 'U', 'I', 'O', 'A'};
                foreach (char l in textbox.Text)
                {
                    foreach (char a in arr)
                    {
                        if (l == a)
                        {
                            count++;
                        }
                    }
                }
                result.Text = $"Amount of vowel: {count}";
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
        }

        private void button9_Click(object sender, EventArgs e)//очистка поля
        {
            textbox.Clear();
            result.Clear();
        }

        private void s_Click(object sender, EventArgs e)//согласные
        {
            try
            {
                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentNullException();
                }

                int count = 0;
                char[] arr =
                {
                'q', 'w', 'r', 't', 'p', 's',
                'd', 'f', 'g', 'h', 'j', 'k',
                'l', 'z', 'x', 'c', 'v', 'b',
                'n', 'm', 'Q', 'W', 'R', 'T',
                'P', 'S', 'D', 'F', 'G', 'H',
                'J', 'K', 'L', 'Z', 'X', 'C',
                'V', 'B', 'N', 'M'
            };
                char[] word = textbox.Text.ToCharArray();
                foreach (char a in word)
                {
                    foreach (char l in arr)
                    {
                        if (a == l)
                        {
                            count++;
                        }
                    }
                }
                result.Text = $"Amount of consonant: {count}";
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
        }

        private void replace_Click(object sender, EventArgs e)//замена подстроки
        {
            try
            {
                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentNullException();
                }

                Form2 form2 = new Form2();
                form2.ShowDialog();

                if (form2.str.Length > 0)
                    result.Text = textbox.Text.Replace(form2.str, form2.str2);

            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("The substring doesn't exist");
            }
        }

        private void phrase_Click(object sender, EventArgs e)//кол-во предложений.
        {
            try
            {
                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentNullException();
                }

                int count = 0;
                string[] arr = textbox.Text.Trim(' ').Split(' ');

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != "." || arr[i] != "?" || arr[i] != "!")
                    {
                        char[] varr = arr[i].ToArray();
                        if (varr[varr.Length - 1] == '.' || varr[varr.Length - 1] == '!' || varr[varr.Length - 1] == '?')
                        {
                            count++;
                        }
                    }
                    else count++;
                }
                result.Text = $"Amount of phrases: {count}";
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
        }

        private void word_Click(object sender, EventArgs e)//кол-во слов
        {
            try
            {
                if (String.IsNullOrEmpty(textbox.Text))
                {
                    throw new ArgumentNullException();
                }

                int count = 0;
                string[] arr = textbox.Text.Trim(' ').Split(' ');

                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] != "." || arr[i] != "!" || arr[i] != "?")
                    {
                        char[] varr = arr[i].ToArray();
                        if (varr[varr.Length - 1] == '.' || varr[varr.Length - 1] == '!' || varr[varr.Length - 1] == '?')
                        {
                            count++;
                        }
                        else count++;
                    }
                }

                result.Text = $"Amount of words: {count}";
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The string doesn't exist");
            }
        }      
    }
}
