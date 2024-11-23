using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models;

public partial class DbLibrarymangementContext : DbContext
{
    public DbLibrarymangementContext()
    {
    }

    public DbLibrarymangementContext(DbContextOptions<DbLibrarymangementContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Book> Books { get; set; }

    public virtual DbSet<LibAdmin> LibAdmins { get; set; }

    public virtual DbSet<LibUser> LibUsers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
         if(!optionsBuilder.IsConfigured){
            
        }
    }
        

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__books__3213E83FAF10CB88");

            entity.ToTable("books");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Author)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("author");
            entity.Property(e => e.Genre)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("genre");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("title");
        });

        modelBuilder.Entity<LibAdmin>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lib_Admi__3213E83F85352AB4");

            entity.ToTable("lib_Admin");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
        });

        modelBuilder.Entity<LibUser>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__lib_User__3213E83F3D52954B");

            entity.ToTable("lib_User");

            entity.Property(e => e.Id)
                .ValueGeneratedNever()
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("email");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("firstName");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("lastName");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("password");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("phone");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
