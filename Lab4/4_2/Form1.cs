using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_2
{

    public partial class Collection : Form
    {
        public Collection()
        {
            InitializeComponent();
        }

        public int s;
        List<Rect> rects = new List<Rect>();

        private void generate_Click(object sender, EventArgs e)
        {
            try
            {
                if (int.Parse(tb.Text).GetType() != typeof(int))
                {
                    throw new FormatException();
                }

                s = int.Parse(tb.Text);
                if (s <= 0)
                    throw new ArgumentException();

                Random random = new Random();

                if (lb1.Items.Count != 0)
                {
                    lb1.Items.Clear();
                    rects.Clear();
                }

                for (int i = 0; i < s; i++)
                {
                    rects.Add(new Rect(random.Next(1, 100)));
                }

                foreach (Rect rect in rects)
                {
                    lb1.Items.Add(rect.size);
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid size format");
            }
            catch (ArgumentException)
            {
                MessageBox.Show("Invalid size");
            }
        }

        private void asc_Click(object sender, EventArgs e)
        {
            try
            {
                if (s <= 0)
                    throw new ArgumentNullException();

                lb2.Items.Clear();
                rects.Sort();

                foreach (Rect r in rects)
                {
                    lb2.Items.Add(r.size);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The list is empty");
            }
        }

        private void cl_Click(object sender, EventArgs e)
        {
            lb1.Items.Clear();
            lb2.Items.Clear();
            tb.Clear();
            rects.Clear();
        }

        private void minim_Click(object sender, EventArgs e)
        {
            try
            {
                if (s <= 0)
                    throw new ArgumentNullException();

                lb2.Items.Clear();
                lb2.Items.Add(rects.Min().size);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The list is empty");
            }
        }

        private void maxi_Click(object sender, EventArgs e)
        {
            try
            {
                if (s <= 0)
                    throw new ArgumentNullException();
                lb2.Items.Clear();
                lb2.Items.Add(rects.Max().size);
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The list is empty");
            }
        }

        private void desc_Click(object sender, EventArgs e)
        {
            try
            {
                if (s <= 0)
                    throw new ArgumentNullException();

                lb2.Items.Clear();
                rects.Sort();
                rects.Reverse();
                foreach (Rect r in rects)
                {
                    lb2.Items.Add(r.size);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The list is empty");
            }
        }

        private void range_Click(object sender, EventArgs e)
        {
            try
            {
                List<Rect> l = new List<Rect>();
                if (lb1.Items.Count <= 0 || lb1.SelectedItems.Count == 0)
                    throw new ArgumentNullException();

                     foreach (int r in lb1.SelectedItems)
                     {
                                lb2.Items.Add(r);
                               l.Add(new Rect(r));
                     }

                rects.Clear();
                rects = l;
                lb1.Items.Clear();

                foreach (Rect r in rects)
                {
                    lb1.Items.Add(r.size);
                }
            }
            catch (ArgumentNullException)
            {
                MessageBox.Show("The list is empty");
            }
        }
    }

    public class Rect:IComparable<Rect>
    {
        public int size { get; set; }
        public Rect(int size)
        {
            this.size = size;
        }
        public int CompareTo(Rect r)
        {
            return this.size.CompareTo(r.size);
        }
    }

}
