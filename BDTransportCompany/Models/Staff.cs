using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace BDTransportCompany.Models
{
    public class Staff
    {
        public long ID { get; set; }

        [Display(Name = "Код сотрудника")]
        public long Staff_ID{ get; set; }
        [Display(Name = "ФИО")]
        public string FullName { get; set; }
        [Display(Name = "Возраст")]
        public int Age { get; set; }
        [Display(Name = "Пол")]
        public string Gender { get; set; }
        [Display(Name = "Адрес")]
        public string Adress { get; set; }
        [Display(Name = "Телефон")]
        public string PhoneNumber { get; set; }
        [Display(Name = "Паспортные данные")]
        public string PassportData { get; set; }
        [Display(Name = "Должность")]
        public DbSet<Positions> Position_ID { get; set; }
        [Display(Name = "Код должности")]
        public long PositionID { get; set; }

    }
}
