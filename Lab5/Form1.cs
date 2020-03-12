using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            w.Text = tb.Value.ToString();
        }

        private void tb2_Scroll(object sender, EventArgs e)
        {
            a.Text = tb2.Value.ToString();
        }

        public string dateP;

        private void time_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateP = time.SelectionRange.Start.ToShortDateString();

            DateTime dt = time.SelectionRange.Start;
            if (dt <= time.TodayDate)
            {
                errorProvider5.Clear();
            }
        }

        public List<Producer._Producer> _s = new List<Producer._Producer>();

        private void cb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb.SelectedItem.ToString() == "Add new...")
            {
                Producer producer = new Producer();
                producer.ShowDialog();
                foreach (Producer._Producer p in producer.Prod)
                {
                    if (p.name.Length > 0)
                    {
                        cb.Items.Add(p.name);
                        _s.Add(p);
                    }
                    cb.SelectedItem = p.name;
                }
            }
        }

        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        XmlSerializer serializer2 = new XmlSerializer(typeof(List<Producer._Producer>));

        private void write_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("products.xml", FileMode.Append))
            {
                serializer.Serialize(fs, products);
            }

            using (FileStream fs2 = new FileStream("producers.xml", FileMode.Append))
            {
                serializer2.Serialize(fs2, _s);
            }

            products.Clear();
            _s.Clear();
        }

        private void read_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("products.xml", FileMode.Open))
            {
                products.Clear();
                products = (List<Product>)serializer.Deserialize(fs);
            }

            using (FileStream fs2 = new FileStream("producers.xml", FileMode.Open))
            {
                _s.Clear();
                _s = (List<Producer._Producer>)serializer2.Deserialize(fs2);
            }


            Info info = new Info();
            info.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                errorProvider1.Clear();
            }
        }

        public List<Product> products = new List<Product>();

        private void add_Click(object sender, EventArgs e)
        {
            products.Add(new Product(textBox1.Text, numb.Text, comboBox1.SelectedItem.ToString(),
                int.Parse(textBox3.Text), radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text,
                tb.Value, tb2.Value, dateP, cb.SelectedItem.ToString()));
        }

        private void textBox3_Validating(object sender, CancelEventArgs e)
        {
            if (textBox3.Text.Length == 0)
            {
                errorProvider1.SetError(textBox3, "The field is empty");
                add.Enabled = false;
                write.Enabled = false;
            }
            if (float.Parse(textBox3.Text).GetType() != typeof(float))
            {
                errorProvider1.SetError(textBox3, "Invalid value format");
                add.Enabled = false;
                write.Enabled = false;
            }
        }

        private void textBox1_Validating(object sender, CancelEventArgs e)
        {
            if (textBox1.Text.Length == 0)
            {
                errorProvider1.SetError(textBox1, "The field is empty");
                add.Enabled = false;
                write.Enabled = false;
            }
        }

        private void numb_Validating(object sender, CancelEventArgs e)
        {
            if (numb.Text.Length == 0)
            {
                errorProvider2.SetError(numb, "The field is empty");
                add.Enabled = false;
                write.Enabled = false;
            }
        }

        private void textBox3_Validating_1(object sender, CancelEventArgs e)
        {
            float p = 0;

            if (textBox3.Text.Length == 0)
            {
                errorProvider4.SetError(textBox3, "The field is empty");
                add.Enabled = false;
                write.Enabled = false;
            }
            if (!float.TryParse(textBox3.Text, out p))
            {
                errorProvider4.SetError(textBox3, "Invalid price format");
                add.Enabled = false;
                write.Enabled = false;
            }
        }

        private void time_Validating(object sender, CancelEventArgs e)
        {
            DateTime dt = time.SelectionRange.Start;
            if (dt > time.TodayDate)
            {
                errorProvider5.SetError(time, "Invalid date");
                add.Enabled = false;
                write.Enabled = false;
            }
        }

        private void numb_TextChanged(object sender, EventArgs e)
        {
            if (numb.Text.Length != 0)
            {
                errorProvider2.Clear();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float p = 0;
            if (textBox3.Text.Length != 0 && float.TryParse(textBox3.Text, out p))
            {
                errorProvider4.Clear();
            }
        }

    }
}
