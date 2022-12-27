using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirstExample.Models
{
    public class Sales
    {
        [Key]
        public int Id { get; set; }
        public string SalesPerson { get; set; }
        public double TotalSales { get; set; }
        public int IsActive { get; set; }
    }
}
