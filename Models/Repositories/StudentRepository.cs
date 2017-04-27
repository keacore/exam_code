using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private MyDbContext _db;
        private DbSet<Student> _students;

        public StudentRepository(MyDbContext db)
        {
            _db = db;
            _students = db.Students;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Student> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Save(Student student)
        {
            _db.Students.Add(student);
            _db.SaveChanges();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}