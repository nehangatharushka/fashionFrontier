using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace fashionFrontier.Models
{
    public partial class fashionfrontierContext : DbContext
    {
        public fashionfrontierContext()
        {
        }

        public fashionfrontierContext(DbContextOptions<fashionfrontierContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
               // optionsBuilder.UseMySQL("server=localhost;user id=root;password=root;database=fashionfrontier;port=3306;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.Prodid)
                    .HasName("PRIMARY");

                entity.ToTable("product");

                entity.Property(e => e.Prodid).HasColumnName("prodid");

                entity.Property(e => e.Branding)
                    .HasMaxLength(255)
                    .HasColumnName("branding");

                entity.Property(e => e.Category)
                    .IsRequired()
                    .HasMaxLength(255)
                    .HasColumnName("category");

                entity.Property(e => e.CreateDateTime).HasColumnName("createDateTime");

                entity.Property(e => e.ImgUrl)
                    .HasMaxLength(255)
                    .HasColumnName("imgUrl");

                entity.Property(e => e.Predition).HasColumnName("predition");

                entity.Property(e => e.ProdName)
                    .HasMaxLength(255)
                    .HasColumnName("prodName");

                entity.Property(e => e.Tags)
                    .HasMaxLength(255)
                    .HasColumnName("tags");

                entity.Property(e => e.UpdateDateTime).HasColumnName("updateDateTime");

                entity.Property(e => e.WearType)
                    .HasMaxLength(255)
                    .HasColumnName("wearType");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
