using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using University.Models;
using System.Collections.Generic;
using System.Linq;

namespace University.Controllers
{
  public class StudentsController : Controller
  {
    private readonly UniversityContext _db;

    public StudentsController(UniversityContext db)
    {
      _db = db;
    }

    public ActionResult Index()
    {
      return View(_db.Students.ToList());
    }

    public ActionResult Create()
    {
      ViewBag.CourseId = new SelectList(_db.Courses, "CourseId", "Name");
      return View();
    }

    [HttpPost]
    public ActionResult Create(Student student, int CourseId)
    {
      _db.Students.Add(student);
      _db.SaveChanges();
      if (CourseId != 0)
      {
          _db.StudentCourse.Add(new StudentCourse() { CourseId = CourseId, StudentId = student.StudentId });
          _db.SaveChanges();
      }
      return RedirectToAction("Index");
    }
  }
}