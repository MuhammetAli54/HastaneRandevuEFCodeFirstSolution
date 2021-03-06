using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_Entities
{
    [Table("Hastalar")]
    public class Hasta : Kisi
    {
        [Key]
        [Column(Order = 1)]
        public int HastaId { get; set; }
        [Required(ErrorMessage ="Hasta adı giriniz!")]
        [StringLength(50)]
        [Display(Name ="Hasta Adı")]
        public string HastaAdi  { get; set; }

        [Required(ErrorMessage = "Lütfen hasta soyadı giriniz!")]
        [StringLength(50)]
        [Display(Name = "Hasta Soyadı")]
        public string HastaSoyadi { get; set; }

        public virtual List<RandevuBilgileri> RandevuBilgileriList { get; set; }

        public override string ToString()
        {
            return $"{this.TCNo} - {this.HastaAdi} {this.HastaSoyadi}";
        }
    }
}
