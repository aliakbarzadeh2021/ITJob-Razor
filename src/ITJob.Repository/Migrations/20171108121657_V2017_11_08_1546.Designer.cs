// <auto-generated />
using ITJob.Repository.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace ITJob.Repository.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20171108121657_V2017_11_08_1546")]
    partial class V2017_11_08_1546
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ITJob.DomainModels.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("Title")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.AppDataProtectionKey", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("FriendlyName");

                    b.Property<string>("XmlData");

                    b.HasKey("Id");

                    b.HasIndex("FriendlyName")
                        .IsUnique()
                        .HasFilter("[FriendlyName] IS NOT NULL");

                    b.ToTable("AppDataProtectionKeys");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.AppLogItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<int>("EventId");

                    b.Property<string>("LogLevel");

                    b.Property<string>("Logger");

                    b.Property<string>("Message");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("StateJson");

                    b.Property<string>("Url");

                    b.HasKey("Id");

                    b.ToTable("AppLogItems");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.AppSqlCache", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(449);

                    b.Property<DateTimeOffset?>("AbsoluteExpiration");

                    b.Property<DateTimeOffset>("ExpiresAtTime");

                    b.Property<long?>("SlidingExpirationInSeconds");

                    b.Property<byte[]>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("ExpiresAtTime")
                        .HasName("Index_ExpiresAtTime");

                    b.ToTable("AppSqlCache","dbo");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.Role", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("Description");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AppRoles");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.RoleClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("RoleId");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AppRoleClaims");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<DateTimeOffset?>("BirthDate");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName")
                        .HasMaxLength(450);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsEmailPublic");

                    b.Property<string>("LastName")
                        .HasMaxLength(450);

                    b.Property<DateTimeOffset?>("LastVisitDateTime");

                    b.Property<string>("Location");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PhotoFileName")
                        .HasMaxLength(450);

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

                    b.ToTable("AppUsers");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserClaims");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserLogin", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<int>("UserId");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserLogins");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserRole", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<int>("RoleId");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserToken", b =>
                {
                    b.Property<int>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AppUserTokens");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserUsedPassword", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("HashedPassword")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<int>("UserId");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AppUserUsedPasswords");
                });

            modelBuilder.Entity("ITJob.DomainModels.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CategoryId");

                    b.Property<string>("CreatedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("CreatedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("CreatedByUserId");

                    b.Property<DateTimeOffset?>("CreatedDateTime");

                    b.Property<string>("ModifiedByBrowserName")
                        .HasMaxLength(1000);

                    b.Property<string>("ModifiedByIp")
                        .HasMaxLength(255);

                    b.Property<int?>("ModifiedByUserId");

                    b.Property<DateTimeOffset?>("ModifiedDateTime");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<decimal>("Price");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.RoleClaim", b =>
                {
                    b.HasOne("ITJob.DomainModels.Identity.Role", "Role")
                        .WithMany("Claims")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserClaim", b =>
                {
                    b.HasOne("ITJob.DomainModels.Identity.User", "User")
                        .WithMany("Claims")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserLogin", b =>
                {
                    b.HasOne("ITJob.DomainModels.Identity.User", "User")
                        .WithMany("Logins")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserRole", b =>
                {
                    b.HasOne("ITJob.DomainModels.Identity.Role", "Role")
                        .WithMany("Users")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("ITJob.DomainModels.Identity.User", "User")
                        .WithMany("Roles")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserToken", b =>
                {
                    b.HasOne("ITJob.DomainModels.Identity.User", "User")
                        .WithMany("UserTokens")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITJob.DomainModels.Identity.UserUsedPassword", b =>
                {
                    b.HasOne("ITJob.DomainModels.Identity.User", "User")
                        .WithMany("UserUsedPasswords")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("ITJob.DomainModels.Product", b =>
                {
                    b.HasOne("ITJob.DomainModels.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
