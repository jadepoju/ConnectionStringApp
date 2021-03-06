﻿// <auto-generated />
using System;
using ConnectionStringApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConnectionStringApp.Migrations
{
    [DbContext(typeof(ProductContext))]
    partial class ProductContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Models.Entities.Category", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = new Guid("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"),
                            CreatedOn = new DateTime(2020, 8, 27, 16, 17, 41, 434, DateTimeKind.Local).AddTicks(1058),
                            Description = "Very Sporty",
                            Name = "Sport Cars"
                        },
                        new
                        {
                            Id = new Guid("5ade63d4-abf0-4b09-b018-04c99d31f6e1"),
                            CreatedOn = new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7410),
                            Description = "Very Flying",
                            Name = "Aeroplane"
                        },
                        new
                        {
                            Id = new Guid("8bc51e94-bb2f-4f69-bf12-b9b0826d0263"),
                            CreatedOn = new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7485),
                            Description = "Computer i guess",
                            Name = "Laptop"
                        },
                        new
                        {
                            Id = new Guid("b5d459d0-d2e2-403a-b88b-f00fa5a192f9"),
                            CreatedOn = new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7494),
                            Description = "Use for making calls and what again?",
                            Name = "Smart Phone"
                        },
                        new
                        {
                            Id = new Guid("8a6cd291-78d2-4468-bfc5-5c795ffc0c8e"),
                            CreatedOn = new DateTime(2020, 8, 27, 16, 17, 41, 436, DateTimeKind.Local).AddTicks(7499),
                            Description = "What is Jake? of course you know Jake",
                            Name = "Jake"
                        });
                });

            modelBuilder.Entity("Models.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CategoryId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("ProductDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ef076389-b608-4d32-ac38-5f3c7c8dca32"),
                            CategoryId = new Guid("8bc51e94-bb2f-4f69-bf12-b9b0826d0263"),
                            CreatedAt = new DateTime(2020, 8, 27, 16, 17, 41, 437, DateTimeKind.Local).AddTicks(9220),
                            ProductDescription = "Mac Book pro from Apple",
                            ProductName = "Macbook Pro 13"
                        },
                        new
                        {
                            Id = new Guid("2292b9a7-d37d-49b9-bea9-67fdeb23eac8"),
                            CategoryId = new Guid("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"),
                            CreatedAt = new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1096),
                            ProductDescription = "This is another fast car for racing, You mean Asphat 9? oh yeah",
                            ProductName = "Ferrari Koeniggseg"
                        },
                        new
                        {
                            Id = new Guid("0b779d52-ee94-4870-8b61-6b4bc6ddb41c"),
                            CategoryId = new Guid("97cfbb55-1cbf-45b3-90e5-7fcf7a530076"),
                            CreatedAt = new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1159),
                            ProductDescription = "Its a very fast car, i think",
                            ProductName = "Lamboghini Vandetta"
                        },
                        new
                        {
                            Id = new Guid("717ccd4e-da97-4631-881a-40eb624f6c51"),
                            CategoryId = new Guid("b5d459d0-d2e2-403a-b88b-f00fa5a192f9"),
                            CreatedAt = new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1207),
                            ProductDescription = "Never heard of that smartphone, i guess its for alien",
                            ProductName = "Samsung Galaxy Mars X"
                        },
                        new
                        {
                            Id = new Guid("9242e049-5d69-4cbc-a0c9-4664eb439749"),
                            CategoryId = new Guid("8a6cd291-78d2-4468-bfc5-5c795ffc0c8e"),
                            CreatedAt = new DateTime(2020, 8, 27, 16, 17, 41, 438, DateTimeKind.Local).AddTicks(1214),
                            ProductDescription = "What is that exactly?",
                            ProductName = "JAKE SR71 Valkyrie"
                        });
                });

            modelBuilder.Entity("Models.Entities.Product", b =>
                {
                    b.HasOne("Models.Entities.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
