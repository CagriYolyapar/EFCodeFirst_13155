using EFCodeFirst_1.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCodeFirst_1.Models.Context
{
    public class MyContext:DbContext
    {
        public MyContext() : base("MySqlConnection")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppUser>().HasOptional(x => x.Profile).WithRequired(x => x.AppUser); //birebir ilişkinin tamamlanmasıdır...Bu noktada AppUser tarafını önce ele alıp ona Profilin Opsiyonel olabilir diyoruz(istersen eklemeyebilirsin de)...x.Profile dedigimiz anda syntax bir sonraki metodumuzda bizim lambda ifademizi AppUserProfile tipini desteklemek üzere şekillendirir cünkü HasOptional'da yazdıgımız x.Profile'daki Profile'in tipi AppUserProfile'dir...

            modelBuilder.Entity<OrderDetail>().Ignore(x => x.ID);
            modelBuilder.Entity<OrderDetail>().HasKey(x => new
            {
                x.OrderID,
                x.ProductID
            });
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppUserProfile> Profiles { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }

    }
}
