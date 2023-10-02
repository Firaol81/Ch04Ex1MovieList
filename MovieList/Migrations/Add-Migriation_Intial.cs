﻿// MovieContextModelSnapshot.cs
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MovieList.Models;

namespace MovieList.Migrations
{
    [DbContext(typeof(MovieContext))]
    partial class MovieContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview5.19227.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Ch04MovieList.Models.Movie", b =>
            {
                b.Property<int>("MovieId")
                    .ValueGeneratedOnAdd()
                    .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                b.Property<string>("Name")
                    .IsRequired();

                b.Property<int>("Rating")
                    .IsRequired();

                b.Property<int>("Year")
                    .IsRequired();

                b.HasKey("MovieId");

                b.ToTable("Movies");

                b.HasData(
                    new
                    {
                        MovieId = 1,
                        Name = "Casablanca",
                        Rating = 5,
                        Year = 1943
                    },
                    new
                    {
                        MovieId = 2,
                        Name = "Wonder Woman",
                        Rating = 3,
                        Year = 2017
                    },
                    new
                    {
                        MovieId = 3,
                        Name = "Moonstruck",
                        Rating = 4,
                        Year = 1988
                    });
            });
#pragma warning restore 612, 618
        }
    }
}
