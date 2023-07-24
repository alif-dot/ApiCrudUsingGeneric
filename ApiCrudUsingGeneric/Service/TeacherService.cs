using ApiCrudUsingGeneric.IService;
using ApiCrudUsingGeneric.Models;

namespace ApiCrudUsingGeneric.Service
{
    public class TeacherService : IGenericService<Teacher>
    {
        List<Teacher> _Teachers = new List<Teacher>();
        public TeacherService()
        {
            for (int i = 1; i <= 9; i++)
            {
                _Teachers.Add(new Teacher()
                {
                    TeacherId = i,
                    Name = "Tch" + i,
                    Subject = "Sub" + i
                });
            }
        }
        public List<Teacher> Delete(int id)
        {
            _Teachers.RemoveAll(x => x.TeacherId == id);
            return _Teachers;
        }

        public List<Teacher> GetAll()
        {
            return _Teachers;
        }

        public Teacher GetById(int id)
        {
            return _Teachers.Where(x => x.TeacherId == id).SingleOrDefault();
        }

        public List<Teacher> Insert(Teacher item)
        {
            _Teachers.Add(item);
            return _Teachers;
        }
    }
}
