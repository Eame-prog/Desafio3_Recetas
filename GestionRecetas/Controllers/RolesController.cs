using GestionRecetas.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GestionRecetas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Roles = "Administrador")]

    public class RolesController : ControllerBase
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public RolesController(UserManager<Usuario> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        [HttpPost("Asignar-Rol")]
        public async Task<IActionResult> AsignarRol([FromBody] RoleAssignmentModel model)
        {
            var usuario = await _userManager.FindByIdAsync(model.UsuarioId);
            if (usuario == null)
            {
                return NotFound(new { mensaje = "Usuario no encontrado" });
            }

            var rolExiste = await _roleManager.RoleExistsAsync(model.Rol);
            if (!rolExiste)
            {
                return BadRequest(new { mensaje = "El rol no existe" });
            }

            var resulto = await _userManager.AddToRoleAsync(usuario, model.Rol);
            if (!resulto.Succeeded)
            {
                return BadRequest(resulto.Errors);
            }

            return Ok(new { mensaje = "Rol asignado exitosamente" });
        }
    }

    public class RoleAssignmentModel
    {
        public string UsuarioId { get; set; }
        public string Rol { get; set; }

    }
}
