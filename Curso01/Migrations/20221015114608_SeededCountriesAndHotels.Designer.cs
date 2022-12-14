// <auto-generated />
using Curso01.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Curso01.Migrations
{
    [DbContext(typeof(Curso01DbContext))]
    [Migration("20221015114608_SeededCountriesAndHotels")]
    partial class SeededCountriesAndHotels
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Curso01.Data.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Countries");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Brasil",
                            ShortName = "BR"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Ireland",
                            ShortName = "IRL"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Italy",
                            ShortName = "ITA"
                        });
                });

            modelBuilder.Entity("Curso01.Data.Hotel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CountryId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Rating")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("Hotels");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Av. Atlantica",
                            CountryId = 1,
                            Name = "Copacabana Palace",
                            Rating = 4.5
                        },
                        new
                        {
                            Id = 2,
                            Address = "50, Dorset Street Upper",
                            CountryId = 2,
                            Name = "Clayton Hotel",
                            Rating = 4.2000000000000002
                        },
                        new
                        {
                            Id = 3,
                            Address = "Via della Taormina, 15",
                            CountryId = 3,
                            Name = "Bella Taormina",
                            Rating = 4.0
                        });
                });

            modelBuilder.Entity("Curso01.Data.Hotel", b =>
                {
                    b.HasOne("Curso01.Data.Country", "Country")
                        .WithMany("Hotels")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Curso01.Data.Country", b =>
                {
                    b.Navigation("Hotels");
                });
#pragma warning restore 612, 618
        }
    }
}
