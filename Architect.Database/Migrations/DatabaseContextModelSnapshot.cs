﻿// <auto-generated />
using System;
using Architect.Database;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Architect.Database.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("arc")
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Architect.Database.Entities.Address", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("City")
                        .IsRequired();

                    b.Property<int>("Country");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Street")
                        .IsRequired();

                    b.Property<string>("StreetNumber")
                        .IsRequired();

                    b.Property<int>("ZipCode");

                    b.HasKey("Id");

                    b.ToTable("Addresses");
                });

            modelBuilder.Entity("Architect.Database.Entities.AddressAggregate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("AggregateRootId");

                    b.Property<string>("Country");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("Zip");

                    b.HasKey("Id");

                    b.ToTable("AddressAggregates");
                });

            modelBuilder.Entity("Architect.Database.Entities.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AddressId");

                    b.Property<int>("ChairmanId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<DateTime>("FoundationDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("Name")
                        .IsRequired();

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique();

                    b.HasIndex("ChairmanId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("Architect.Database.Entities.Employment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EmployeeId");

                    b.Property<int>("EmployerId");

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsIndefinitePeriod");

                    b.Property<int>("JobId");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("EmployerId");

                    b.HasIndex("JobId");

                    b.ToTable("Employments");
                });

            modelBuilder.Entity("Architect.Database.Entities.Label", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Labels");
                });

            modelBuilder.Entity("Architect.Database.Entities.Language", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("EnglishName")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("NativeName")
                        .IsRequired();

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("Architect.Database.Entities.Name", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("MiddleName");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<string>("NickName");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Names");
                });

            modelBuilder.Entity("Architect.Database.Entities.NameAggregate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AggregateRootId");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<string>("LongName");

                    b.Property<string>("ShortName");

                    b.HasKey("Id");

                    b.ToTable("NameAggregates");
                });

            modelBuilder.Entity("Architect.Database.Entities.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AddressId");

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EyeColor");

                    b.Property<int>("HairColor");

                    b.Property<int>("Height");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int>("NameId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.HasIndex("AddressId")
                        .IsUnique()
                        .HasFilter("[AddressId] IS NOT NULL");

                    b.HasIndex("NameId")
                        .IsUnique();

                    b.ToTable("People");
                });

            modelBuilder.Entity("Architect.Database.Entities.PersonAggregate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address");

                    b.Property<int>("AggregateRootId");

                    b.Property<DateTime>("BirthDate");

                    b.Property<DateTime>("CreatedDate");

                    b.Property<int>("EyeColor");

                    b.Property<int>("HairColor");

                    b.Property<int>("Height");

                    b.Property<string>("Name");

                    b.Property<int>("Weight");

                    b.HasKey("Id");

                    b.ToTable("PersonAggregates");
                });

            modelBuilder.Entity("Architect.Database.Entities.Profession", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<int>("NameId");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.HasKey("Id");

                    b.HasIndex("NameId")
                        .IsUnique();

                    b.ToTable("Professions");
                });

            modelBuilder.Entity("Architect.Database.Entities.TranslatedLabel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("CreatedDate");

                    b.Property<bool>("IsDeleted");

                    b.Property<int>("LabelId");

                    b.Property<int>("LanguageId");

                    b.Property<DateTime?>("ModifiedDate");

                    b.Property<byte[]>("RowVersion")
                        .IsConcurrencyToken()
                        .ValueGeneratedOnAddOrUpdate();

                    b.Property<string>("Text")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("LabelId");

                    b.HasIndex("LanguageId");

                    b.ToTable("TranslatedLabels");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("Architect.Database.Entities.Company", b =>
                {
                    b.HasOne("Architect.Database.Entities.Address", "Address")
                        .WithOne("Company")
                        .HasForeignKey("Architect.Database.Entities.Company", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Architect.Database.Entities.Person", "Chairman")
                        .WithMany("CompaniesLead")
                        .HasForeignKey("ChairmanId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Architect.Database.Entities.Employment", b =>
                {
                    b.HasOne("Architect.Database.Entities.Person", "Employee")
                        .WithMany("Employments")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Architect.Database.Entities.Company", "Employer")
                        .WithMany("Employments")
                        .HasForeignKey("EmployerId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Architect.Database.Entities.Profession", "Job")
                        .WithMany("Employments")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Architect.Database.Entities.Person", b =>
                {
                    b.HasOne("Architect.Database.Entities.Address", "Address")
                        .WithOne("Person")
                        .HasForeignKey("Architect.Database.Entities.Person", "AddressId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Architect.Database.Entities.Name", "Name")
                        .WithOne("Person")
                        .HasForeignKey("Architect.Database.Entities.Person", "NameId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Architect.Database.Entities.Profession", b =>
                {
                    b.HasOne("Architect.Database.Entities.Label", "Name")
                        .WithOne("Profession")
                        .HasForeignKey("Architect.Database.Entities.Profession", "NameId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Architect.Database.Entities.TranslatedLabel", b =>
                {
                    b.HasOne("Architect.Database.Entities.Label", "Label")
                        .WithMany("TranslatedLabels")
                        .HasForeignKey("LabelId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Architect.Database.Entities.Language", "Language")
                        .WithMany("TranslatedLabels")
                        .HasForeignKey("LanguageId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<int>")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser<int>")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
