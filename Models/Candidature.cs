using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PFA.Models
{
    public class Candidature
    {        
        [Column(TypeName = "nvarchar(100)")]
        public string type { get; set; }
        [DataType(DataType.Date)]
        public DateTime datenaissance { get; set; }
    }
}