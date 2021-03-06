// <auto-generated />
using System;
using MarriageAgencyWeb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MarriageAgencyWeb.Migrations
{
    [DbContext(typeof(MarriageAgencyDBContext))]
    [Migration("20210523182705_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.6")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MarriageAgencyWeb.Models.Client", b =>
                {
                    b.Property<int>("ClientId")
                        .HasColumnType("INT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<int>("Age")
                        .HasColumnType("INT");

                    b.Property<string>("BadHabbits")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<DateTime>("Birthday")
                        .HasColumnType("DATE");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("FamilyStatus")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<int>("Height")
                        .HasColumnType("INT");

                    b.Property<string>("Hobbies")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("InfoAboutPartner")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<int>("NationalityId")
                        .HasColumnType("INT");

                    b.Property<int>("NumberOfChild")
                        .HasColumnType("INT");

                    b.Property<int>("Passport")
                        .HasColumnType("INT");

                    b.Property<int>("RelationId")
                        .HasColumnType("INT");

                    b.Property<int>("ServiceId")
                        .HasColumnType("INT");

                    b.Property<int>("Weight")
                        .HasColumnType("INT");

                    b.Property<int>("ZodiacId")
                        .HasColumnType("INT");

                    b.HasKey("ClientId");

                    b.HasIndex("NationalityId");

                    b.HasIndex("RelationId");

                    b.HasIndex("ServiceId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .HasColumnType("INT");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("NationalityName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationality");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Position", b =>
                {
                    b.Property<int>("PositionId")
                        .HasColumnType("INT");

                    b.Property<string>("PositionName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("Requirements")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("Responsibility")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<int>("Salary")
                        .HasColumnType("INT");

                    b.HasKey("PositionId");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Relation", b =>
                {
                    b.Property<int>("RelationId")
                        .HasColumnType("INT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("RelationName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.HasKey("RelationId");

                    b.ToTable("Relation");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Service", b =>
                {
                    b.Property<int>("ServiceId")
                        .HasColumnType("INT");

                    b.Property<int>("Cost")
                        .HasColumnType("INT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("DATE");

                    b.Property<int>("WorkerId")
                        .HasColumnType("INT");

                    b.HasKey("ServiceId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Service");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Worker", b =>
                {
                    b.Property<int>("WorkerId")
                        .HasColumnType("INT");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<int>("Age")
                        .HasColumnType("INT");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<int>("Passport")
                        .HasColumnType("INT");

                    b.Property<int>("Phone")
                        .HasColumnType("INT");

                    b.Property<int>("PositionId")
                        .HasColumnType("INT");

                    b.HasKey("WorkerId");

                    b.HasIndex("PositionId");

                    b.ToTable("Worker");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.ZodiacSign", b =>
                {
                    b.Property<int>("ZodiacId")
                        .HasColumnType("INT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.Property<string>("ZodiacName")
                        .IsRequired()
                        .HasColumnType("NVARCHAR (255)");

                    b.HasKey("ZodiacId");

                    b.ToTable("ZodiacSign");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Client", b =>
                {
                    b.HasOne("MarriageAgencyWeb.Models.Nationality", "Nationality")
                        .WithMany("Clients")
                        .HasForeignKey("NationalityId")
                        .IsRequired();

                    b.HasOne("MarriageAgencyWeb.Models.Relation", "Relation")
                        .WithMany("Clients")
                        .HasForeignKey("RelationId")
                        .IsRequired();

                    b.HasOne("MarriageAgencyWeb.Models.Service", "Service")
                        .WithMany("Clients")
                        .HasForeignKey("ServiceId")
                        .IsRequired();

                    b.Navigation("Nationality");

                    b.Navigation("Relation");

                    b.Navigation("Service");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Service", b =>
                {
                    b.HasOne("MarriageAgencyWeb.Models.Worker", "Worker")
                        .WithMany("Services")
                        .HasForeignKey("WorkerId")
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Worker", b =>
                {
                    b.HasOne("MarriageAgencyWeb.Models.Position", "Position")
                        .WithMany("Workers")
                        .HasForeignKey("PositionId")
                        .IsRequired();

                    b.Navigation("Position");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Nationality", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Position", b =>
                {
                    b.Navigation("Workers");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Relation", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Service", b =>
                {
                    b.Navigation("Clients");
                });

            modelBuilder.Entity("MarriageAgencyWeb.Models.Worker", b =>
                {
                    b.Navigation("Services");
                });
#pragma warning restore 612, 618
        }
    }
}
