using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Project.Data.Models
{
    public class Flower
    {
        [Key]
        public int Id { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
        public string Color { get; set; }
        [ForeignKey("Category")]
        public int IdCategory { get; set; }
        public string img { get; set; }
    }
}
