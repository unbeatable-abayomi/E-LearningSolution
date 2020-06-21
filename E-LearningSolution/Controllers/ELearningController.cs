using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using E_LearningSolution.Models;
using E_LearningSolution.Services;
using Microsoft.AspNetCore.Mvc;

namespace E_LearningSolution.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    
    public class ELearningController : ControllerBase
    {
        private readonly IELearning _context;

        public ELearningController(IELearning eLearning)
        {
            _context = eLearning;
        }




        [HttpGet]
        public IEnumerable<ELearningModel> Get()
        {
            return _context.GetAll();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromRoute] long id)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            var eLearning = await _context.Get(id);
            if (eLearning == null)
            {
                return NotFound();
            }

            return Ok(eLearning);

        }

        [HttpPost]                         
        public async Task<IActionResult> PostELearning([FromBody] ELearningModel eLearningModel )
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            await _context.Add(eLearningModel);
            return Ok(eLearningModel);

        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutELearning([FromRoute] long id, ELearningModel eLearningModel)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            if (id != eLearningModel.Id)
            {
                return BadRequest("Course ID doesn't exist ");
            }

            await _context.Update(eLearningModel);
            return NoContent();
        }

        [HttpDelete("{id}")]                           
        public async Task<IActionResult> DeleteELearning(long id)
        {
            await _context.Delete(id);
            return Ok();
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
