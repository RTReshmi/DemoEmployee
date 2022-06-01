using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoEmployee.Models;
using DemoEmployee.db;
using DemoEmployee.Services.Interface;
using DemoEmployee.ViewModel;

namespace DemoEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeachersController : ControllerBase
    {
        private readonly EmployeeDbContext _context;
        private readonly ITeacherservice teacherservice;

        public TeachersController(EmployeeDbContext context, ITeacherservice teacherservice)
        {
            _context = context;
            this.teacherservice = teacherservice;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Teacher>>> GetTeachers()
        {
            if (_context.Teachers == null)
            {
                return NotFound();
            }
            return await _context.Teachers.Include(x => x.department).ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<TeacherViewModel>> GetTeacher(Guid id)
        {
           var techerViewModelObJ= teacherservice.Get(id);

            return techerViewModelObJ;
        }



        [HttpPost]
        public async Task<ActionResult<Teacher>> PostTeacher(TeacherViewModel teacher)
        {
            var _teacher = teacherservice.Add(teacher);
            return Ok(_teacher);
        }


    }
}
