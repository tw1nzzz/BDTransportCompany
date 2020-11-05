using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BDTransportCompany.Models
{
    public class Positions
    {
        public long ID { get; set; }

        [Display(Name = "Код должности")]
        public long Position_ID{ get; set; }

        [Display(Name = "Наименование должности")]
        public string JobTitle { get; set; }

        [Display(Name = "Оклад")]
        public int Salary { get; set; }

        [Display(Name = "Обязанности")]
        public string Responsibilities { get; set; }

        [Display(Name = "Требования")]
        public string Demands { get; set; }
    }
}
