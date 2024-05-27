using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace One.Models
{
    public class Product
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? LotNo { get; set; }
        public DateTime ManufactureDate { get; set; }
        public DateTime ExpireDate { get; set; }
        public string Unit  { get; set; }
        public string Price { get; set; }
    }
}
