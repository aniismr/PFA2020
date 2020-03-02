using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PFA.Models
{
    public class Competence
    {        
        [Column(TypeName = "nvarchar(100)")]
        public string code { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string libele { get; set; }
    }
}