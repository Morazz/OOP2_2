using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Data;

namespace Lab5
{

    //public class RegExp
    //{
    //     public  List<Product> PrRes = new List<Product>();
    //     public List<Producer._Producer> ProdRes = new List<Producer._Producer>();

    //}
    public static class DT
    {
        public static void BuildTable()
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
        }
    }
}
