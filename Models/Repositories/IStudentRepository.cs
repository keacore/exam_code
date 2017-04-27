using System.Collections.Generic;

namespace ConsoleApplication.Models.Repositories
{
    public interface IStudentRepository
    {
        // Basic Crud opreation
       IEnumerable<Student> GetAll();
       Student Get(int id);
       void Delete(int id);
       void Update(Student student);
       void Save(Student student);

    }
}
