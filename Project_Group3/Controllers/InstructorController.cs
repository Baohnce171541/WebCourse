using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Project_Group3.Models;
using WebLibrary.DAO;
using WebLibrary.Repository;
using WebLibrary.Models;


namespace Project_Group3.Controllers
{
    public class InstructorController : Controller
    {
        IInstructorRepository instructorRepository = null;
        ICourseRepository courseRepository = null;
        IInstructRepository instructRepository = null;
        public InstructorController()
        {
            instructorRepository = new InstructorRepository();
            courseRepository = new CourseRepository();
            instructRepository = new InstructRepository();
        }

        public IActionResult Index(string search = "", int page = 1, int pageSize = 2)
        {
            try
            {
                var instructorList = instructorRepository.GetInstructors();

                if (!string.IsNullOrEmpty(search))
                {
                    instructorList = instructorList.Where(i => i.FirstName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0 || i.LastName.IndexOf(search, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                }


                var totalCount = instructorList.Count();
                var totalPages = (int)Math.Ceiling((double)totalCount / pageSize);

                instructorList = instructorList.Skip((page - 1) * pageSize).Take(pageSize).ToList();

                ViewBag.Search = search;
                ViewBag.PageSize = pageSize;
                ViewBag.TotalPages = totalPages;
                ViewBag.Quantity = totalCount;
                ViewBag.CurrentPage = page;
                return View(instructorList);
            }
            catch (System.Exception)
            {
                return View();
            }
        }

        public IActionResult Detail(int? id)
        {
            try
            {
                if (id == null) return NotFound();

                var instructor = instructorRepository.GetInstructorByID(id.Value);

                if (instructor == null) return NotFound();

                return View(instructor);
            }
            catch (System.Exception)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Next(int id)
        {
            try
            {
                var currentInstructor = instructorRepository.GetInstructorByID(id);
                var nextInstructor = instructorRepository.GetInstructors().FirstOrDefault(i => i.InstructorId > id);

                if (nextInstructor != null)
                {
                    return RedirectToAction("Detail", new { id = nextInstructor.InstructorId });
                }
                else
                {
                    var firstInstructor = instructorRepository.GetInstructors().FirstOrDefault();
                    return RedirectToAction("Detail", new { id = firstInstructor.InstructorId });
                }
            }
            catch (System.Exception)
            {
                return View();
            }
        }

        [HttpPost]
        public IActionResult Previous(int id)
        {
            try
            {
                var currentInstructor = instructorRepository.GetInstructorByID(id);

                var previousInstructor = instructorRepository.GetInstructors().LastOrDefault(i => i.InstructorId < id);

                if (previousInstructor != null)
                {
                    return RedirectToAction("Detail", new { id = previousInstructor.InstructorId });
                }
                else
                {
                    var lastInstructor = instructorRepository.GetInstructors().LastOrDefault();
                    return RedirectToAction("Detail", new { id = lastInstructor.InstructorId });
                }
            }
            catch (System.Exception)
            {
                return View();
            }
        }

        public ActionResult Create() => View();

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Instructor instructor)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    instructorRepository.InsertInstructor(instructor);
                }
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(instructor);
            }
        }

        public IActionResult Edit(int? id)
        {
            try
            {
                if (id == null) return NotFound();

                var instructor = instructorRepository.GetInstructorByID(id.Value);

                if (instructor == null) return NotFound();

                return View(instructor);
            }
            catch (System.Exception)
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Instructor instructor)
        {
            try
            {
                if (id != instructor.InstructorId) return NotFound();

                if (ModelState.IsValid)
                {
                    instructorRepository.UpdateInstructor(instructor);
                }
                return RedirectToAction("Instructor", "Admin");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult EditProfile(int id, Instructor instructor)
        {
            try
            {
                if (id != instructor.InstructorId) return NotFound();

                if (ModelState.IsValid)
                {
                    instructorRepository.UpdateInstructor(instructor);
                }
                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public IActionResult Delete(int? id)
        {
            try
            {
                if (id == null) return NotFound();

                var instructor = instructorRepository.GetInstructorByID(id.Value);

                if (instructor == null) return NotFound();

                return View(instructor);
            }
            catch (System.Exception)
            {
                return View();
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                instructorRepository.DeleteInstructor(id);
                TempData["DeleteSuccess"] = true;
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public IActionResult Dashboard(int id)
        {
            try
            {
                var ins = instructorRepository.GetInstructorByID(id);
                var courseList = courseRepository.GetCourses();
                var instructList = instructRepository.GetInstructs();
                ModelsView modelsView = new ModelsView
                {
                    Instructor = ins,
                    CourseList = courseList.ToList(),
                    InstructsList = instructList.ToList(),
                };
                return View(modelsView);
            }
            catch (System.Exception)
            {
                return View();
            }
        }
    }
}