using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebLibrary.Models;
using WebLibrary.Repository;

namespace Project_Group3.Controllers
{

    public class AnswerController : Controller
    {
        private readonly IAnswerRepository answerRepository;

        public AnswerController()
        {
            answerRepository = new AnswerRepository();
        }



        public ActionResult Detail(int? id)
        {
            if (id == null) return NotFound();

            var answer = answerRepository.GetAnswerByID(id.Value);

            if (answer == null) return NotFound();

            return View(answer);
        }

        public ActionResult Index()
        {
            var answerList = answerRepository.GetAnswers();
            return View(answerList);
        }

        public ActionResult Create() => View();

        // POST: Answer/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Answer answer)
        {
            try
            {
                answerRepository.InsertAnswer(answer);

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(answer);
            }
        }

        public ActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var answer = answerRepository.GetAnswerByID(id.Value);

            if (answer == null) return NotFound();

            return View(answer);
        }

        // POST: Answer/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Answer answer)
        {
            try
            {
                if (id != answer.AnswerId) return NotFound();

                if (ModelState.IsValid) answerRepository.UpdateAnswer(answer);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }

        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var answer = answerRepository.GetAnswerByID(id.Value);

            if (answer == null) return NotFound();

            return View(answer);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id)
        {
            try
            {
                answerRepository.DeleteAnswer(id);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View();
            }
        }
    }
}