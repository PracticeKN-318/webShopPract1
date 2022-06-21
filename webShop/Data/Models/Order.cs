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
        [StringLength(10)]
        [Required(ErrorMessage = "Довжинна імені менше 11 символів")]
        public string name { get; set; }

        [Display(Name = "Введіть прізвище")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжинна прізвища менше 11 символів")]
        public string surname { get; set; }

        [Display(Name = "Адреса")]
        [StringLength(10)]
        [Required(ErrorMessage = "Довжинна адреси менше 11 символів")]
        public string adress { get; set; }

        [Display(Name = "Номер телефону")]
        [StringLength(15)]
        [DataType(DataType.PhoneNumber)]
        [Required(ErrorMessage = "Довжинна номера телефону менше 16 символів")]
        public string phone { get; set; }

        [Display(Name = "email")]
        [StringLength(20)]
        [DataType(DataType.EmailAddress)]
        [Required(ErrorMessage = "Довжинна email менше 20 символів")]
        public string email { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public DateTime orderTime { get; set; }

        [BindNever]
        [ScaffoldColumn(false)]
        public List<OrderDetail> orderDetails { get; set; }
    }
}
