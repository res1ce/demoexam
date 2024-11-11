using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.Models
{
    public class Product
    {
        [Key]
        public int product_id { get; set; }
        public string article { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public decimal min_price { get; set; }
    }
}
