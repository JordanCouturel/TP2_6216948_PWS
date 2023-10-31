﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TP2_6216948_PWS.Data;

#nullable disable

namespace TP2_6216948_PWS.Migrations
{
    [DbContext(typeof(TP2DbContext))]
    partial class TP2DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.24")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.Arena", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pays")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Arenas");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Centre Bell",
                            Pays = "Canada",
                            Ville = "Montréal"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Capital One Arena",
                            Pays = "United-States",
                            Ville = "Washington D.C."
                        },
                        new
                        {
                            Id = 3,
                            Name = "PPG Paints Arena",
                            Pays = "United-States",
                            Ville = "Pittsburgh"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Madison Square Garden",
                            Pays = "United-States",
                            Ville = "New-York"
                        },
                        new
                        {
                            Id = 5,
                            Name = "TD Garden",
                            Pays = "United-States",
                            Ville = "Boston"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Budweiser Gardens",
                            Pays = "Canada",
                            Ville = "London"
                        },
                        new
                        {
                            Id = 7,
                            Name = "WFCU Centre",
                            Pays = "Canada",
                            Ville = "Windsor"
                        },
                        new
                        {
                            Id = 8,
                            Name = "TD Place Arena",
                            Pays = "Canada",
                            Ville = "Ottawa"
                        },
                        new
                        {
                            Id = 9,
                            Name = "Leon's Centre",
                            Pays = "Canada",
                            Ville = "Kingston"
                        },
                        new
                        {
                            Id = 10,
                            Name = "Sudbury Community Arena",
                            Pays = "Canada",
                            Ville = "Sudbury"
                        },
                        new
                        {
                            Id = 11,
                            Name = "Scotiabank Centre",
                            Pays = "Canada",
                            Ville = "Halifax"
                        },
                        new
                        {
                            Id = 12,
                            Name = "Colisée Financière Sun Life",
                            Pays = "Canada",
                            Ville = "Rimouski"
                        },
                        new
                        {
                            Id = 13,
                            Name = "Centre Henry-Leonard",
                            Pays = "Canada",
                            Ville = "Baie-Comeau"
                        });
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.DG", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("DG");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Age = 51,
                            Name = "Patrice Belanger"
                        },
                        new
                        {
                            ID = 2,
                            Age = 45,
                            Name = "Jean Tremblay"
                        },
                        new
                        {
                            ID = 3,
                            Age = 39,
                            Name = "Sophie Martin"
                        },
                        new
                        {
                            ID = 4,
                            Age = 56,
                            Name = "Louis Dubois"
                        },
                        new
                        {
                            ID = 5,
                            Age = 48,
                            Name = "Marie-Claude Leblanc"
                        },
                        new
                        {
                            ID = 6,
                            Age = 43,
                            Name = "Éric Desjardins"
                        },
                        new
                        {
                            ID = 7,
                            Age = 47,
                            Name = "Lucie Gagnon"
                        },
                        new
                        {
                            ID = 8,
                            Age = 52,
                            Name = "Michel Lefebvre"
                        },
                        new
                        {
                            ID = 9,
                            Age = 41,
                            Name = "Isabelle Tremblay"
                        },
                        new
                        {
                            ID = 10,
                            Age = 48,
                            Name = "Pierre Dupont"
                        },
                        new
                        {
                            ID = 11,
                            Age = 44,
                            Name = "Catherine Bergeron"
                        },
                        new
                        {
                            ID = 12,
                            Age = 50,
                            Name = "Martin Gauthier"
                        },
                        new
                        {
                            ID = 13,
                            Age = 46,
                            Name = "Nathalie Roy"
                        });
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.League", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Leagues");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Logo = "nhl.png",
                            Name = "Ligue Nationale de Hockey "
                        },
                        new
                        {
                            Id = 2,
                            Logo = "OHL.jpg",
                            Name = "Ligue de Hockey d'Ontario "
                        },
                        new
                        {
                            Id = 3,
                            Logo = "lhjmq.png",
                            Name = "Ligue de hockey junior majeur du Québec "
                        },
                        new
                        {
                            Id = 4,
                            Logo = "photoinexistante.png",
                            Name = "Ligue de hockey sans equipes"
                        });
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.Saison", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("Annee")
                        .HasColumnType("int");

                    b.Property<string>("DateDebut")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DateFin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("LeagueId");

                    b.ToTable("Saisons");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Annee = 0,
                            DateDebut = "2019-10-24",
                            DateFin = "2020-04-10",
                            LeagueId = 1
                        },
                        new
                        {
                            Id = 2,
                            Annee = 0,
                            DateDebut = "2020-10-24",
                            DateFin = "2021-04-10",
                            LeagueId = 1
                        },
                        new
                        {
                            Id = 3,
                            Annee = 0,
                            DateDebut = "2021-10-24",
                            DateFin = "2022-04-10",
                            LeagueId = 1
                        },
                        new
                        {
                            Id = 4,
                            Annee = 0,
                            DateDebut = "2018-10-24",
                            DateFin = "2019-04-10",
                            LeagueId = 2
                        },
                        new
                        {
                            Id = 5,
                            Annee = 0,
                            DateDebut = "2019-10-24",
                            DateFin = "2020-04-10",
                            LeagueId = 2
                        },
                        new
                        {
                            Id = 6,
                            Annee = 0,
                            DateDebut = "2020-10-24",
                            DateFin = "2021-04-10",
                            LeagueId = 2
                        },
                        new
                        {
                            Id = 7,
                            Annee = 0,
                            DateDebut = "2018-10-24",
                            DateFin = "2019-04-10",
                            LeagueId = 3
                        },
                        new
                        {
                            Id = 8,
                            Annee = 0,
                            DateDebut = "2019-10-24",
                            DateFin = "2020-04-10",
                            LeagueId = 3
                        },
                        new
                        {
                            Id = 9,
                            Annee = 0,
                            DateDebut = "2020-10-24",
                            DateFin = "2021-04-10",
                            LeagueId = 3
                        });
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.Team", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ArenaID")
                        .HasColumnType("int");

                    b.Property<string>("Commanditaire")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DGId")
                        .HasColumnType("int");

                    b.Property<int>("LeagueId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ville")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ArenaID")
                        .IsUnique();

                    b.HasIndex("DGId")
                        .IsUnique();

                    b.HasIndex("LeagueId");

                    b.ToTable("Teams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ArenaID = 1,
                            Commanditaire = "Reebok",
                            DGId = 1,
                            LeagueId = 1,
                            Name = "Canadiens",
                            Ville = "Montréal"
                        },
                        new
                        {
                            Id = 2,
                            ArenaID = 2,
                            Commanditaire = "Adidas",
                            DGId = 2,
                            LeagueId = 1,
                            Name = "Capitals",
                            Ville = "Washington"
                        },
                        new
                        {
                            Id = 3,
                            ArenaID = 3,
                            Commanditaire = "Lululemon",
                            DGId = 3,
                            LeagueId = 1,
                            Name = "Penguins",
                            Ville = "Pittsburgh"
                        },
                        new
                        {
                            Id = 4,
                            ArenaID = 4,
                            Commanditaire = "Adidas",
                            DGId = 4,
                            LeagueId = 1,
                            Name = "Rangers",
                            Ville = "New-York"
                        },
                        new
                        {
                            Id = 5,
                            ArenaID = 5,
                            Commanditaire = "Reebok",
                            DGId = 5,
                            LeagueId = 1,
                            Name = "Bruins",
                            Ville = "Boston"
                        },
                        new
                        {
                            Id = 6,
                            ArenaID = 6,
                            Commanditaire = "Hector's Shack",
                            DGId = 6,
                            LeagueId = 2,
                            Name = "Knights",
                            Ville = "London"
                        },
                        new
                        {
                            Id = 7,
                            ArenaID = 7,
                            Commanditaire = "Le shack a Junior",
                            DGId = 7,
                            LeagueId = 2,
                            Name = "Spitfires",
                            Ville = "Windsor"
                        },
                        new
                        {
                            Id = 8,
                            ArenaID = 8,
                            Commanditaire = "Le shack a Roland",
                            DGId = 8,
                            LeagueId = 2,
                            Name = "67's",
                            Ville = "Ottawa"
                        },
                        new
                        {
                            Id = 9,
                            ArenaID = 9,
                            Commanditaire = "The good Restaurant",
                            DGId = 9,
                            LeagueId = 2,
                            Name = "Frontenacs",
                            Ville = "Kingston "
                        },
                        new
                        {
                            Id = 10,
                            ArenaID = 10,
                            Commanditaire = "The bad Restaurant",
                            DGId = 10,
                            LeagueId = 2,
                            Name = "Wolves",
                            Ville = "Sudbury  "
                        },
                        new
                        {
                            Id = 11,
                            ArenaID = 11,
                            Commanditaire = "The average Restaurant",
                            DGId = 11,
                            LeagueId = 3,
                            Name = "Mooseheads",
                            Ville = "Halifax   "
                        },
                        new
                        {
                            Id = 12,
                            ArenaID = 12,
                            Commanditaire = "Sports aux puces",
                            DGId = 12,
                            LeagueId = 3,
                            Name = "Océanic",
                            Ville = "Rimouski"
                        },
                        new
                        {
                            Id = 13,
                            ArenaID = 13,
                            Commanditaire = "Sports aux poux",
                            DGId = 13,
                            LeagueId = 3,
                            Name = "Drakkar",
                            Ville = " Baie-Comeau"
                        });
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "11111111-1111-1111-1111-11111111111",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "a38ad995-dcb0-4edc-9d99-039f85bbf9ce",
                            Email = "Jord98@mail.com",
                            EmailConfirmed = false,
                            LockoutEnabled = false,
                            NormalizedEmail = "JORD98@MAIL.COM",
                            NormalizedUserName = "JORD98",
                            PasswordHash = "AQAAAAEAACcQAAAAEOvJZVkg8OMiKVf2bxJ0Aa3P/OPriHo1Um6JbzWxQeo2DITXMIgKPQsUvgzzmgdFeg==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e5c4a60c-e102-48d4-b5fe-b2d0fe81c330",
                            TwoFactorEnabled = false,
                            UserName = "Jord98"
                        });
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.Villager", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Villagers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Nom = "Jordan Couture"
                        });
                });

            modelBuilder.Entity("UserVillager", b =>
                {
                    b.Property<string>("UsersFriendsId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("VillagersFriendsId")
                        .HasColumnType("int");

                    b.HasKey("UsersFriendsId", "VillagersFriendsId");

                    b.HasIndex("VillagersFriendsId");

                    b.ToTable("UserVillager");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("TP2_6216948_PWS.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("TP2_6216948_PWS.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP2_6216948_PWS.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("TP2_6216948_PWS.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.Saison", b =>
                {
                    b.HasOne("TP2_6216948_PWS.Models.League", "League")
                        .WithMany("Saisons")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("League");
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.Team", b =>
                {
                    b.HasOne("TP2_6216948_PWS.Models.Arena", "Arena")
                        .WithOne("Team")
                        .HasForeignKey("TP2_6216948_PWS.Models.Team", "ArenaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP2_6216948_PWS.Models.DG", "DG")
                        .WithOne("Equipe")
                        .HasForeignKey("TP2_6216948_PWS.Models.Team", "DGId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP2_6216948_PWS.Models.League", "League")
                        .WithMany("Teams")
                        .HasForeignKey("LeagueId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Arena");

                    b.Navigation("DG");

                    b.Navigation("League");
                });

            modelBuilder.Entity("UserVillager", b =>
                {
                    b.HasOne("TP2_6216948_PWS.Models.User", null)
                        .WithMany()
                        .HasForeignKey("UsersFriendsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("TP2_6216948_PWS.Models.Villager", null)
                        .WithMany()
                        .HasForeignKey("VillagersFriendsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.Arena", b =>
                {
                    b.Navigation("Team")
                        .IsRequired();
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.DG", b =>
                {
                    b.Navigation("Equipe");
                });

            modelBuilder.Entity("TP2_6216948_PWS.Models.League", b =>
                {
                    b.Navigation("Saisons");

                    b.Navigation("Teams");
                });
#pragma warning restore 612, 618
        }
    }
}
