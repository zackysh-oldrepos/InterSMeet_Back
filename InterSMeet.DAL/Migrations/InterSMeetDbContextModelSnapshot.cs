﻿// <auto-generated />
using System;
using InterSMeet.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace InterSMeet.DAL.Migrations
{
    [DbContext(typeof(InterSMeetDbContext))]
    partial class InterSMeetDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseCollation("utf8mb4_0900_ai_ci")
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.HasCharSet(modelBuilder, "utf8mb4");

            modelBuilder.Entity("InterSMeet.DAL.Entities.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("CompanyId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("degree_id");

                    b.Property<int>("FamilyId")
                        .HasColumnType("int")
                        .HasColumnName("family_id");

                    b.Property<int>("LevelId")
                        .HasColumnType("int")
                        .HasColumnName("level_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("name");

                    b.HasKey("DegreeId");

                    b.HasIndex("FamilyId");

                    b.HasIndex("LevelId");

                    b.ToTable("Degrees");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Family", b =>
                {
                    b.Property<int>("FamilyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("family_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("FamilyId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Families");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Image", b =>
                {
                    b.Property<int>("ImageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("image_id");

                    b.Property<byte[]>("ImageData")
                        .IsRequired()
                        .HasColumnType("longblob")
                        .HasColumnName("image_data");

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("image_title");

                    b.HasKey("ImageId");

                    b.ToTable("Images");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Language", b =>
                {
                    b.Property<int>("LanguageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(5)
                        .HasColumnType("varchar(5)")
                        .HasColumnName("name");

                    b.HasKey("LanguageId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Level", b =>
                {
                    b.Property<int>("LevelId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("level_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("LevelId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Levels");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Offer", b =>
                {
                    b.Property<int>("OfferId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("offer_id");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int")
                        .HasColumnName("company_id");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("Salary")
                        .HasColumnType("double");

                    b.Property<string>("Schedule")
                        .HasColumnType("longtext");

                    b.HasKey("OfferId");

                    b.HasIndex("CompanyId");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.OfferDegree", b =>
                {
                    b.Property<int>("OfferDegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("offer_degree_id");

                    b.Property<int>("DegreeId")
                        .HasColumnType("int")
                        .HasColumnName("degree_id");

                    b.Property<int>("OfferId")
                        .HasColumnType("int")
                        .HasColumnName("offer_id");

                    b.HasKey("OfferDegreeId");

                    b.ToTable("offer_degree");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Province", b =>
                {
                    b.Property<int>("ProvinceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("province_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("varchar(255)")
                        .HasColumnName("name");

                    b.HasKey("ProvinceId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int")
                        .HasColumnName("student_id");

                    b.Property<int?>("AvatarId")
                        .HasColumnType("int")
                        .HasColumnName("avatar_id");

                    b.Property<double>("AverageGrades")
                        .HasColumnType("double")
                        .HasColumnName("average_grades");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("birthdate");

                    b.Property<int>("DegreeId")
                        .HasColumnType("int")
                        .HasColumnName("degree_id");

                    b.HasKey("StudentId");

                    b.HasIndex("AvatarId");

                    b.HasIndex("DegreeId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("user_id");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("created_at");

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("email");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("first_name");

                    b.Property<int>("LanguageId")
                        .HasColumnType("int")
                        .HasColumnName("language_id");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(70)
                        .HasColumnType("varchar(70)")
                        .HasColumnName("last_name");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasColumnType("longtext")
                        .HasColumnName("location");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)")
                        .HasColumnName("password");

                    b.Property<int>("ProvinceId")
                        .HasColumnType("int")
                        .HasColumnName("province_id");

                    b.Property<int?>("RoleId")
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime(6)")
                        .HasColumnName("updated_at");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("username");

                    b.HasKey("UserId");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.HasIndex("LanguageId");

                    b.HasIndex("ProvinceId");

                    b.HasIndex("RoleId");

                    b.HasIndex("Username")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "IDX_97672ac88f789774dd47f7c8be")
                        .IsUnique();

                    b.ToTable("users", (string)null);
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.UserRole", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("role_id");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(40)
                        .HasColumnType("varchar(40)")
                        .HasColumnName("name");

                    b.HasKey("RoleId");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("user_roles");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Company", b =>
                {
                    b.HasOne("InterSMeet.DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Degree", b =>
                {
                    b.HasOne("InterSMeet.DAL.Entities.Family", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterSMeet.DAL.Entities.Level", "Level")
                        .WithMany()
                        .HasForeignKey("LevelId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Family");

                    b.Navigation("Level");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Offer", b =>
                {
                    b.HasOne("InterSMeet.DAL.Entities.Company", "Company")
                        .WithMany()
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.Student", b =>
                {
                    b.HasOne("InterSMeet.DAL.Entities.Image", "Avatar")
                        .WithMany()
                        .HasForeignKey("AvatarId");

                    b.HasOne("InterSMeet.DAL.Entities.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterSMeet.DAL.Entities.User", "User")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Avatar");

                    b.Navigation("Degree");

                    b.Navigation("User");
                });

            modelBuilder.Entity("InterSMeet.DAL.Entities.User", b =>
                {
                    b.HasOne("InterSMeet.DAL.Entities.Language", "Language")
                        .WithMany()
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterSMeet.DAL.Entities.Province", "Province")
                        .WithMany()
                        .HasForeignKey("ProvinceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("InterSMeet.DAL.Entities.UserRole", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId");

                    b.Navigation("Language");

                    b.Navigation("Province");

                    b.Navigation("Role");
                });
#pragma warning restore 612, 618
        }
    }
}
