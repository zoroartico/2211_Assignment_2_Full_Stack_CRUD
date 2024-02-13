﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _2211_Assignment_2_Full_Stack_CRUD.Models;

#nullable disable

namespace _2211_Assignment_2_Full_Stack_CRUD.Migrations
{
    [DbContext(typeof(ContactContext))]
    [Migration("20240213043604_AlterOrganizationToBusinessColumnName")]
    partial class AlterOrganizationToBusinessColumnName
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("_2211_Assignment_2_Full_Stack_CRUD.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CategoryId"));

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryName = "Friend"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryName = "Boss"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryName = "Co-Worker"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryName = "Subordinate"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryName = "Family"
                        },
                        new
                        {
                            CategoryId = 6,
                            CategoryName = "Acquaintance"
                        },
                        new
                        {
                            CategoryId = 7,
                            CategoryName = "Enemy"
                        });
                });

            modelBuilder.Entity("_2211_Assignment_2_Full_Stack_CRUD.Models.Contact", b =>
                {
                    b.Property<int>("ContactId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ContactId"));

                    b.Property<string>("Business")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ContactId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Contacts");

                    b.HasData(
                        new
                        {
                            ContactId = 1,
                            Business = "Test Business",
                            CategoryId = 1,
                            Email = "Test Email",
                            FirstName = "Test FirstName",
                            LastName = "Test LastName",
                            Phone = "1231231233"
                        },
                        new
                        {
                            ContactId = 2,
                            Business = "Test Business",
                            CategoryId = 2,
                            Email = "Test Email",
                            FirstName = "Test FirstName",
                            LastName = "Test LastName",
                            Phone = "2342342344"
                        },
                        new
                        {
                            ContactId = 3,
                            Business = "Test Business",
                            CategoryId = 3,
                            Email = "Test Email",
                            FirstName = "Test FirstName",
                            LastName = "Test LastName",
                            Phone = "3453453455"
                        });
                });

            modelBuilder.Entity("_2211_Assignment_2_Full_Stack_CRUD.Models.Contact", b =>
                {
                    b.HasOne("_2211_Assignment_2_Full_Stack_CRUD.Models.Category", "Category")
                        .WithMany()
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Category");
                });
#pragma warning restore 612, 618
        }
    }
}
