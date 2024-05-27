using Microsoft.EntityFrameworkCore;
using One.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace One.Data
{
    public class Db:DbContext
    {
        public Db(DbContextOptions<Db> options) : base(options)
        {
        }
        public DbSet<Product> tblproducts { get; set; }
    }
}
