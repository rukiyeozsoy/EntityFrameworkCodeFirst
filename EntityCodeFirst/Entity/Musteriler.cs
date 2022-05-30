using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Musteriler
    {
        [Key]
        public int MusteriID { get; set; }
        public string MusteriAd { get; set; }
        public string MusteriSoyad { get; set; }
        public string Adres { get; set; }
        public int TelNo { get; set; }
        public Urunler Urunler { get; set; }
        public ICollection<Siparisler> Siparislers { get; set; }
    }
}
