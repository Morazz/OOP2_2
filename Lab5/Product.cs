using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    [Serializable]
    public class Product
    {
       public string name;
       public string number;
       public string type;
       public int price;
       public string size;
       public int weight;
       public int amount;
       public string date;
       public string producer;

        public Product(string name, string number, string type,
                       int price, string size, int weight,
                       int amount, string date, string producer)
        {
            this.name = name;
            this.number = number;
            this.price = price;
            this.producer = producer;
            this.size = size;
            this.type = type;
            this.weight = weight;
            this.amount = amount;
            this.date = date;
        }

        public Product() { }
    }
}
