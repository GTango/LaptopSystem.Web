using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSystem.Models
{
    public class Laptop
    {
        private ICollection<Comment> coments;
        private ICollection<Vote> votes;


        public Laptop()
        {
            this.coments = new HashSet<Comment>();
            this.votes = new HashSet<Vote>();
        }



        [Key]
        public int Id { get; set; }

        [Required]
        public int ManufacturerId { get; set; }

      
        public virtual Manufacturer Manufacturer { get; set; }

        [Required]
        public string Model { get; set; }

        //inches
        [Required]
        public double MonitorSize { get; set; }

        //GB
        [Required]
        public int HardDiskSize { get; set; }

        //GB
        [Required]
        public int RamMemorySize { get; set; }

        [Required]
        public string ImageUrl { get; set; }

        [Required]
        public decimal Price { get; set; }

        //kg
        public double? Weight { get; set; }

        

        public string AdditionalParts  { get; set; }

        public string Description { get; set; }




        public virtual ICollection<Comment> Comments

        {
            get { return this.coments; }
            set { this.coments = value; }
        }

        public virtual ICollection<Vote> Votes

        {
            get { return this.votes; }
            set { this.votes = value; }
        }

    }
}
