using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TP2_6216948_PWS.Data;
using TP2_6216948_PWS.Models;

namespace TP2_6216948_PWS.DbInitialiser
{
    public class DbInitialiser : IdBInitialiser
    {

        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly TP2DbContext _db;

        public DbInitialiser(UserManager<User> userManager, RoleManager<IdentityRole> roleManager, TP2DbContext db)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
        }


        public void Initialize()
        {
            try
            {
                if (_db.Database.GetPendingMigrations().Count() > 0)
                {
                    _db.Database.Migrate();
                }
            }
            catch (Exception ex) { }

            // Créer les rôles suivants si aucun rôle ne figure dans la bd
            if (!_roleManager.RoleExistsAsync("Admin").GetAwaiter().GetResult())
            {
                _roleManager.CreateAsync(new IdentityRole("Admin"))
                    .GetAwaiter().GetResult();

                _roleManager.CreateAsync(new IdentityRole("User"))
                    .GetAwaiter().GetResult();



                // Créer un User pour le rôle Admin
                PasswordHasher<User> hasher = new PasswordHasher<User>();
                _userManager.CreateAsync(new User
                {
                    Id = new Guid().ToString(),
                    UserName = "Admin",
                    Email = "Admin@hotmail.com",
                    NormalizedEmail = "ADMIN@HOTMAIL.COM",
                    NormalizedUserName = "ADMIN",


                }, hasher.HashPassword(new User(), "AdminPassword")).GetAwaiter().GetResult();
                User admin = _db.Users.FirstOrDefault(u => u.Email == "Admin@hotmail.com");
                _userManager.AddToRoleAsync(admin, "Admin")
                    .GetAwaiter().GetResult();



            }

        }
    }
}

