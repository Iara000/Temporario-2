using api.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeiculosCombustaoController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeiculosCombustaoController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            var veiculosCombustao = await _context.Veiculos_combustao.ToListAsync();
            return Ok(veiculosCombustao);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetById(int id)
        {
            var veiculoCombustao = await _context.Veiculos_combustao.FirstOrDefaultAsync(vc => vc.Id == id);

            if (veiculoCombustao == null) NotFound();

            return Ok(veiculoCombustao);
        }

        [HttpPost]
        public async Task<ActionResult> Create(VeiculoCombustao model)
        {
            if (model.Motor < 0 || model.Media_consumo < 0)
            {
                return BadRequest(new { message = "Os valores para motor e média de consumo devem ser maiores do que zero!" });
            }

            _context.Veiculos_combustao.Add(model);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetById", new { id = model.Id }, model);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> Update(int id, VeiculoCombustao model)
        {
            if (id != model.Id) return BadRequest();

            var veiculoCombustao = await _context.Veiculos_combustao.AsNoTracking().FirstOrDefaultAsync(vc => id == vc.Id);

            if (veiculoCombustao == null) return NotFound();

            _context.Veiculos_combustao.Update(model);
            await _context.SaveChangesAsync();

            return Ok(model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            var veiculoCombustao = await _context.Veiculos_combustao.FindAsync(id);

            if (veiculoCombustao == null) return NotFound();

            _context.Veiculos_combustao.Remove(veiculoCombustao);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
