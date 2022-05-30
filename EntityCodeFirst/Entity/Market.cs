using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Market
    {
        [Key]
        public int MarketID { get; set; }
        public int UrunID { get; set; }
        public Urunler Urunler { get; set; }
    }
}
