using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Monitor_Cheltuieli.Models
{
    public class Monitor
    {
        public int ID { get; set; }
        [Display(Name = "Produs Achizitionat")]
        public string Produs { get; set; }
        public string Descriere { get; set; }

        public int Cantitate { get; set; }
        [Column(TypeName = "decimal(6,2)")]
        public decimal Pret { get; set; }
                
        [Display(Name = "Data Achizitie")]
        [DataType(DataType.Date)]
        public DateTime Data_Achizitie { get; set; }
    }
}
