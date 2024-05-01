using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Models
{
    public class CreatingOrder
    {
        [Required]
        [MinLength(2)]
        public string FirstName { get; set; }
        [Required]
        [MinLength(2)]
        public string LastName { get; set; }
        [MinLength(13, ErrorMessage = "Потрібно ввести 10 чисел та номер країни")]
        [StringLength(13, ErrorMessage = "Потрібно ввести 10 чисел та номер країни")]
        [RegularExpression(@"^\+380\d{9}$", ErrorMessage = "Потрібно ввести 10 чисел та номер країни")]
        public string Phone { get; set; }
        [MaxLength(255)]
        public string Comment { get; set; }
        [MaxLength(50)]
        [MinLength(3)]
        public string Address { get; set; }
    }
}
