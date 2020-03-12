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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public int index;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception();
                }
                if (int.Parse(textBox1.Text).GetType() != typeof(int))
                {
                    throw new FormatException();
                }
                else
                {
                    index = int.Parse(textBox1.Text);
                    this.Dispose();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid format");
                index = -2;
            }

            catch (Exception)
            {
                MessageBox.Show("The string doesn't exist");
                index = -1;
            }
          
        }
    }
}
