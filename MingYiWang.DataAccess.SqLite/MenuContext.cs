using MingYiWang.Business.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.DataAccess.SqLite
{
    public class MenuContext : SqLiteContext
    {
        public DbSet<Menu> Menus { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Menu>().ToTable("Menu");
        }


        public void Save()
        {
            base.SaveChanges();
        }

    }
   
}
