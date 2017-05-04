using System.Collections.Generic;

namespace ConsoleApplication.Models.Repositories
{
    public interface IEnrollmentRepository
    {
        // basicc CRUD for Enrollment
        void Save(Enrollment course);
        Course Get(int id);
        IEnumerable<Enrollment> GetAll();
        void Update(Enrollment course);
        void Delete(int id);
    }
}
