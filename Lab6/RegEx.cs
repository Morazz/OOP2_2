using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;
using System.IO;

namespace Lab5
{
    public partial class RegEx : Form
    {
        public RegEx()
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

            type.AutoCompleteCustomSource = source;
            type.AutoCompleteSource = AutoCompleteSource.CustomSource;
            type.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        }

        public string sname = "";
        public string stype = "";
        public float sminp = 0;
        public float smaxp = 0;
        public string check;
        public List<Product> PrRes = new List<Product>();
        public List<Producer._Producer> ProdRes = new List<Producer._Producer>();
        Form1 form = (Form1)ActiveForm;

        DataTable data = new DataTable();

        private void search_Click(object sender, EventArgs e)
        {
            data.Rows.Clear();

            check = rbname.Checked == true ? rbname.Name : rbtype.Checked == true ? rbtype.Name : rbrange.Checked == true ? rbrange.Name : rball.Name;

            dataGridView1.DataSource = null;

            switch (check)
            {
                case "rbname":
                    {
                        PrRes.Clear();
                        Regex regex = new Regex($"^{name.Text}$");

                        foreach (Product p in form.products)
                        {
                            MatchCollection match = regex.Matches(p.name);

                            if (match.Count > 0)
                                PrRes.Add(p);
                        }
                    }
                    break;
                case "rbtype":
                    {
                        PrRes.Clear();
                        Regex regex = new Regex(type.SelectedItem.ToString());

                        foreach (Product p in form.products)
                        {
                            MatchCollection match = regex.Matches(p.type);

                            if (match.Count > 0)
                                PrRes.Add(p);
                        }
                    }
                    break;
                case "rbrange":
                    {
                        PrRes.Clear();
                        //Regex regex = new Regex($"[{minp.Text}-{maxp.Text}]");
                        foreach (Product p in form.products)
                        {
                            if (p.price >= Int32.Parse(minp.Text) && p.price <= Int32.Parse(maxp.Text))
                                PrRes.Add(p);
                        }
                    }
                    break;
                case "rball":
                    {
                        PrRes.Clear();

                        Regex regexname = new Regex($"^{name.Text}$");
                        Regex regextype = new Regex(type.SelectedItem.ToString());

                        foreach (Product p in form.products)
                        {
                            MatchCollection matchname = regexname.Matches(p.name);
                            MatchCollection matchtype = regextype.Matches(p.type);
                            if (p.price >= Int32.Parse(minp.Text) && p.price <= Int32.Parse(maxp.Text) && matchname.Count > 0 && matchtype.Count > 0)
                                PrRes.Add(p);
                        }             
                    }
                    break;
            }
           
                foreach (Product p in PrRes)
                {
                 //foreach (Producer._Producer pr in form._s)
                
                    data.Rows.Add(p.name, p.number, p.type, p.price, p.size, p.weight, p.amount, p.date, p.producer/*, p.producer == pr.name ? pr.country : "null"*/);
                }

            dataGridView1.DataSource = data;
            form.PrRes = PrRes;
        }

        private void tb_Scroll(object sender, EventArgs e)
        {
            minp.Text = tb.Value.ToString();
        }

        private void tb2_Scroll(object sender, EventArgs e)
        {
            maxp.Text = tb2.Value.ToString();
        }

        private void RegEx_Load(object sender, EventArgs e)
        {
            data.Columns.Add("Name");
            data.Columns.Add("Number");
            data.Columns.Add("Type");
            data.Columns.Add("Price");
            data.Columns.Add("Size");
            data.Columns.Add("Weight");
            data.Columns.Add("Amount");
            data.Columns.Add("Date");
            data.Columns.Add("Producer");
            data.Columns.Add("Country");
        }


        private void asc_Click(object sender, EventArgs e)
        {
            if (oname.Checked == true)
            {
                EnumerableRowCollection<DataRow> query = from dt in data.AsEnumerable()
                                                         orderby dt.Field<string>("Name")
                                                         select dt;

                DataView view = query.AsDataView();
                dataGridView1.DataSource = view;
                
            }
            if (otype.Checked == true)
            {
                EnumerableRowCollection<DataRow> query = from dt in data.AsEnumerable()
                                                         orderby dt.Field<string>("Type")
                                                         select dt;

                DataView view = query.AsDataView();
                dataGridView1.DataSource = view;
            }
        }

        private void desc_Click(object sender, EventArgs e)
        {
            if (oname.Checked == true)
            {
                EnumerableRowCollection<DataRow> query = from dt in data.AsEnumerable()
                                                         orderby dt.Field<string>("Name") descending
                                                         select dt;

                DataView view = query.AsDataView();
                dataGridView1.DataSource = view;

            }
            if (otype.Checked == true)
            {
                EnumerableRowCollection<DataRow> query = from dt in data.AsEnumerable()
                                                         orderby dt.Field<string>("Type") descending
                                                         select dt;

                DataView view = query.AsDataView();
                dataGridView1.DataSource = view;
            }
        }

        private void save_Click_1(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

            using (FileStream fs = new FileStream("search.xml", FileMode.Create))
            {
                serializer.Serialize(fs, PrRes);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));

            using (FileStream fs = new FileStream("search.xml", FileMode.Create))
            {
                serializer.Serialize(fs, PrRes);
            }
        }

        private void toolStrip1_MouseEnter(object sender, EventArgs e)
        {
            toolStrip1.Visible = true;
        }

        private void toolStrip1_MouseLeave(object sender, EventArgs e)
        {
            toolStrip1.Visible = false;
        }
    }
}
