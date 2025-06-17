using Microsoft.EntityFrameworkCore;
using oop_temelleri_1.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace oop_temelleri_1.ProjeContext
{
    //kalitim-miras alma ?
    public class Context: DbContext
    {
        //veritabanı bağlama
        //override on
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=.;database=DbNewOopCore;integrated security=true;TrustServerCertificate=True;");
        }

        //<> icindekini kullanabilmek icin ctrl . ile eklenmeli
        public DbSet<Product> Products { get; set; } 
        //<c# adı> sql adi -- ilk harfleri buyuk olsun
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }



    }
}
