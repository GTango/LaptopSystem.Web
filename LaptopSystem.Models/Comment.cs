using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSystem.Models
{
    public class Comment
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AuthorId { get; set; }

        
        public virtual User Author { get; set; }

      
        public int LaptopId { get; set; }


        
        public virtual Laptop Laptop { get; set; }

        [Required]
        public string  Content { get; set; }
    }
}
