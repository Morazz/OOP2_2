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
using System.Text.RegularExpressions;
using System.ComponentModel.DataAnnotations;


namespace Lab5
{
    public partial class Form1 : Form
    {
        Timer timer;

        public Form1()
        {
            InitializeComponent();

            var source = new AutoCompleteStringCollection();
            source.AddRange(new string[]
            {
                "Kitchen",
                "Bathroom",
                "Bedroom",
                "Lounge",
                "Watercloset"
            });

            toolStripContainer1.RightToolStripPanel.Controls.Add(toolStrip1);
            comboBox1.AutoCompleteCustomSource = source;
            comboBox1.AutoCompleteSource = AutoCompleteSource.CustomSource;
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        public List<Product> products = new List<Product>();
        public List<Producer._Producer> _s = new List<Producer._Producer>();

        private void tb_Scroll(object sender, EventArgs e)
        {
            w.Text = tb.Value.ToString();
            action.Text = "Weight added";
        }

        private void tb2_Scroll(object sender, EventArgs e)
        {
            a.Text = tb2.Value.ToString();
            action.Text = "Amount added";
        }

        public string dateP;

        private void time_DateChanged(object sender, DateRangeEventArgs e)
        {
            dateP = time.SelectionRange.Start.ToShortDateString();

            DateTime dt = time.SelectionRange.Start;
            if (dt <= time.TodayDate)
            {
                errorProvider5.Clear();
                write.Enabled = true;
                read.Enabled = true;
            }

            action.Text = "Date added";
        }

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

                action.Text = "Producer added";
            }            
        }

        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        XmlSerializer serializer2 = new XmlSerializer(typeof(List<Producer._Producer>));

        private void write_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("1.xml", FileMode.Create))
            {
                serializer.Serialize(fs, products);
            }

            using (FileStream fs2 = new FileStream("2.xml", FileMode.Create))
            {
                serializer2.Serialize(fs2, _s);
            }

            products.Clear();
            _s.Clear();

            action.Text = "Write to file";
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

            obj.Text = $"Amount of objects: {products.Count}";
            action.Text = "Read from file";

            Info info = new Info();
            info.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                errorProvider1.Clear();
                write.Enabled = true;
                read.Enabled = true;
            }

            action.Text = "Name added";
        }

        private void add_Click(object sender, EventArgs e)
        {
            Product p = new Product(textBox1.Text, numb.Text, comboBox1.SelectedItem.ToString(),
                int.Parse(textBox3.Text), radioButton1.Checked == true ? radioButton1.Text : radioButton2.Text,
                tb.Value, tb2.Value, dateP, cb.SelectedItem.ToString());

            var results = new List<ValidationResult>();
            var context = new ValidationContext(p);

            if (!Validator.TryValidateObject(p, context, results, true))
            {
                string strError = "";
                foreach (var error in results)
                {
                    strError += $"{error.ErrorMessage}\n";
                    
                }
                MessageBox.Show(strError);
            }

            products.Add(p);

            action.Text = "Product added";
            obj.Text = $"Amount of objects: {products.Count}";
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

        //private void numb_Validating(object sender, CancelEventArgs e)
        //{
        //    if (numb.Text.Length == 0)
        //    {
        //        errorProvider2.SetError(numb, "The field is empty");
        //        add.Enabled = false;
        //        write.Enabled = false;
        //    }
        //}

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
                add.Enabled = true;
                write.Enabled = true;
            }
            action.Text = "Inventory number added";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            float p = 0;
            if (textBox3.Text.Length != 0 && float.TryParse(textBox3.Text, out p))
            {
                errorProvider4.Clear();
                add.Enabled = true;
                write.Enabled = true;
            }

            action.Text = "Price added";
        }


        //-----------------------------------------------------------------------------

        public List<Product> PrRes = new List<Product>();
        public List<Producer._Producer> ProdRes = new List<Producer._Producer>();

        private void nameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEx reg = new RegEx();
            reg.ShowDialog();           
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegEx reg = new RegEx();
            reg.ShowDialog();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moroz Alexandra" + "\n" + "Version 6.4" + "\n" + "© All rights reserved", "About");
        }

        private void saveToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("file.xml", FileMode.Create))
            {
                serializer.Serialize(fs, PrRes);
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            RegEx ex = new RegEx();
            ex.ShowDialog();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            using (FileStream fs = new FileStream("file.xml", FileMode.Create))
            {
                serializer.Serialize(fs, PrRes);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Moroz Alexandra" + "\n" + "Version 6.4" + "\n" + "© All rights reserved", "About");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
            timer = new Timer() { Interval = 1000 };
            timer.Tick += timer_Tick;
            timer.Start();
            obj.Text = $"Amount of objects: {products.Count}";
        }

        void timer_Tick(object sender, EventArgs e)
        {
            label.Text = $"{DateTime.Now.ToLongDateString()} {DateTime.Now.ToLongTimeString()}";
        }

        private void panel_Click(object sender, EventArgs e)
        {
            toolStrip1.Visible = !toolStrip1.Visible;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            action.Text = "Type added";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            action.Text = "Size added";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            action.Text = "Size added";
        }
    }
}
