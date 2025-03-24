using Microsoft.AspNetCore.Mvc;
using ListaDeTarefas.Data;
using ListaDeTarefas.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ListaDeTarefas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly AppDbContext _dbContext;

        public TarefasController(AppDbContext context)
        {
            _dbContext = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Tarefa>>> GetTarefas()
        {
            return await _dbContext.Tarefas.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<Tarefa>> PostTarefa([FromBody] Tarefa tarefa)
        {
            _dbContext.Tarefas.Add(tarefa);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTarefaById), new { id = tarefa.Id }, tarefa);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Tarefa>> GetTarefaById(int id)
        {
            var tarefa = await _dbContext.Tarefas.FindAsync(id);

            if (tarefa == null)
            {
                return NotFound();
            }

            return tarefa;
        }
    }
}
