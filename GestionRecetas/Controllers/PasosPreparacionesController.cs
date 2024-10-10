using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using GestionRecetas.Models;
using Microsoft.AspNetCore.Authorization;

namespace GestionRecetas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize(Policy = "UsuarioRolAsignado")]
    public class PasosPreparacionesController : ControllerBase
    {
        private readonly RecetasDBContext _context;

        public PasosPreparacionesController(RecetasDBContext context)
        {
            _context = context;
        }

        // GET: api/PasosPreparaciones
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PasosPreparacion>>> GetPasosPreparaciones()
        {
            return await _context.PasosPreparaciones.ToListAsync();
        }

        // GET: api/PasosPreparaciones/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PasosPreparacion>> GetPasosPreparacion(int id)
        {
            var pasosPreparacion = await _context.PasosPreparaciones.FindAsync(id);

            if (pasosPreparacion == null)
            {
                return NotFound();
            }

            return pasosPreparacion;
        }

        // PUT: api/PasosPreparaciones/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> PutPasosPreparacion(int id, PasosPreparacion pasosPreparacion)
        {
            var receta = await _context.Recetas.FindAsync(pasosPreparacion.RecetaId);
            if (receta == null)
            {
                return NotFound();
            }

            pasosPreparacion.Receta = receta;

            if (id != pasosPreparacion.ID)
            {
                return BadRequest();
            }

            _context.Entry(pasosPreparacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PasosPreparacionExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/PasosPreparaciones
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<PasosPreparacion>> PostPasosPreparacion(PasosPreparacion pasosPreparacion)
        {
            var receta = await _context.Recetas.FindAsync(pasosPreparacion.RecetaId);
            if (receta == null)
            {
                return NotFound();
            }

            pasosPreparacion.Receta = receta;

            _context.PasosPreparaciones.Add(pasosPreparacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPasosPreparacion", new { id = pasosPreparacion.ID }, pasosPreparacion);
        }

        // DELETE: api/PasosPreparaciones/5
        [HttpDelete("{id}")]
        [Authorize(Roles = "Administrador")]
        public async Task<IActionResult> DeletePasosPreparacion(int id)
        {
            var pasosPreparacion = await _context.PasosPreparaciones.FindAsync(id);
            if (pasosPreparacion == null)
            {
                return NotFound();
            }

            _context.PasosPreparaciones.Remove(pasosPreparacion);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PasosPreparacionExists(int id)
        {
            return _context.PasosPreparaciones.Any(e => e.ID == id);
        }
    }
}
