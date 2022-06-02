
using DemoEmployee.db;
using DemoEmployee.DTOs;
using DemoEmployee.Models;
using DemoEmployee.Services.Interface;

namespace DemoEmployee.Services
{
    public class TeacherService : ITeacherService
    {
        EmployeeDbContext dbContext;
        //IMapper mapper;
        public TeacherService(EmployeeDbContext _dbContext)
        {
            dbContext = _dbContext;
           //mapper = _mapper;   
        }
        public TeacherDTO AddTeacher(TeacherDTO teacherDto)
        {


            //var teacherObj = mapper.Map<Teacher>(teacherDto);


            Teacher teacher = new Teacher();

            teacher.Name = teacherDto.Name;
            teacher.Email = teacherDto.Email;
            teacher.ContactNumber = teacherDto.ContactNumber;
            teacher.DepartmentId = teacherDto.DepartmentId;
            dbContext.Teachers.Add(teacher);
            dbContext.SaveChanges();
            return teacherDto;
            
           
        }

        public TeacherDTO DeleteTeacher(Guid id)
        {
            var result = dbContext.Teachers.Find(id);
            TeacherDTO teacherDTO = new TeacherDTO();
            teacherDTO.Id = result.Id;
            teacherDTO.Name = result.Name;
            teacherDTO.ContactNumber = result.ContactNumber;
            dbContext.Teachers.Remove(result);
            dbContext.SaveChanges();


            return teacherDTO;

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

        public TeacherDTO UpdateTeacher(TeacherDTO teacherDto)
        {
            Teacher teacher = new Teacher();
            teacher.Name = teacherDto.Name;
            teacher.Email = teacherDto.Email;
            teacher.ContactNumber = teacherDto.ContactNumber;
            teacher.DepartmentId = teacherDto.DepartmentId;
            
            
            
            
            dbContext.Teachers.Update(teacher);
            dbContext.SaveChanges();
            return teacherDto;


        }
    }
}
