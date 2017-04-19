using System;
using System.Collections.Generic;
using System.Linq;
using ConsoleApplication.Models;
using Microsoft.AspNetCore.Mvc;

namespace ConsoleApplication.Controllers
{
    public class StudentController : Controller 
    {
        MyDbContext db = new MyDbContext();
        // Index
        [HttpGet]
        public IActionResult Index()
        {
            List<Student> students = db.Students.ToList();
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        //Create
        [HttpPost]
        public IActionResult Create(Student st)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(st);
                 db.SaveChanges();
                 return RedirectToAction("Index");

            } else 
            {
                return View();
            }   
        }

        // Update
        public IActionResult Update(int id)
        {
            Student student = db.Students.Find(id);
            return View(student);
        }
        [HttpPost]
        public IActionResult Update(Student student)
        {
            if(ModelState.IsValid)
            {
                db.Students.Add(student);
                 db.SaveChanges();
                 return RedirectToAction("Index");
            }
            
            return View(student);
        }

//  [HttpGet]
//         //Delete
//         public IActionResult Delete(int id)
//         {
            
//             Student student = db.Students.Find(id);
//             return View(student);
//         }

//         [HttpPost]
//         //Delete
//         public IActionResult Delete(int id)
//         {     
//             Student student = db.Students.Find(id);
//             RedirectToAction(Index);
//            // return View(student);
//         }

    }
}