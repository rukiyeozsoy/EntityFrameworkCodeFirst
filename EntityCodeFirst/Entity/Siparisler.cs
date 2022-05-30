using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityCodeFirst.Entity
{
    public class Siparisler
    {
        [Key]
        public int SiparisID { get; set; }
        public int UrunID { get; set; }
        public int MusteriID { get; set; }
        public Urunler Urunler { get; set; }
        public Musteriler Musteriler { get; set; }
    }
}
