using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDTransportCompany.Models
{
    public class Cars
    {
        public long ID { get; set; }

        [Display(Name = "Код автомобиля")]
        public long Car_ID { get; set; }

        [Display(Name = "Марка")]
        public DbSet<CarsBrands> CarBrand_ID { get; set; }
        [Display(Name = "Код марки")]
        public long CarBrandID { get; set; }

        [Display(Name = "Вид автомобиля")]
        public DbSet<TypesOfCars> TypeOfCar_ID { get; set; }
        [Display(Name = "Код вида автомобиля")]
        public long TypeOfCarID { get; set; }
        [Display(Name = "Регистрационный номер")]
        public int RegistrationNumber { get; set; }
        [Display(Name = "Номер кузова")]
        public int BodyNumber { get; set; }
        [Display(Name = "Номер двигателя")]
        public int EngineNumber { get; set; }
        [Display(Name = "Год выпуска")]
        public DateTime YearOfIssue { get; set; }
        [Display(Name = "Сотрудник-водитель")]
         public DbSet<Staff> Position_ID1 { get; set; }
        [Display(Name = "Код сотрудника-водителя")]
        public long PositionID1 { get; set; }

        [Display(Name = "Дата последнего ТО")]
        public DateTime LastMaintenanceDate { get; set; }
        [Display(Name = "Сотрудник-механик")]
        public DbSet<Staff> Position_ID2 { get; set; }
        [Display(Name = "Код сотрудника-механика")]
        public long PositionID2 { get; set; }
    }
}
