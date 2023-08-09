﻿// <auto-generated />
using DataAccesLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccesLayer.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EntityLayer.Concrete.Bolum", b =>
                {
                    b.Property<int>("BolumID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BolumID"), 1L, 1);

                    b.Property<string>("BolumAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FakulteID")
                        .HasColumnType("int");

                    b.HasKey("BolumID");

                    b.HasIndex("FakulteID");

                    b.ToTable("Bolums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ders", b =>
                {
                    b.Property<int>("DersID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersID"), 1L, 1);

                    b.Property<int>("BolumID")
                        .HasColumnType("int");

                    b.Property<string>("DersAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgretmenID")
                        .HasColumnType("int");

                    b.HasKey("DersID");

                    b.HasIndex("BolumID");

                    b.HasIndex("OgretmenID");

                    b.ToTable("Derses");
                });

            modelBuilder.Entity("EntityLayer.Concrete.DersListesi", b =>
                {
                    b.Property<int>("DersListesiID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DersListesiID"), 1L, 1);

                    b.Property<int>("DersID")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.HasKey("DersListesiID");

                    b.HasIndex("DersID");

                    b.HasIndex("OgrenciID");

                    b.ToTable("DersListesi");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Devamsızlık", b =>
                {
                    b.Property<int>("DevamsızlıkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DevamsızlıkID"), 1L, 1);

                    b.Property<int>("DersListesiID")
                        .HasColumnType("int");

                    b.Property<bool>("DevamsızlıkDurumu")
                        .HasColumnType("bit");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.HasKey("DevamsızlıkID");

                    b.HasIndex("DersListesiID");

                    b.HasIndex("OgrenciID");

                    b.ToTable("Devamsızlıks");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Fakulte", b =>
                {
                    b.Property<int>("FakulteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FakulteID"), 1L, 1);

                    b.Property<string>("FakulteAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FakulteID");

                    b.ToTable("Fakultes");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Login", b =>
                {
                    b.Property<int>("LoginID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LoginID"), 1L, 1);

                    b.Property<string>("LoginPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LoginRole")
                        .HasColumnType("bit");

                    b.Property<string>("LoginUserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OgrenciID")
                        .HasColumnType("int");

                    b.Property<int>("OgretmenID")
                        .HasColumnType("int");

                    b.HasKey("LoginID");

                    b.HasIndex("OgrenciID");

                    b.HasIndex("OgretmenID");

                    b.ToTable("Logins");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Not", b =>
                {
                    b.Property<int>("NotID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NotID"), 1L, 1);

                    b.Property<int>("DersListesiID")
                        .HasColumnType("int");

                    b.Property<int>("FinalNotu")
                        .HasColumnType("int");

                    b.Property<decimal>("Ortalama")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("VizeNotu")
                        .HasColumnType("int");

                    b.HasKey("NotID");

                    b.HasIndex("DersListesiID");

                    b.ToTable("Nots");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogrenci", b =>
                {
                    b.Property<int>("OgrenciID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgrenciID"), 1L, 1);

                    b.Property<int>("BolumID")
                        .HasColumnType("int");

                    b.Property<string>("OgrenciAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciTC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgrenciTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgrenciID");

                    b.HasIndex("BolumID");

                    b.ToTable("Ogrencis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogretmen", b =>
                {
                    b.Property<int>("OgretmenID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OgretmenID"), 1L, 1);

                    b.Property<string>("OgretmenAdi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenAdres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenSoyadi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenTC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OgretmenTel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OgretmenID");

                    b.ToTable("Ogretmens");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bolum", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Fakulte", "Fakulte")
                        .WithMany("Bolums")
                        .HasForeignKey("FakulteID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fakulte");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ders", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Bolum", "Bolum")
                        .WithMany("Derses")
                        .HasForeignKey("BolumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Ogretmen", "Ogretmen")
                        .WithMany("Derses")
                        .HasForeignKey("OgretmenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("EntityLayer.Concrete.DersListesi", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Ders", "Ders")
                        .WithMany("DersListesis")
                        .HasForeignKey("DersID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("DersListesis")
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Devamsızlık", b =>
                {
                    b.HasOne("EntityLayer.Concrete.DersListesi", "DersListesi")
                        .WithMany("Devamsızlıks")
                        .HasForeignKey("DersListesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Ogrenci", "Ogrenci")
                        .WithMany("Devamsızlıks")
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DersListesi");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Login", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Ogrenci", "Ogrenci")
                        .WithMany()
                        .HasForeignKey("OgrenciID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EntityLayer.Concrete.Ogretmen", "Ogretmen")
                        .WithMany("Logins")
                        .HasForeignKey("OgretmenID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ogrenci");

                    b.Navigation("Ogretmen");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Not", b =>
                {
                    b.HasOne("EntityLayer.Concrete.DersListesi", "DersListesi")
                        .WithMany("Nots")
                        .HasForeignKey("DersListesiID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DersListesi");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogrenci", b =>
                {
                    b.HasOne("EntityLayer.Concrete.Bolum", "Bolum")
                        .WithMany("Ogrencis")
                        .HasForeignKey("BolumID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Bolum");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Bolum", b =>
                {
                    b.Navigation("Derses");

                    b.Navigation("Ogrencis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ders", b =>
                {
                    b.Navigation("DersListesis");
                });

            modelBuilder.Entity("EntityLayer.Concrete.DersListesi", b =>
                {
                    b.Navigation("Devamsızlıks");

                    b.Navigation("Nots");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Fakulte", b =>
                {
                    b.Navigation("Bolums");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogrenci", b =>
                {
                    b.Navigation("DersListesis");

                    b.Navigation("Devamsızlıks");
                });

            modelBuilder.Entity("EntityLayer.Concrete.Ogretmen", b =>
                {
                    b.Navigation("Derses");

                    b.Navigation("Logins");
                });
#pragma warning restore 612, 618
        }
    }
}
