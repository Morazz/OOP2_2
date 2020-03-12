using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Producer : Form
    {
        public Producer()
        {
            InitializeComponent();
        }

        public List<_Producer> Prod = new List<_Producer>();

        [Serializable]
        public class _Producer
        {

            public string name { get; set; }
            public string country { get; set; }
            public string address { get; set; }
            public string numb { get; set; }

            public _Producer(string name, string country, string address, string number)
            {
                this.name = name;
                this.country = country;
                this.address = address;
                this.numb = number;
            }

            public _Producer() { }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Prod.Add(new _Producer(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text));
            Close(); 
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider2.SetError(textBox1, "This field can't be null");
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void textBox2_Validating(object sender, CancelEventArgs e)
        {
            if (textBox2.Text.Length == 0)
            {
                errorProvider2.SetError(textBox2, "This field can't be null");
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                errorProvider2.SetError(textBox3, "This field can't be null");
                button1.Enabled = false;
            }
            else
                button1.Enabled = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                errorProvider2.Clear();
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text.Length != 0)
            {
                errorProvider3.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length != 0)
            {
                errorProvider4.Clear();
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text.Length != 0)
            {
                errorProvider5.Clear();
            }
        }
    }
}
