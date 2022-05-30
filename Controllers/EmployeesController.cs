using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemoEmployee.Models;
using DemoEmployee.db;

namespace DemoEmployee.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        private readonly EmployeeDbContext _context;

        public EmployeesController(EmployeeDbContext context)
        {
            _context = context;
        }

        // GET: api/Employees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Employee>>> GetEmployee()
        {
            if (_context.Employee == null)
            {
                return NotFound();
            }
            return await _context.Employee.ToListAsync();
        }

        // GET: api/Employees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Employee>> GetEmployee(Guid id)
        {
            if (_context.Employee == null)
            {
                return NotFound();
            }
            var employee = await _context.Employee.FindAsync(id);

            if (employee == null)
            {
                return NotFound();
            }

            return employee;
        }
        [HttpGet("{login}")]
        public async Task<ActionResult<Employee>> LoginDetails(string email, string password)
        {
            var selectedUser = _context.Employee.Where(x => x.Email == email && x.Password == password).FirstOrDefault();
            if (selectedUser != null)
            {
                return RedirectToAction("Homepage");
            }

            return RedirectToAction("Errorpage");
        }
    
           



        // POST: api/Employees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        {
            if (_context.Employee == null)
            {
                return Problem("Entity set 'EmployeeDbContext.Employee'  is null.");
            }
            _context.Employee.Add(employee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEmployee", new { id = employee.EmployeeID }, employee);
        }
        [HttpPost("{login}")]
        public async Task<ActionResult<Employee>> PostLogin(string email, string password)
        {
            if (_context.Employee == null)
            {
                return Problem("Entity set 'EmployeeDbContext.Employee'  is null.");
            }
            //_context.Employee.Add(employee);
            //await _context.SaveChangesAsync();


            return CreatedAtAction("LoginDetails", new { email, password});       
        }



    }
}


