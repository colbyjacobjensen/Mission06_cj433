// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_cj433.Models;

namespace Mission06_cj433.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    [Migration("20230214063159_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.32");

            modelBuilder.Entity("Mission06_cj433.Models.FormResponse", b =>
                {
                    b.Property<int>("MovieID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Director")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Edited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LentTo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .HasColumnType("TEXT")
                        .HasMaxLength(25);

                    b.Property<string>("Rating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<short>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("MovieID");

                    b.ToTable("Responses");

                    b.HasData(
                        new
                        {
                            MovieID = 1,
                            Category = "Action/Adventure",
                            Director = "Matt Reaves",
                            Edited = false,
                            LentTo = "",
                            Notes = "This was my favorite movie in 2022.",
                            Rating = "PG-13",
                            Title = "The Batman",
                            Year = (short)2022
                        },
                        new
                        {
                            MovieID = 2,
                            Category = "Western",
                            Director = "Sergio Leone",
                            Edited = false,
                            LentTo = "",
                            Notes = "",
                            Rating = "PG-13",
                            Title = "Once Upon a Time in the West",
                            Year = (short)1968
                        },
                        new
                        {
                            MovieID = 3,
                            Category = "Action/Adventure",
                            Director = "Ridley Scott",
                            Edited = true,
                            LentTo = "Olivia Jensen",
                            Notes = "This is one of my favorites!",
                            Rating = "R",
                            Title = "Gladiator",
                            Year = (short)2000
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
