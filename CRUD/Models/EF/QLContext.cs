namespace CRUD.Models.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QLContext : DbContext
    {
        public QLContext()
            : base("name=QLContext")
        {
        }

        public virtual DbSet<nhomsp> nhomsps { get; set; }
        public virtual DbSet<sanpham> sanphams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
