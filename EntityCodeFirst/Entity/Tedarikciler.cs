using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Tedarikciler
    {
        [Key]
        public int TedarikciID { get; set; }
        public string TedarikciAd { get; set; }
        public string TedarikciSoyad { get; set; }
        public string TedarikAdres { get; set; }
        public int TedarikTelNo { get; set; }
        public ICollection<Urunler> Urunlers { get; set; }
    }
}
