using DemoEmployee.db;
using DemoEmployee.DTOs;
using DemoEmployee.Models;
using DemoEmployee.Services.Interface;

namespace DemoEmployee.Services
{
    public class TeacherService : ITeacherService
    {
        EmployeeDbContext dbContext;
        public TeacherService(EmployeeDbContext _dbContext)
        {
            dbContext = _dbContext;
        }
        public TeacherDTO AddTeacher(TeacherDTO teacherDto)
        {
            Teacher teacher = new Teacher();
            
            teacher.Name = teacherDto.Name;
            teacher.Email = teacherDto.Email;
            teacher.ContactNumber= teacherDto.ContactNumber;


            teacher.DepartmentId=teacherDto.DepartmentId;
          
            
            

            dbContext.Teachers.Add(teacher);
            dbContext.SaveChanges();
            return teacherDto;
        }

        public TeacherDTO GetTeacher(Guid id)
        {
            var result=dbContext.Teachers.Find(id);
            TeacherDTO teacherDTO = new TeacherDTO();
            teacherDTO.Id = result.Id;
            teacherDTO.Name=result.Name;
            teacherDTO.ContactNumber=result.ContactNumber;
            

            return teacherDTO;  


        }
    }
}
