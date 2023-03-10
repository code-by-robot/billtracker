// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesBill.Data;

#nullable disable

namespace RazorPagesBill.Migrations
{
    [DbContext(typeof(BillContext))]
    partial class BillContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.3");

            modelBuilder.Entity("RazorPagesBill.Models.Bill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BillName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BillType")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsLaw")
                        .HasColumnType("INTEGER");

                    b.Property<string>("StateName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Bills");
                });
#pragma warning restore 612, 618
        }
    }
}
