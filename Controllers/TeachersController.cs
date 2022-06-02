using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoEmployee.Models;
using DemoEmployee.db;
using DemoEmployee.Services;
using DemoEmployee.DTOs;
using DemoEmployee.Services.Interface;

namespace DemoEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly EmployeeDbContext _context;
        private readonly ITeacherService _teacherService;

        public TeachersController(EmployeeDbContext context, ITeacherService teacherService)
        {
            _context = context;
            _teacherService = teacherService;
        }

        // GET: api/Teachers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
            if (_context.Teachers == null)
            {
                return NotFound();
            }
            //var users = _context.Users
            //    .Include(zz => zz.PhotoList)
            return await _context.Teachers.Include(x => x.department).ToListAsync();
        }

        // GET: api/Teachers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherDTO>> GetTeacher(Guid id)
        {
            var result = _teacherService.GetTeacher(id);


            return result;
        }

        // PUT: api/Teachers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTeacher(Guid id, TeacherDTO teacherdto)
        {

            _teacherService.UpdateTeacher(teacherdto);
             return NoContent();
        }

        // POST: api/Teachers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        
        public async Task<ActionResult<Teacher>> PostTeacher(TeacherDTO teacherdto)
        {
            
     
                _teacherService.AddTeacher(teacherdto);


                return Ok();
            
            
        }

        // DELETE: api/Teachers/5
        [HttpDelete("{id}")]
        public async Task<TeacherDTO> DeleteTeacher(Guid id)
        {


            _teacherService.DeleteTeacher(id);


            return null;
        }
    }
}
