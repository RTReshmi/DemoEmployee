using DemoEmployee.db;
using DemoEmployee.Models;
using DemoEmployee.Services.Interface;
using DemoEmployee.ViewModel;

namespace DemoEmployee.Services
{
    public class TeacherService : ITeacherservice
    {

        private readonly EmployeeDbContext _context;
        public TeacherService(EmployeeDbContext _context)
        {
            this._context = _context;
        }

        public TeacherViewModel Add(TeacherViewModel teacher)
        {
            Teacher teacher1 = new Teacher();
            teacher1.Name = teacher.Name;
            teacher1.Email= teacher.Email;

            _context.Teachers.Add(teacher1);
            _context.SaveChanges();

            return teacher;
        }

        public TeacherViewModel Get(Guid id)
        {
            var teacher=_context.Teachers.Single(x => x.Id == id);

            TeacherViewModel viewModel=new TeacherViewModel();
            viewModel.Name = teacher.Name;
            viewModel.Email = teacher.Email;

            return viewModel;
        }

        public List<Teacher> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
