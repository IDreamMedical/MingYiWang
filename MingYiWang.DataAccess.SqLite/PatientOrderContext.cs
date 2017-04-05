using MingYiWang.Business.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingYiWang.DataAccess.SqLite
{
    /// <summary>
    /// 预约上下文
    /// </summary>
    public class PatientOrderContext : SqLiteContext
    {

        public DbSet<PatientOrder> PatientOrders { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<PatientOrder>().ToTable("PatientOrder");
        }


        public void Save()
        {
            base.SaveChanges();
        }

    }
}
