using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace GestionRecetas.Models.Seed
{
    public static class UsuarioSeed
    {
        public static void SeedUsuario_Roles(this ModelBuilder modelBuilder)
        {
            //Creacion de Roles
            List<IdentityRole> roles = new List<IdentityRole>()
            {
                new IdentityRole{Name="Administrador", NormalizedName="ADMINISTRADOR"},
                new IdentityRole{Name="Usuario", NormalizedName="USUARIO"},
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

            //Creacion de usuario
            List<Usuario> usuarios = new List<Usuario>()
            {
                new Usuario
                {
                    UserName = "admin@hotmail.com",
                    NormalizedUserName = "ADMIN@HOTMAIL.COM",
                    Email = "admin@hotmail.com",
                    NormalizedEmail = "ADMIN@HOTMAIL.COM"
                }
            };
            modelBuilder.Entity<Usuario>().HasData(usuarios);

            //Agregar contraseñas
            var passwordHasher = new PasswordHasher<Usuario>();
            usuarios[0].PasswordHash = passwordHasher.HashPassword(usuarios[0], "Pa$$w0rd");

            //Agregar el rol al usuario
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();
            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = usuarios[0].Id,
                RoleId = roles[0].Id
            });
            modelBuilder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }
}
