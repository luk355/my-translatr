using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using TranslationHistory.API.Models;
using TranslationHistory.API.Infrastructure;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyTranslatr.Services.TranslationHistory.API.Application.Commands;

namespace MyTranslatr.Services.TranslationHistory.API.Controllers
{
    [Route("api/[controller]")]
    public class HistoryController : Controller
    {
        private TranslationHistoryDbContext _context;

        public HistoryController(TranslationHistoryDbContext context)
        {
            _context = context;
        }

        // GET api/history
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var model = await _context.History.ToListAsync();

            return Ok(model);
        }

        // GET api/history/51
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/history
        [HttpPost]
        public void Post([FromBody]AddTranslationAttemptCommand command)
        {
            var translation = new TranslationDetail() { Language = command.Language, Success = command.Success, Word = command.Word, Translation = command.Translation };

            _context.History.Add(translation);
            _context.SaveChanges();
        }
    }
}
