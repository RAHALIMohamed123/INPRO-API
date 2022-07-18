

using INPRO.API.Models;
using Microsoft.EntityFrameworkCore;


namespace INPRO.API.Data
{
    public class DataContext : DbContext
    {
          public DataContext(DbContextOptions<DataContext> options) : base (options){}

          public  DbSet<User> Users { get; set; }  
          public  DbSet<Photo> Photos { get; set; }   
          public  DbSet<Product> Products { get; set; }  
          public  DbSet<Laboratory> Laboratories { get; set; }  
          public  DbSet<Dci> Dcis { get; set; }  
         
    }
}