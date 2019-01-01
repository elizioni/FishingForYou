using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FishingForYou.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Publisher { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string FirstImage { get; set; }
        public string SecondImage { get; set; }
        public int OrderId { get; set; }
        public int AdId { get; set; }
    }
}
