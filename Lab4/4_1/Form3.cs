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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public string str;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(textBox1.Text))
                {
                    throw new Exception();
                }
                str = textBox1.Text;
                this.Dispose();
            }
            catch (Exception)
            {
                MessageBox.Show("The string doesn't exists");
            }
        }
    }
}
