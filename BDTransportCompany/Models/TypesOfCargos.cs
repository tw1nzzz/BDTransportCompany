using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDTransportCompany.Models
{
    public class TypesOfCargos
    {
        public long ID { get; set; }
        [Display(Name = "Код вида груза")]
        public long TypesOfCargos_ID { get; set; }
        [Display(Name = "Наименование")]
        public string Title { get; set; }
        [Display(Name = "Вид автомобиля транспортировки")]
        public DbSet<TypesOfCars> TypeOfCar_ID { get; set; }
        [Display(Name = "Код вида автомобиля")]
        public long TypeOfCarID { get; set; }

        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
