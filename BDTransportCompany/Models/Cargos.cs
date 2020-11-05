using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDTransportCompany.Models
{
    public class Cargos
    {
        public long ID { get; set; }
       
        [Display(Name = "Код груза")]
        public long Cargo_ID { get; set; }
        [Display(Name = "Наименование")]
        public string Title { get; set; }
        [Display(Name = "Вид груза")]
        public DbSet<TypesOfCargos> TypesOfCargos_ID { get; set; }
        [Display(Name = "Код вида груза")]
        public long TypesOfCargosID { get; set; }

        [Display(Name = "Срок годности")]
        public DateTime ExpirationDate { get; set; }
        [Display(Name = "Особенности")]
        public string Features { get; set; }
    }
}
