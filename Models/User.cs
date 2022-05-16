using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Adresbook.Models
{
    public class User
    {
        public int Id { get; set; }
        [Required (ErrorMessage = "Не указано имя")]
        [RegularExpression(@"[A-Za-z] ", ErrorMessage ="Неверный формат имени")]
        public string Name { get; set; }
        [Required (ErrorMessage = "Не указан номер телефона")]
        public string Phone { get; set; }
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Не указан электронный адрес")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Не указана дата рождения")]
        public DateTime Birhday { get; set; }
    }
}
