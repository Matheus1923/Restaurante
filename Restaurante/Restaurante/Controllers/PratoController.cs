using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Restaurante.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Restaurante.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PratoController : ControllerBase
    {
        public Contexto Contexto { get; set; }

        public PratoController(Contexto novoContexto)
        {
            this.Contexto = novoContexto;
        }

        [HttpGet]

        public List<Prato> Get()
        {
            return Contexto.Pratos.ToList();
        }

        [HttpGet("{id}")]
        public Prato Get(int id)
        {
            return Contexto.Pratos.First(e => e.IdPrato == id);
        }


        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<Prato>> Create(Prato Prato)
        {
            Prato.IdPrato = 0;
            Contexto.Pratos.Add(Prato);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Prato.IdPrato, Prato });
        }

        [HttpPost]
        [Route("update")]

        public async Task<ActionResult<Prato>> Update(Prato Prato)
        {
            Contexto.Pratos.Update(Prato);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Prato.IdPrato, Prato });
        }

        [HttpPost]
        [Route("remove")]

        public async Task<ActionResult<Prato>> Remove(Prato Prato)
        {
            Contexto.Pratos.Remove(Prato);
            await Contexto.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), new { id = Prato.IdPrato, Prato });
        }
    }
}
