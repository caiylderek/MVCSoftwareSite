using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSoftwareSite.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(250)]
        public string Description { get; set; }
        [Required]
        public double Price { get; set; }
        public string ImageLink { get; set; }
        public virtual ICollection<Rating> Ratings { get; set; }
    }
}
