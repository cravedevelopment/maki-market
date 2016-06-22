using System;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations;
using MM.MMContext;

namespace MM.AspNet5.Migrations
{
    [DbContext(typeof(MMDbContext))]
    [Migration("20160622080541_MMMigration_1")]
    partial class MMMigration_1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0-rc1-16348")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MM.Models.Item", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<int>("ItemCode");

                    b.Property<int>("VendorId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MM.Models.ProducSubCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.Property<int>("ProductCategoryId");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MM.Models.ProductCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("Name");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MM.Models.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address");

                    b.Property<string>("ContactNumber");

                    b.Property<string>("FaxNumber");

                    b.Property<string>("TelNumber");

                    b.Property<string>("VendorName");

                    b.HasKey("Id");
                });

            modelBuilder.Entity("MM.Models.Item", b =>
                {
                    b.HasOne("MM.Models.Vendor")
                        .WithMany()
                        .HasForeignKey("VendorId");
                });

            modelBuilder.Entity("MM.Models.ProducSubCategory", b =>
                {
                    b.HasOne("MM.Models.ProductCategory")
                        .WithMany()
                        .HasForeignKey("ProductCategoryId");
                });
        }
    }
}
