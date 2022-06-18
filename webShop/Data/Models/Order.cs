using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace webShop.Data.Models
{
    public class Order
    {
        [BindNever]
        public int id { get; set; }

        [Display(Name = "Введіть ім'я")]
        [StringLength(3)]
        [Required(ErrorMessage = "Довжинна імені не менше 3 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(5)]
        [Required(ErrorMessage = "Довжинна прізвища не менше 5 символів")]
        public string surname { get; set; }

        [Display(Name = "Адреса")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжинна адреси не менше 10 символів")]
        public string adress { get; set; }

        [Display(Name = "Номер телефону")]
        [StringLength(10)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Довжинна номера телефону не менше 10 символів")]
        public string phone { get; set; }

        [Display(Name = "email")]
        [StringLength(10)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Довжинна email не менше 10 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
