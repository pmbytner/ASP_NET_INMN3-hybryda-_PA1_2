﻿// <auto-generated />
using System;
using ASP_NET_INMN3_hybryda__PA1_2.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ASP_NET_INMN3_hybryda__PA1_2.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20231008142908_KolumnaWojewództwo")]
    partial class KolumnaWojewództwo
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ASP_NET_INMN3_hybryda__PA1_2.Models.Miasto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DataZałożenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nazwa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Populacja")
                        .HasColumnType("decimal(20,0)");

                    b.Property<decimal>("Powierzchnia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Województwo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Miasta");
                });
#pragma warning restore 612, 618
        }
    }
}
