using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarjetasApp.Data;
using TarjetasApp.Helpers;
using TarjetasApp.Models;

namespace TarjetasApp.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TarjetasController : ControllerBase
    {
        private readonly TarjetasContext _context;

        public TarjetasController(TarjetasContext context)
        {
            _context = context;
        }

     

        // ACTUALIZAR: api/Tarjetas/{id}
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTarjeta(int id, Tarjeta tarjeta)
        {
            if (id != tarjeta.IdTarjeta)
            {
                return BadRequest();
            }

            _context.Entry(tarjeta).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TarjetaExists(id))
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

        // INSERTAR: api/Tarjetas
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Tarjeta>> PostTarjeta(Tarjeta tarjeta)
        {
            _context.Tarjeta.Add(tarjeta);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTarjeta", new { id = tarjeta.IdTarjeta }, tarjeta);
        }

        // BORRAR: api/Tarjetas/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTarjeta(int id)
        {
            var tarjeta = await _context.Tarjeta.FindAsync(id);
            if (tarjeta == null)
            {
                return NotFound();
            }

            _context.Tarjeta.Remove(tarjeta);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TarjetaExists(int id)
        {
            return _context.Tarjeta.Any(e => e.IdTarjeta == id);
        }

        //todas las tarjetas que una persona fue solicitando
        [HttpGet("DePersona/{IdPersona}")]
        public async Task<ActionResult<IEnumerable<Tarjeta>>> GetTarjetas(int IdPersona)
        {
            return await _context.Tarjeta.Where(x => x.IdPersona == IdPersona).ToListAsync();
        }

           // Invocar un método que devuelva toda la información de una tarjeta
        [HttpGet("{id}")]
        public async Task<ActionResult<Tarjeta>> GetTarjeta(int id)
        {
            var tarjeta = await _context.Tarjeta.FindAsync(id);

            if (tarjeta == null)
            {
                return NotFound();
            }

            return tarjeta;
        }

        //todas las tarjetas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarjeta>>> GetTarjetas()
        {
            return await _context.Tarjeta.ToListAsync();
        }

      

        //ver si una tarjeta puede operar
        [HttpGet("CardIsValid/{id}")]
        public async Task<ActionResult<bool>> CardIsValid(int id)
        {
            var tarjeta = await _context.Tarjeta.FindAsync(id);
            return TarjetaHelpers.IsTarjetaValid(tarjeta);
        }

          //ver si una operación es valida
        [HttpGet("OperacionValida/{amount}")]
        public ActionResult<bool> TransactionIsValid(double amount)
        {
            return TransactionHelpers.IsTransactionValid(amount);
        }

    }
}
