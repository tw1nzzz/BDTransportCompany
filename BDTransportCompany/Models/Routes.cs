using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDTransportCompany.Models
{
    public class Routes
    {
        public long ID { get; set; }
        [Display(Name = "Автомобиль")]
        public DbSet<Cars> Car_ID { get; set; }
        [Display(Name = "Код автомобиля")]
        public long CarID { get; set; }
        [Display(Name = "Заказчик")]
        public string Customer { get; set; }
        [Display(Name = "Откуда")]
        public string WhereFrom { get; set; }
        [Display(Name = "Куда")]
        public string Where { get; set; }
        [Display(Name = "Дата отправления")]
        public DateTime DateOfDeparture { get; set; }
        [Display(Name = "Дата прибытия")]
        public DateTime DateOfArrival { get; set; }
        [Display(Name = "Груз")]
        public DbSet<Cargos> Cargo_ID { get; set; }
        [Display(Name = "Код груза")]
        public long CargoID { get; set; }
        [Display(Name = "Цена")]
        public int Price { get; set; }
        [Display(Name = "Отметка об оплате")]
        public string RecordOfThePayment { get; set; }
        [Display(Name = "Отметка о возвращении")]
        public string TheMarkOnTheReturn { get; set; }
        [Display(Name = "Cотрудник")]
        public DbSet<Staff> Staff_ID { get; set; }
        [Display(Name = "Код сотрудника")]
        public long StaffID { get; set; }
    }
}
