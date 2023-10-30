using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using TP2_6216948_PWS.Models;

namespace TP2_6216948_PWS.Data
{
    public class TP2DbContext : IdentityDbContext<User>
    {
        public TP2DbContext(DbContextOptions<TP2DbContext> options) : base(options) { }


        public DbSet<Arena>? Arenas { get; set; }
        public DbSet<DG>? DG { get; set; }
        public DbSet<League>? Leagues { get; set; }
        public DbSet<Saison>? Saisons { get; set; }
        public DbSet<Team>? Teams { get; set; }
        public DbSet<Villager>? Villagers { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Villager>().HasData(new Villager()
            {
                Id=1,
                Nom="Jordan Couture",
                
            });

            PasswordHasher<User> hasher = new PasswordHasher<User>();
            User ul = new User
            {
                Id = "11111111-1111-1111-1111-11111111111",
                UserName = "Jord98",
                Email = "Jord98@mail.com",
                NormalizedEmail = "JORD98@MAIL.COM",
                NormalizedUserName = "JORD98"

            };

            ul.PasswordHash = hasher.HashPassword(ul, "Allo1!");
            modelBuilder.Entity<User>().HasData(ul);


            modelBuilder.Entity<Villager>()
                .HasMany(c => c.UsersFriends)
                .WithMany(v => v.VillagersFriends)
                .UsingEntity(e =>
                {
                    e.HasData(new { UsersFriendsId = ul.Id, VillagersFriendsId = 1 });
                });

            




            // Seed des données pour la classe Bibliotheque
            modelBuilder.Entity<League>().HasData(
                new League
                {
                    Id = 1,
                    Name = "Ligue Nationale de Hockey ",
                    Logo = "nhl.png",

                },
                new League
                {
                    Id = 2,
                    Name = "Ligue de Hockey d'Ontario ",
                    Logo = "OHL.jpg"
                },
                new League
                {
                    Id = 3,
                    Name = "Ligue de hockey junior majeur du Québec ",
                    Logo = "lhjmq.png"
                },
                new League
                {
                    Id=4,
                    Name="Ligue de hockey sans equipes",
                    Logo="photoinexistante.png"
                }



            ); ;


            modelBuilder.Entity<Team>().HasData(
                new Team
                {
                    Id = 1,
                    Name = "Canadiens",
                    Ville = "Montréal",
                    Commanditaire = "Reebok",
                    LeagueId = 1,
                    DGId = 1,
                    ArenaID = 1

                },
                new Team
                {
                    Id = 2,
                    Name = "Capitals",
                    Ville = "Washington",
                    Commanditaire = "Adidas",
                    LeagueId = 1,
                    DGId = 2,
                    ArenaID = 2

                },
                new Team
                {
                    Id = 3,
                    Name = "Penguins",
                    Ville = "Pittsburgh",
                    Commanditaire = "Lululemon",
                    LeagueId = 1,
                    DGId = 3,
                    ArenaID = 3

                },
                 new Team
                 {
                     Id = 4,
                     Name = "Rangers",
                     Ville = "New-York",
                     Commanditaire = "Adidas",
                     LeagueId = 1,
                     DGId = 4,
                     ArenaID = 4

                 },
                 new Team
                 {
                     Id = 5,
                     Name = "Bruins",
                     Ville = "Boston",
                     Commanditaire = "Reebok",
                     LeagueId = 1,
                     DGId = 5,
                     ArenaID = 5

                 },


                 new Team
                 {
                     Id = 6,
                     Name = "Knights",
                     Ville = "London",
                     Commanditaire = "Hector's Shack",
                     LeagueId = 2,
                     DGId = 6,
                     ArenaID = 6
                 },

                 new Team
                 {
                     Id = 7,
                     Name = "Spitfires",
                     Ville = "Windsor",
                     Commanditaire = "Le shack a Junior",
                     LeagueId = 2,
                     DGId = 7,
                     ArenaID = 7
                 },
                 new Team
                 {
                     Id = 8,
                     Name = "67's",
                     Ville = "Ottawa",
                     Commanditaire = "Le shack a Roland",
                     LeagueId = 2,
                     DGId = 8,
                     ArenaID = 8
                 },
                 new Team
                 {
                     Id = 9,
                     Name = "Frontenacs",
                     Ville = "Kingston ",
                     Commanditaire = "The good Restaurant",
                     LeagueId = 2,
                     DGId = 9,
                     ArenaID = 9
                 },

                 new Team
                 {
                     Id = 10,
                     Name = "Wolves",
                     Ville = "Sudbury  ",
                     Commanditaire = "The bad Restaurant",
                     LeagueId = 2,
                     DGId = 10,
                     ArenaID = 10
                 },

                 new Team
                 {
                     Id = 11,
                     Name = "Mooseheads",
                     Ville = "Halifax   ",
                     Commanditaire = "The average Restaurant",
                     LeagueId = 3,
                     DGId = 11,
                     ArenaID = 11
                 },
                 new Team
                 {
                     Id = 12,
                     Name = "Océanic",
                     Ville = "Rimouski",
                     Commanditaire = "Sports aux puces",
                     LeagueId = 3,
                     DGId = 12,
                     ArenaID = 12
                 },
                 new Team
                 {
                     Id = 13,
                     Name = "Drakkar",
                     Ville = " Baie-Comeau",
                     Commanditaire = "Sports aux poux",
                     LeagueId = 3,
                     DGId = 13,
                     ArenaID = 13
                 }











            );


            modelBuilder.Entity<Saison>().HasData(
                new Saison
                {
                    Id = 1,
                    DateDebut = "2019-10-24",
                    DateFin = "2020-04-10",
                    LeagueId = 1

                },
                new Saison
                {
                    Id = 2,
                    DateDebut = "2020-10-24",
                    DateFin = "2021-04-10",
                    LeagueId = 1

                },

                new Saison
                {
                    Id = 3,
                    DateDebut = "2021-10-24",
                    DateFin = "2022-04-10",
                    LeagueId = 1

                },

                 new Saison
                 {
                     Id = 4,
                     DateDebut = "2018-10-24",
                     DateFin = "2019-04-10",
                     LeagueId = 2

                 },
                 new Saison
                 {
                     Id = 5,
                     DateDebut = "2019-10-24",
                     DateFin = "2020-04-10",
                     LeagueId = 2

                 },
                 new Saison
                 {
                     Id = 6,
                     DateDebut = "2020-10-24",
                     DateFin = "2021-04-10",
                     LeagueId = 2

                 },
                 new Saison
                 {
                     Id = 7,
                     DateDebut = "2018-10-24",
                     DateFin = "2019-04-10",
                     LeagueId = 3

                 },
                 new Saison
                 {
                     Id = 8,
                     DateDebut = "2019-10-24",
                     DateFin = "2020-04-10",
                     LeagueId = 3

                 },
                 new Saison
                 {
                     Id = 9,
                     DateDebut = "2020-10-24",
                     DateFin = "2021-04-10",
                     LeagueId = 3

                 }

                );

            modelBuilder.Entity<DG>().HasData(
                 new DG
                 {
                     ID = 1,
                     Name = "Patrice Belanger",
                     Age = 51,
                 },
                new DG
                {
                    ID = 2,
                    Name = "Jean Tremblay",
                    Age = 45,
                },
                 new DG
                 {
                     ID = 3,
                     Name = "Sophie Martin",
                     Age = 39,
                 },
                 new DG
                 {
                     ID = 4,
                     Name = "Louis Dubois",
                     Age = 56,
                 },
                new DG
                {
                    ID = 5,
                    Name = "Marie-Claude Leblanc",
                    Age = 48,
                },
                new DG
                {
                    ID = 6,
                    Name = "Éric Desjardins",
                    Age = 43,
                },
                new DG
                {
                    ID = 7,
                    Name = "Lucie Gagnon",
                    Age = 47,
                },
                 new DG
                 {
                     ID = 8,
                     Name = "Michel Lefebvre",
                     Age = 52,
                 },
                 new DG
                 {
                     ID = 9,
                     Name = "Isabelle Tremblay",
                     Age = 41,
                 },
                new DG
                {
                    ID = 10,
                    Name = "Pierre Dupont",
                    Age = 48,
                },
                new DG
                {
                    ID = 11,
                    Name = "Catherine Bergeron",
                    Age = 44,
                },
                 new DG
                 {
                     ID = 12,
                     Name = "Martin Gauthier",
                     Age = 50,
                 },
                new DG
                {
                    ID = 13,
                    Name = "Nathalie Roy",
                    Age = 46,
                }




       );

            modelBuilder.Entity<Arena>().HasData(
                new Arena
                {
                    Id = 1,
                    Name = "Centre Bell",
                    Ville = "Montréal",
                    Pays = "Canada",
                },
                 new Arena
                 {
                     Id = 2,
                     Name = "Capital One Arena",
                     Ville = "Washington D.C.",
                     Pays = "United-States",
                     

                 },

                 new Arena
                 {
                     Id = 3,
                     Name = "PPG Paints Arena",
                     Ville = "Pittsburgh",
                     Pays = "United-States",

                 },
                   new Arena
                   {
                       Id = 4,
                       Name = "Madison Square Garden",
                       Ville = "New-York",
                       Pays = "United-States",

                   },
                     new Arena
                     {
                         Id = 5,
                         Name = "TD Garden",
                         Ville = "Boston",
                         Pays = "United-States",

                     },

                       new Arena
                       {
                           Id = 6,
                           Name = "Budweiser Gardens",
                           Ville = "London",
                           Pays = "Canada",

                       },
                         new Arena
                         {
                             Id = 7,
                             Name = "WFCU Centre",
                             Ville = "Windsor",
                             Pays = "Canada",

                         },
                            new Arena
                            {
                                Id = 8,
                                Name = "TD Place Arena",
                                Ville = "Ottawa",
                                Pays = "Canada",

                            },
                              new Arena
                              {
                                  Id = 9,
                                  Name = "Leon's Centre",
                                  Ville = "Kingston",
                                  Pays = "Canada",

                              },
                                new Arena
                                {
                                    Id = 10,
                                    Name = "Sudbury Community Arena",
                                    Ville = "Sudbury",
                                    Pays = "Canada",

                                },
                                   new Arena
                                   {
                                       Id = 11,
                                       Name = "Scotiabank Centre",
                                       Ville = "Halifax",
                                       Pays = "Canada",

                                   },
                                     new Arena
                                     {
                                         Id = 12,
                                         Name = "Colisée Financière Sun Life",
                                         Ville = "Rimouski",
                                         Pays = "Canada",

                                     },
                                       new Arena
                                       {
                                           Id = 13,
                                           Name = "Centre Henry-Leonard",
                                           Ville = "Baie-Comeau",
                                           Pays = "Canada",

                                       }


                );



        }


    }
}
