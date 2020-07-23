namespace WindowsFormsApp6
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<Grading> Grading { get; set; }
        public virtual DbSet<Lesson> Lesson { get; set; }
        public virtual DbSet<Professor> Professor { get; set; }
        public virtual DbSet<Selectunit> Selectunit { get; set; }
        public virtual DbSet<student> student { get; set; }
        public virtual DbSet<spt_values> spt_values { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<spt_values>()
                .Property(e => e.type)
                .IsFixedLength();
        }
    }
}
