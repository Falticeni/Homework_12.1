using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMVCApplication.Models;
using MyMVCApplication.App_Start;

namespace MyMVCApplication.Controllers
{
    [Log]
    public class StudentController : Controller
    {
        public List<Student> studentList = new List<Student>{
                            new Student() { Id = 1, StudentName = "John", Age = 18 },
                            new Student() { Id = 2, StudentName = "Steve",  Age = 21 },
                            new Student() { Id = 3, StudentName = "Bill",  Age = 25 },
                            new Student() { Id = 4, StudentName = "Ram" , Age = 20 },
                            new Student() { Id = 5, StudentName = "Ron" , Age = 31 },
                            new Student() { Id = 6, StudentName = "Chris" , Age = 17 },
                            new Student() { Id = 7, StudentName = "Rob" , Age = 19 }
                        };
        // GET: Student
        public ActionResult Index()
        {
            //// Throws runtime exception as it already has "Id" Key
            //ViewBag.Id = 1;
            //ViewData.Add("Id", 1);
            //ViewData.Add(new KeyValuePair<string, object>("Name", "Billy the Kid"));
            //ViewData.Add(new KeyValuePair<string, object>("Age", 20));
            ViewBag.TotalStudents = studentList.Count;
            ViewData["students"] = studentList;
            return View(studentList);
        }

        public ActionResult Edit(int Id)
        {
            // Get the students from the database in the real application
            var std = studentList.Where(s => s.Id == Id).FirstOrDefault();
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            if (ModelState.IsValid)
            {
                var existingUser = studentList.Find(s => s.Id == std.Id);
                var existingStd = std;
                existingStd.Age = std.Age;
                existingStd.Id = std.Id;
                existingStd.StudentName = std.StudentName;
                existingStd.standard = std.standard;

                //var age = std.Age;
                //var id = std.Id;
                //var studentName = std.StudentName;
                //var standardName = std.standard.StandardName;
                //var standardAge = std.standard.StandardAge;
                //var standardId = std.standard.StandardId;
            }
            return RedirectToAction("Index");
        }





        //[HttpDelete]
        //public ActionResult Delete(int id)
        //{
        //    // delete student from the database whose id matches with specified id

        //    return RedirectToAction("Index");
        //}



        //public StudentController()
        //{

        //}





        [ActionName("find")]
        public ActionResult GetById(int id)
        {
            // get student from the database 
            return View();
        }

        [NonAction]
        public Student GetStudent(int id)
        {
            return studentList.Where(s => s.Id == id).FirstOrDefault();
        }

        [HttpPost]
        public ActionResult PostAction()
        {
            return View("Index");
        }

        [HttpPut]
        public ActionResult PutAction()
        {
            return View("Index");
        }

        [HttpDelete]
        public ActionResult DeleteAction()
        {
            return View("Index");
        }

        [HttpHead]
        public ActionResult HeadAction()
        {
            return View("Index");
        }

        [HttpOptions]
        public ActionResult OptionsAction()
        {
            return View("Index");
        }

        [HttpPatch]
        public ActionResult PatchAction()
        {
            return View("Index");
        }

        [AcceptVerbs(HttpVerbs.Post | HttpVerbs.Get)]
        public ActionResult GetAndPostAction()
        {
            return RedirectToAction("Index");
        }



    }
}