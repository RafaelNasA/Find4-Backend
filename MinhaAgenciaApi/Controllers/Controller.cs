using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MinhaAgenciaApi.Models;
using System.Linq;

namespace MinhaAgenciaApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DestinoController : ControllerBase
    {
        private readonly AgenciaDbContext _context;

        public DestinoController(AgenciaDbContext context)
        {
            _context = context;
        }

        
        [HttpGet]
        public IActionResult ObterDestinos()
        {
            var destinos = _context.Destinos.Include(d => d.Usuario).ToList();
            return Ok(destinos);
        }

        
        [HttpGet("{id}")]
        public IActionResult ObterDestinoPorId(int id)
        {
            var destino = _context.Destinos.Include(d => d.Usuario).FirstOrDefault(d => d.Id == id);

            if (destino == null)
            {
                return NotFound(); 
            }

            return Ok(destino);
        }
    }
}


