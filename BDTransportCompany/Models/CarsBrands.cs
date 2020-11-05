using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BDTransportCompany.Models
{
    public class CarsBrands
    {
        public long ID { get; set; }

        [Display(Name = "Код марки")]
        public long CarBrand_ID { get; set; }
        [Display(Name = "Наименование")]
        public string Title { get; set; }
        [Display(Name = "Технические характеристики")]
        public string Specifications { get; set; }
        [Display(Name = "Описание")]
        public string Description { get; set; }
    }
}
