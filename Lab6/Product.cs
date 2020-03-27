using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Lab5
{
    [Serializable]
    public class Product
    {
        [StringLength(50, MinimumLength = 3, ErrorMessage = "The name is too short")]
        [User]
        public string name { get; set; }      
        [RegularExpression(@"^\d{5}$", ErrorMessage = "Invalid inventory number format")]
        public string number { get; set; }
        public string type { get; set; }
        [Range(1, 2000, ErrorMessage = "The price is too big")]
        public int price { get; set; }
        public string size { get; set; }
        public int weight { get; set; }
        public int amount { get; set; }
        public string date { get; set; }
        public string producer { get; set; }

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
