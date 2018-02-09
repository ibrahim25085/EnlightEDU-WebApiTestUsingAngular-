using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using StudentRegistrationWithAPI.Models;
using System.Web.Http.Cors;

namespace StudentRegistrationWithAPI.Controllers
{
   
    public class StudentsController : ApiController
    {
        private StudentDbContext db = new StudentDbContext();

        Students stu=new Students();

        // GET: api/Students
        public IQueryable<Students> GetStudent()
        {
            return db.Student;
        }

        // GET: api/Students/5
        [ResponseType(typeof(Students))]
        public IHttpActionResult GetStudents(int id)
        {
            Students students = db.Student.Find(id);
            if (students == null)
            {
                return NotFound();
            }

            return Ok(students);
          
        }

        // PUT: api/Students/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutStudents(int id, Students students)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != students.Id)
            {
                return BadRequest();
            }

            db.Entry(students).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentsExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Students
        [ResponseType(typeof(Students))]
        public IHttpActionResult PostStudents(Students students)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Student.Add(students);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = students.Id }, students);
        }

        // DELETE: api/Students/5
        [ResponseType(typeof(Students))]
        public IHttpActionResult DeleteStudents(int id)
        {
            Students students = db.Student.Find(id);
            if (students == null)
            {
                return NotFound();
            }

            db.Student.Remove(students);
            db.SaveChanges();

            return Ok(students);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool StudentsExists(int id)
        {
            return db.Student.Count(e => e.Id == id) > 0;
        }



        public List<Students> CreateStudentSObjects()
        {
            Students s1 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            Students s2 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            Students s3 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            Students s4 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            Students s5 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            Students s6 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            Students s7 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            Students s8 = new Students()
            {
                Id = 1,
                Name = "aa",
                Address = "bb",
                Email = "cc",
                Contact = "111"

            };
            List<Students> studentList = new List<Students>();
            studentList.Add(s1);
            studentList.Add(s2);
            studentList.Add(s3);
            studentList.Add(s4);
            studentList.Add(s5);
            studentList.Add(s6);
            studentList.Add(s7);
            studentList.Add(s8);

            return studentList;
        }



    }
}