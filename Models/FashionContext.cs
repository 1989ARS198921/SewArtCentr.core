using System;
using Microsoft.EntityFrameworkCore;

namespace SewArtCentr.Models
{
    public class FashionContext : DbContext
    {
        public DbSet<FashionColl> FashionColls {get; set;}
    public DbSet <Order> Orders { get; set; }
   
    public FashionContext(DbContextOptions<FashionContext> options)
    :base(options)
    {
        Database.EnsureCreated();
    }
    }
}
