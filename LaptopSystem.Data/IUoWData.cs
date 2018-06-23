using LaptopSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaptopSystem.Data
{
    public interface IUoWData
    {
        IRepository<User> Users { get; }
        IRepository<Manufacturer> Manufacturers { get; }
        IRepository<Laptop> Laptops { get; }
        IRepository<Comment> Comments { get; }
        IRepository<Vote> Votes { get; }

        int SaveChanges();
    }
}
