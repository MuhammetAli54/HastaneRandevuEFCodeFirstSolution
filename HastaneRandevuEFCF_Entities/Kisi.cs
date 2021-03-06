using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneRandevuEFCF_Entities
{
   public abstract class Kisi
    {
        [Required]
        [StringLength(11, ErrorMessage ="Tc kimlik 11 haneli olmalıdır!")]
        public string TCNo { get; set; }

        [StringLength(11,ErrorMessage ="Telefon 11 haneli olmalıdır!")]
        public string Telefon { get; set; }

        [DataType(DataType.EmailAddress)]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Lütfen email adresini doğru girin!")]
        public string Email { get; set; }
    }
}
