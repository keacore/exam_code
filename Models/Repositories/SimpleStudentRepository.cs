using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApplication.Models.Repositories
{
    public class SimpleStudentRepository : IStudentRepository
    {
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
            List<Student> stu = new List<Student>();
            stu.Add(new Student());

            return stu;
        }

        public void Save(Student student)
        {
            throw new NotImplementedException();
        }

        public void Update(Student student)
        {
            throw new NotImplementedException();
        }
    }
}