using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Project_Group3.Models;
using WebLibrary.Models;
using WebLibrary.Repository;
namespace Project_Group3.Controllers
{


    public class QuizController : Controller
    {
        IQuizRepository quizRepository = null;
        IAnswerRepository answerRepository = null;
        IChapterRepository chapterRepository = null;
        ICourseRepository courseRepository = null;
        ILessonRepository lessonRepository = null;

        public QuizController()
        {
            quizRepository = new QuizRepository();
            answerRepository = new AnswerRepository();
            chapterRepository = new ChapterRepository();
            courseRepository = new CourseRepository();
            lessonRepository = new LessonRepository();
        }


        public ActionResult Index(int chapterId, int courseId)
        {
            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);
            var quizList = quizRepository.GetQuizzes();
            var answerList = answerRepository.GetAnswers();
            var quizzesToDisplay = quizList.Where(q => q.ChapterId == chapterId && q.CourseId == courseId).ToList();
            var model = Tuple.Create((IEnumerable<WebLibrary.Models.Quiz>)quizzesToDisplay, answerList, chapter, course);
            return View(model);
        }

        public ActionResult Create(int chapterId, int courseId)
        {
            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);

            if (chapter == null || course == null) return RedirectToAction("Error");

            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;
            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;
            ViewBag.Answers = answerRepository.GetAnswers();
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quiz quiz, int chapterId, int courseId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    if (string.IsNullOrEmpty(quiz.Quiz1))
                    {
                        ModelState.AddModelError("Quiz1", "Quiz1 is required.");
                    }

                    if (string.IsNullOrEmpty(quiz.DapAnA))
                    {
                        ModelState.AddModelError("DapAnA", "DapAnA is required.");
                    }

                    if (string.IsNullOrEmpty(quiz.DapAnB))
                    {
                        ModelState.AddModelError("DapAnB", "DapAnB is required.");
                    }

                    if (string.IsNullOrEmpty(quiz.DapAnC))
                    {
                        ModelState.AddModelError("DapAnC", "DapAnC is required.");
                    }

                    if (string.IsNullOrEmpty(quiz.DapAnD))
                    {
                        ModelState.AddModelError("DapAnD", "DapAnD is required.");
                    }

                    if (quiz.AnswerId == 0)
                    {
                        ModelState.AddModelError("AnswerId", "Please select an answer.");
                    }

                    if (ModelState.IsValid)
                    {
                        quizRepository.InsertQuiz(quiz);
                        return RedirectToAction("Index", new { chapterId = chapterId, courseId = courseId });
                    }
                }

                var answerList = answerRepository.GetAnswers();
                ViewBag.Answers = new SelectList(answerList, "AnswerId", "Answer1");
                return View(quiz);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                var chapter = chapterRepository.GetChapterByID(chapterId);
                var course = courseRepository.GetCourseByID(courseId);
                ViewBag.CourseId = courseId;
                ViewBag.ChapterId = chapterId;
                ViewBag.ChapterName = chapter.ChapterName;
                ViewBag.CourseName = course.CourseName;
                var answerList = answerRepository.GetAnswers();
                ViewBag.Answers = new SelectList(answerList, "AnswerId", "Answer1");
                return View(quiz);
            }
        }


     public IActionResult Test(int chapterId, int courseId, int lessonId, int numberOfQuestions, int correctCount)
{
    var allQuizzes = quizRepository.GetQuizzes();
    var chapter = chapterRepository.GetChapterByID(chapterId);
    var course = courseRepository.GetCourseByID(courseId);
    var lesson = lessonRepository.GetLessonByID(lessonId);
    var answerList = answerRepository.GetAnswers();
    var quizList = allQuizzes.Where(q => q.ChapterId == chapterId && q.CourseId == courseId);

    if (quizList.Count() < numberOfQuestions)
    {
        return RedirectToAction("Error");
    }

    var selectedAnswers = new List<Quiz>();

    foreach (var quiz in quizList)
    {
        var savedQuiz = allQuizzes.FirstOrDefault(q =>
            q.Quiz1 == quiz.Quiz1 &&
            q.DapAnA == quiz.DapAnA &&
            q.DapAnB == quiz.DapAnB &&
            q.DapAnC == quiz.DapAnC &&
            q.DapAnD == quiz.DapAnD);

        if (savedQuiz != null)
        {
            quiz.AnswerId = savedQuiz.AnswerId;
        }

        selectedAnswers.Add(quiz);
    }

    var result = new AnswerViewModels()
    {
        Chapter = chapter,
        Course = course,
        Lesson = lesson,
        Quiz = selectedAnswers,
        AnswerList = answerList.ToList(),
    };

    ViewBag.CorrectCount = correctCount;
    ViewBag.TotalCount = numberOfQuestions;

    return View(result);
}

