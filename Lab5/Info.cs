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
    public partial class Info : Form
    {
        public Info()
        {
            InitializeComponent();
        }

        private void Info_Load(object sender, EventArgs e)
        {
            
            DataTable data = new DataTable();
            data.Columns.Add("Name");
            data.Columns.Add("Number");
            data.Columns.Add("Type");
            data.Columns.Add("Price");
            data.Columns.Add("Size");
            data.Columns.Add("Weight");
            data.Columns.Add("Amount");
            data.Columns.Add("Date");
            data.Columns.Add("Producer");

            Form1 form = (Form1)ActiveForm;
            foreach (Product p in form.products)
            {
                data.Rows.Add(p.name, p.number, p.type, p.price, p.size, p.weight, p.amount, p.date, p.producer);
            }

            dataGridView1.DataSource = data;

            DataTable data2 = new DataTable();
            data2.Columns.Add("Name");
            data2.Columns.Add("Country");
            data2.Columns.Add("Number");
            data2.Columns.Add("Address");
;
            foreach (Producer._Producer p in form._s)
            {
                data2.Rows.Add(p.name, p.country, p.numb, p.address);
            }

            dataGridView2.DataSource = data2;

        }
    }
}
