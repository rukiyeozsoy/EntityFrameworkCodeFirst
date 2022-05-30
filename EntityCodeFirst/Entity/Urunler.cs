using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Urunler
    {
        [Key]
        public int UrunID { get; set; }
        public string UrunAd { get; set; }
        public string UrunKategori { get; set; }
        public Tedarikciler Tedarikciler { get; set; }
        public ICollection<Musteriler> Musterilers { get; set; }
        public ICollection<Siparisler> Siparislers { get; set; }
        public ICollection<Market> Markets { get; set; }
    }
}
