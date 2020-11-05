using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDTransportCompany.Models
{
    public class TypesOfCars
    {
        public long ID { get; set; } 

        [Display(Name = "Код вида автомобиля")]
         public long TypeofCar_ID { get; set; }
        [Display(Name = "Наименование")]
        public string Name { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
