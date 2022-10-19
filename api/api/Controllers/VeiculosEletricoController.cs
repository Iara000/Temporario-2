using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosEletricoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeiculosEletricoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var veiculosEletricos = await _context.Veiculos_eletricos.ToListAsync();
            return Ok(veiculosEletricos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var veiculoEletrico = await _context.Veiculos_eletricos.FirstOrDefaultAsync(ve => ve.Id == id);

            if (veiculoEletrico == null) NotFound();

            return Ok(veiculoEletrico);
        }

        [HttpPost]
        public async Task<ActionResult> Create(VeiculoEletrico model)
        {
            if (model.Motor < 0 || model.Capacidade_bateria < 0 || model.Eficiencia < 0 || model.Autonomia < 0)
            {
                return BadRequest(new { message = "Os valores para motor, capacidade da bateria, eficiência e autonomia devem ser maiores do que zero!" });
            }

            _context.Veiculos_eletricos.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, VeiculoEletrico model)
        {
            if (id != model.Id) return BadRequest();

            var veiculoEletrico = await _context.Veiculos_eletricos.AsNoTracking().FirstOrDefaultAsync(ve => id == ve.Id);

            if (veiculoEletrico == null) return NotFound();

            _context.Veiculos_eletricos.Update(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var veiculoEletrico = await _context.Veiculos_eletricos.FindAsync(id);

            if (veiculoEletrico == null) return NotFound();

            _context.Veiculos_eletricos.Remove(veiculoEletrico);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