[HttpPost]
public IActionResult Test(AnswerViewModels model)
{
    var chapter = chapterRepository.GetChapterByID(model.Chapter.ChapterId);
    var course = courseRepository.GetCourseByID(model.Course.CourseId);
    var quizList = model.Quiz;
    int correctCount = 0;
    int wrongCount = 0;

    foreach (var quiz in quizList)
    {
        var selectedAnswerId = quiz.AnswerId;
        var correctAnswerId = quizRepository.GetQuizByID(quiz.QuizId)?.AnswerId;
        quiz.IsCorrect = selectedAnswerId == correctAnswerId;

        if (quiz.IsCorrect.HasValue && quiz.IsCorrect.Value)
        {
            correctCount++;
        }
        else
        {
            wrongCount++;
        }
    }
    var result = new QuizResultViewModel
    {
        CorrectCount = correctCount,
        WrongCount = wrongCount,
        Chapter = chapter,
        Course = course,
        QuizList = quizList,
    };

    return ProcessPostResult(result);
}
public IActionResult ProcessPostResult(QuizResultViewModel model)
{
    var chapters = chapterRepository.GetChapters()
        .Where(c => c.CourseId == model.Course.CourseId)
        .OrderBy(c => c.Index)
        .ToList();

    var currentChapterIndex = chapters.FindIndex(c => c.ChapterId == model.Chapter.ChapterId);

    if (model.CorrectCount > model.WrongCount)
    {
        if (currentChapterIndex == chapters.Count - 1)
        {
            ViewBag.CompletionMessage = "Congratulations! You have completed the course.";
            return RedirectToAction("CourseDetail", "Home", new { Id = model.Course.CourseId });
        }
        else if (currentChapterIndex != -1 && currentChapterIndex < chapters.Count - 1)
        {
            var nextChapter = chapters[currentChapterIndex + 1];
            var firstLessonOfNextChapter = lessonRepository.GetLessons()
                .FirstOrDefault(l => l.ChapterId == nextChapter.ChapterId);

            if (firstLessonOfNextChapter != null)
            {
                return RedirectToAction("Learning", "Home", new { courseId = model.Course.CourseId, chapterId = nextChapter.ChapterId, lessonId = firstLessonOfNextChapter.LessonId });
            }
        }
    }
    else
    {
        return RedirectToAction("Test", "Quiz", new
        {
            chapterId = model.Chapter.ChapterId,
            courseId = model.Course.CourseId,
            lessonId = model.Lesson.LessonId
        });
    }

    return RedirectToAction("Test", "Quiz", new
    {
        chapterId = model.Chapter.ChapterId,
        courseId = model.Course.CourseId,
        lessonId = model.Lesson.LessonId
    });
}
        public ActionResult Edit(int? id)
        {
            if (id == null) return NotFound();

            var quiz = quizRepository.GetQuizByID(id.Value);

            if (quiz == null) return NotFound();

            ModelsView modelsView = new ModelsView { Quiz = quiz };

            ViewBag.AnswerId = quiz.AnswerId; // Add this line to pass the answers to the view
            var answerList = answerRepository.GetAnswers();
            ViewBag.AnswerList = new SelectList(answerList, "AnswerId", "Answer1");
            return View(modelsView);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ModelsView modelsView)
        {
            try
            {
                var quiz = quizRepository.GetQuizByID(modelsView.Quiz.QuizId);
                if (quiz != null)
                {
                    quizRepository.UpdateQuiz(modelsView.Quiz);
                    return RedirectToAction("Index", new { chapterId = quiz.ChapterId, courseId = quiz.CourseId });
                }

                ViewBag.Answers = answerRepository.GetAnswers(); // Add this line to pass the answers to the view

                return View(modelsView);
            }
            catch (Exception ex)
            {
                ViewBag.Message = ex.Message;
                return View(modelsView);
            }
        }
        public ActionResult Error() => View();

        public ActionResult Delete(int? id)
        {
            if (id == null) return NotFound();

            var Quiz = quizRepository.GetQuizByID(id.Value);
            var Answer = answerRepository.GetAnswerByID(Quiz.AnswerId.Value);
            if (Quiz == null) return NotFound();

            return View(new ModelsView { Quiz = Quiz, Answer = Answer });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(ModelsView modelsView)
        {
            try
            {
                var quiz = quizRepository.GetQuizByID(modelsView.Quiz.QuizId);
                if (quiz != null)
                {
                    quizRepository.DeleteQuiz(quiz.QuizId);
                    return RedirectToAction("Index", new { chapterId = quiz.ChapterId, courseId = quiz.CourseId });
                }
                return View(modelsView);
            }
            catch (Exception ex)

            {
                ViewBag.Message = ex.Message;
                return View(modelsView);
            }

        }
    }
}
