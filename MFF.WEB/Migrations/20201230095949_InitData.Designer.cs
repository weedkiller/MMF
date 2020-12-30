﻿// <auto-generated />
using System;
using MFF.Data.SmartLab;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace MFF.WEB.Migrations
{
    [DbContext(typeof(SmartLabDB))]
    [Migration("20201230095949_InitData")]
    partial class InitData
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.10");

            modelBuilder.Entity("MFF.DTO.Entities.Identity.ApplicationRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ApplicationRole");
                });

            modelBuilder.Entity("MFF.DTO.Entities.Identity.ApplicationRoleMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("MenuId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MenuId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleMenu");
                });

            modelBuilder.Entity("MFF.DTO.Entities.Identity.MenuItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT")
                        .HasMaxLength(100);

                    b.Property<string>("Icon")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<int?>("ParentId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.Property<string>("Url")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.HasIndex("ParentId");

                    b.ToTable("AspNetMenu");
                });

            modelBuilder.Entity("MFF.DTO.Entities.Identity.MenuPermission", b =>
                {
                    b.Property<int>("RoleMenuId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PermissionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoleMenuId", "PermissionId");

                    b.HasIndex("PermissionId");

                    b.ToTable("MenuPermission");
                });

            modelBuilder.Entity("MFF.DTO.Entities.Identity.Permission", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Permission");
                });

            modelBuilder.Entity("MFF.DTO.Entities.SmartLab.BanCanMia", b =>
                {
                    b.Property<int>("Ma_BanCanMia")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("CapNhatBoi")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedTime")
                        .HasColumnType("TEXT");

                    b.Property<string>("Gio")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Ma_Cttv")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Ma_SoCa")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mota")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("Ngay")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("NgayCapNhat")
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("NgayTao")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("TanMia")
                        .HasColumnType("TEXT");

                    b.Property<decimal?>("TanMiaTho")
                        .HasColumnType("TEXT");

                    b.Property<string>("TaoBoi")
                        .HasColumnType("TEXT");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedTime")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Xoa")
                        .HasColumnType("INTEGER");

                    b.HasKey("Ma_BanCanMia");

                    b.ToTable("BanCanMia");
                });

            modelBuilder.Entity("MFF.DTO.Entities.Identity.ApplicationRoleMenu", b =>
                {
                    b.HasOne("MFF.DTO.Entities.Identity.MenuItem", "MenuItem")
                        .WithMany("RoleMenus")
                        .HasForeignKey("MenuId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("MFF.DTO.Entities.Identity.ApplicationRole", "Role")
                        .WithMany("RoleMenus")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.NoAction);
                });

            modelBuilder.Entity("MFF.DTO.Entities.Identity.MenuItem", b =>
                {
                    b.HasOne("MFF.DTO.Entities.Identity.MenuItem", "ParentItem")
                        .WithMany("Children")
                        .HasForeignKey("ParentId");
                });

            modelBuilder.Entity("MFF.DTO.Entities.Identity.MenuPermission", b =>
                {
                    b.HasOne("MFF.DTO.Entities.Identity.Permission", "Permission")
                        .WithMany("MenuPermissions")
                        .HasForeignKey("PermissionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MFF.DTO.Entities.Identity.ApplicationRoleMenu", "RoleMenu")
                        .WithMany("Permissions")
                        .HasForeignKey("RoleMenuId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
