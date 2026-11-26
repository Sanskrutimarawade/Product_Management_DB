using Microsoft.EntityFrameworkCore;
using ProductManagement.Api.Models;


namespace ProductManagement.Api.Data
{
    public class ApplicationDbContext: DbContext
    {

            public ApplicationDbContext( DbContextOptions<ApplicationDbContext> options)  
             : base(options)
            {

            }  
            
            public DbSet<Product> Products { get; set; }
            
    }
 }

