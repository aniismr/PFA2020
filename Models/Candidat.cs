using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PFA.Models
{
    public class Candidat
    {
        [Key]
        public int ID_Candidat { get; set; }
        [Column(TypeName ="nvarchar(20)")]
        [Required]
        public string nom { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string prenom { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string email { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public string cv { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        [Required]
        public int experience { get; set; }
        [DataType(DataType.Date)]
        public DateTime datenaissance { get; set; }
    }
}