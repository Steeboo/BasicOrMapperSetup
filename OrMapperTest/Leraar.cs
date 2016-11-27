using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrMapperTest
{
    [Table("Leraren")]
    public class Leraar
    {
        [Key]
        public int LeraarNummer { get; set; }
       
        [Required]
        public string Naam { get; set; }

        public int? Leeftijd { get; set; }
    }
}
