using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace CourseExplorerAPI.Models;

public partial class CoursesDbContext : DbContext
{
    public CoursesDbContext()
    {
    }

    public CoursesDbContext(DbContextOptions<CoursesDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Course> Courses { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.\\sqlexpress;Initial Catalog=CoursesDB; Integrated Security=SSPI;Encrypt=false;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Course>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Course__3214EC27A1DB5732");

            entity.ToTable("Course");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Cat).HasMaxLength(50);
            entity.Property(e => e.CatDes).HasMaxLength(3);
            entity.Property(e => e.CourseName).HasMaxLength(255);
            entity.Property(e => e.CourseNumber).HasMaxLength(255);
            entity.Property(e => e.Description).HasMaxLength(3000);
            entity.Property(e => e.Equivalent).HasMaxLength(50);
            entity.Property(e => e.Geoutcomes)
                .HasMaxLength(80)
                .HasColumnName("GEOutcomes");
            entity.Property(e => e.Note).HasMaxLength(350);
            entity.Property(e => e.Prereqs).HasMaxLength(80);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
