using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCSoftwareSite.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int Score { get; set; }
        public int UserId { get; set; } 
        public virtual User User { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
