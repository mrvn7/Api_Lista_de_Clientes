using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ValidacaoDeEmail.Models;

namespace ValidacaoDeEmail.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestModelsController : ControllerBase
    {
        private readonly TestModelsContext _context;

        public TestModelsController(TestModelsContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TestModels>>> GettestDetails()
        {
            return await _context.testDetails.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<TestModels>> GetTestModels(int id)
        {
            var testModels = await _context.testDetails.FindAsync(id);

            if (testModels == null)
            {
                return NotFound();
            }

            return testModels;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutTestModels(int id, TestModels testModels)
        {
            if (id != testModels.Id)
            {
                return BadRequest();
            }

            _context.Entry(testModels).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TestModelsExists(id))
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

        [HttpPost]
        public async Task<ActionResult<TestModels>> PostTestModels(TestModels testModels)
        {
            _context.testDetails.Add(testModels);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTestModels", new { id = testModels.Id }, testModels);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestModels(int id)
        {
            var testModels = await _context.testDetails.FindAsync(id);
            if (testModels == null)
            {
                return NotFound();
            }

            _context.testDetails.Remove(testModels);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TestModelsExists(int id)
        {
            return _context.testDetails.Any(e => e.Id == id);
        }



    }
}
