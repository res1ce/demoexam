using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExam.Models
{
    public class Sales
    {
        [Key]
        public int id { get; set; }
        public int amount { get; set; }
        public string sale_date { get; set; }
        [ForeignKey("product_id")]
        public Product product { get; set; }

        [ForeignKey("PartnerId")]
        public int partner_id { get; set; }

    }
}
