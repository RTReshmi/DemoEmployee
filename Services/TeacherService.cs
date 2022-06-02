using AutoMapper;
using DemoEmployee.db;
using DemoEmployee.ErrorLogging;
using DemoEmployee.Models;
using DemoEmployee.Services.Interface;
using DemoEmployee.ViewModel;

namespace DemoEmployee.Services
{
    public class TeacherService : ITeacherservice
    {

        private readonly EmployeeDbContext _context;
        private readonly IMapper _mapper;
        public TeacherService(EmployeeDbContext _context, IMapper _mapper)
        {
            this._context = _context;
            this._mapper = _mapper;
        }

        public TeacherViewModel Add(TeacherViewModel teacher)
        {

            try
            {
                var teacherObj = _mapper.Map<Teacher>(teacher);

                var reversemap = _mapper.Map<TeacherViewModel>(teacherObj);

                Teacher teacher1 = new Teacher();
                teacher1.Name = teacher.Name;
                teacher1.Email = teacher.Email;

                _context.Teachers.Add(teacherObj);
                _context.SaveChanges();

                return teacher;
            }
            catch (Exception ex)
            {

                ErrorHanler errorHanler = new ErrorHanler();
                errorHanler.WriteError(ex.Message, "Inside Service");
            }

            return null;
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
