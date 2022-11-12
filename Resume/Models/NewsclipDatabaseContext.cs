using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Resume.Models;

public partial class NewsclipDatabaseContext : DbContext
{
    public NewsclipDatabaseContext()
    {
    }

    public NewsclipDatabaseContext(DbContextOptions<NewsclipDatabaseContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Education> Educations { get; set; }

    public virtual DbSet<Experience> Experiences { get; set; }

    public virtual DbSet<PersonalInfo> PersonalInfos { get; set; }

    public virtual DbSet<Skill> Skills { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    //#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("");
    //As ek die uithaal dan kak hy

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Education>(entity =>
        {
            entity.HasKey(e => e.EduId).HasName("PK__Educatio__1FD9490E3BE2FCC8");

            entity.ToTable("Education");

            entity.Property(e => e.SchoolName).HasColumnType("text");
        });

        modelBuilder.Entity<Experience>(entity =>
        {
            entity.HasKey(e => e.ExpId).HasName("PK__Experien__45B117E79F8F9BFB");

            entity.ToTable("Experience");

            entity.Property(e => e.Address).HasColumnType("text");
            entity.Property(e => e.EndDate)
                .HasColumnType("date")
                .HasColumnName("End Date");
            entity.Property(e => e.Name).HasColumnType("text");
            entity.Property(e => e.ReferenceContact)
                .HasColumnType("text")
                .HasColumnName("Reference Contact");
            entity.Property(e => e.StartDate)
                .HasColumnType("date")
                .HasColumnName("Start Date");
            entity.Property(e => e.Title).HasColumnType("text");
        });

        modelBuilder.Entity<PersonalInfo>(entity =>
        {
            entity.HasKey(e => e.PerId).HasName("PK__Personal__496D3DD077AA547D");

            entity.ToTable("PersonalInfo");

            entity.Property(e => e.About).HasColumnType("text");
            entity.Property(e => e.Contact).HasColumnType("text");
            entity.Property(e => e.Email).HasColumnType("text");
            entity.Property(e => e.Name).HasColumnType("text");
        });

        modelBuilder.Entity<Skill>(entity =>
        {
            entity.HasKey(e => e.SkillsId).HasName("PK__Skills__95A17ED55B3D1C79");

            entity.Property(e => e.Name).HasColumnType("text");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
