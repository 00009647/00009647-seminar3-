using _00009647_seminar3_.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _00009647_seminar3_.DBContexts
{
    //DbContext represents a session with the database which can be used to query and save
    //instances of your entities to a database.
    public class ProductContext : DbContext
    {
        //Product Context class extends DB Context
        //We can not create dbcontext folder (project already has one), that`s why i called mine dbcontexts
        public ProductContext(DbContextOptions<ProductContext> options) : base(options){}
        public DbSet<Product> Products { get; set; }

       
    }
}
