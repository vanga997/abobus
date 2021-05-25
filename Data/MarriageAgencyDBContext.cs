using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using MarriageAgencyWeb.Models;

#nullable disable

namespace MarriageAgencyWeb.Data
{
    public partial class MarriageAgencyDBContext : DbContext
    {
        public MarriageAgencyDBContext()
        {
        }

        public MarriageAgencyDBContext(DbContextOptions<MarriageAgencyDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Client> Clients { get; set; }
        public virtual DbSet<Nationality> Nationalities { get; set; }
        public virtual DbSet<Position> Positions { get; set; }
        public virtual DbSet<Relation> Relations { get; set; }
        public virtual DbSet<Service> Services { get; set; }
        public virtual DbSet<Worker> Workers { get; set; }
        public virtual DbSet<ZodiacSign> ZodiacSigns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                //optionsBuilder.UseSqlite("DataSource = MarriageAgencyDB.db");
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=MarriageAgencyDB;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Client>(entity =>
            {
                entity.ToTable("Client");

                entity.Property(e => e.ClientId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Age).HasColumnType("INT");

                entity.Property(e => e.BadHabbits)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Birthday)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.FamilyStatus)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Height).HasColumnType("INT");

                entity.Property(e => e.Hobbies)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.InfoAboutPartner)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.NationalityId).HasColumnType("INT");

                entity.Property(e => e.NumberOfChild).HasColumnType("INT");

                entity.Property(e => e.Passport).HasColumnType("INT");

                entity.Property(e => e.RelationId).HasColumnType("INT");

                entity.Property(e => e.ServiceId).HasColumnType("INT");

                entity.Property(e => e.Weight).HasColumnType("INT");

                entity.Property(e => e.ZodiacId).HasColumnType("INT");

                entity.HasOne(d => d.Nationality)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.NationalityId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Relation)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.RelationId)
                    .OnDelete(DeleteBehavior.ClientSetNull);

                entity.HasOne(d => d.Service)
                    .WithMany(p => p.Clients)
                    .HasForeignKey(d => d.ServiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Nationality>(entity =>
            {
                entity.ToTable("Nationality");

                entity.Property(e => e.NationalityId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.NationalityName)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("Position");

                entity.Property(e => e.PositionId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.PositionName)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Requirements)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Responsibility)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Salary).HasColumnType("INT");
            });

            modelBuilder.Entity<Relation>(entity =>
            {
                entity.ToTable("Relation");

                entity.Property(e => e.RelationId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.RelationName)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");
            });

            modelBuilder.Entity<Service>(entity =>
            {
                entity.ToTable("Service");

                entity.Property(e => e.ServiceId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Cost).HasColumnType("INT");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnType("DATE");

                entity.Property(e => e.WorkerId).HasColumnType("INT");

                entity.HasOne(d => d.Worker)
                    .WithMany(p => p.Services)
                    .HasForeignKey(d => d.WorkerId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<Worker>(entity =>
            {
                entity.ToTable("Worker");

                entity.Property(e => e.WorkerId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Age).HasColumnType("INT");

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Gender)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.Passport).HasColumnType("INT");

                entity.Property(e => e.Phone).HasColumnType("INT");

                entity.Property(e => e.PositionId).HasColumnType("INT");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Workers)
                    .HasForeignKey(d => d.PositionId)
                    .OnDelete(DeleteBehavior.ClientSetNull);
            });

            modelBuilder.Entity<ZodiacSign>(entity =>
            {
                entity.HasKey(e => e.ZodiacId);

                entity.ToTable("ZodiacSign");

                entity.Property(e => e.ZodiacId)
                    .HasColumnType("INT")
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");

                entity.Property(e => e.ZodiacName)
                    .IsRequired()
                    .HasColumnType("NVARCHAR (255)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
