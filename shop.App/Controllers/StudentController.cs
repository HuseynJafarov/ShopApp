using Microsoft.AspNetCore.Mvc;
using Service.DTOs.Student;
using Service.Service.Interface;
using System.ComponentModel.DataAnnotations;

namespace shop.App.Controllers
{
    public class StudentController : AppController
    {
        private readonly IStudentService _service;

        public StudentController(IStudentService studentService)
        {
            _service = studentService;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromForm] StudentCreateAndUpdateDto student)
        {
            await _service.CreateAsync(student);
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _service.GetAllAsync());
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            try
            {
                return Ok(await _service.GetByIdAsync(id));
            }
            catch (NullReferenceException)
            {

                return NotFound();
            }
        }

        [HttpDelete]
        public async Task<IActionResult> Delete([Required] int id)
        {
            try
            {
                await _service.DeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

         [HttpPost]
         public async Task<IActionResult> SoftDelete([Required] int id)
         {
            try
            {
                await _service.SoftDeleteAsync(id);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
         }

        [HttpPut]
        [Route("{id}")]
        public async Task<IActionResult> Update([FromBody][Required] int id,[FromForm] StudentCreateAndUpdateDto student)
        {
            try
            {
                await _service.UpdateAsync(id,student);
                return Ok();
            }
            catch (NullReferenceException)
            {
                return NotFound();
            }
        }

        [HttpGet]
        public async Task<IActionResult> Search(string? search)
        {
            return Ok(await _service.SerachAsync(search));
        }

    }
}
