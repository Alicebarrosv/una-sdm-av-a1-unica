using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValeAtivos324138379.Data;
using ValeAtivos324138379.Models;

namespace ValeAtivos324138379.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EquipamentosController(AppDbContext context) : ControllerBase
    {
        private readonly AppDbContext _context = context;

        [HttpGet]
        
        public async Task<ActionResult<IEnumerable<Equipamento>>> GetEquipamentos()
        {
            var equipamentos = await _context.Equipamentos.ToListAsync();
            return Ok(equipamentos);
            
        }
        [HttpPost]

        public async Task<ActionResult<Equipamento>> PostEquipamento(Equipamento equipamento)
        {
            _context.Equipamentos.Add(equipamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEquipamentos), new { id = equipamento.Id}, equipamento);
            
        }


        
    }
}