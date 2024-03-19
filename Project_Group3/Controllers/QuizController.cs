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
        // GET: Quiz/Create
        public ActionResult Create(int chapterId, int courseId)
        {
            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);

            if (chapter == null || course == null)
            {
                return RedirectToAction("Error");
            }

            ViewBag.ChapterId = chapterId;
            ViewBag.CourseId = courseId;
            ViewBag.ChapterName = chapter.ChapterName;
            ViewBag.CourseName = course.CourseName;
            ViewBag.Answers = answerRepository.GetAnswers();
            return View();
        }
        // POST: Quiz/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Quiz quiz, int chapterId, int courseId)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    // Additional validation for properties
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

                    // Check the selected value of the dropdown "DapAn"
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


        public ActionResult Test(int chapterId, int courseId, int numberOfQuestions, int correctCount)
        {
            var allQuizzes = quizRepository.GetQuizzes();
            var chapter = chapterRepository.GetChapterByID(chapterId);
            var course = courseRepository.GetCourseByID(courseId);
            var answerList = answerRepository.GetAnswers();
            var quizList = allQuizzes.Where(q => q.ChapterId == chapterId && q.CourseId == courseId);

            if (quizList.Count() < numberOfQuestions)
            {
                return RedirectToAction("Error");
            }

            // Create a list to store the selected answers
            var selectedAnswers = new List<Quiz>();

            // Loop through the quizList and populate the selected answers list
            foreach (var quiz in quizList)
            {
                // Find the corresponding answer from the saved quiz
                var savedQuiz = allQuizzes.FirstOrDefault(q => q.Quiz1 == quiz.Quiz1 && q.DapAnA == quiz.DapAnA && q.DapAnB == quiz.DapAnB && q.DapAnC == quiz.DapAnC && q.DapAnD == quiz.DapAnD);
                if (savedQuiz != null)
                {
                    // Set the selected answer to the saved answer
                    quiz.AnswerId = savedQuiz.AnswerId;
                }

                selectedAnswers.Add(quiz);
            }

            AnswerViewModels result = new AnswerViewModels()
            {
                Chapter = chapter,
                Course = course,
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
                QuizList = quizList
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
    if (model.CorrectCount > model.WrongCount && currentChapterIndex == chapters.Count - 1)
    {
        // Nếu đúng và không còn chương tiếp theo
        ViewBag.CompletionMessage = "Congratulations! You have completed the course.";
        return RedirectToAction("CourseDetail", "Home", new { Id = model.Course.CourseId }); // Chuyển về trang chính
    }
    else if (model.CorrectCount > model.WrongCount && currentChapterIndex != -1 && currentChapterIndex < chapters.Count - 1)
    {
        // Nếu đúng và còn chương tiếp theo
        var nextChapter = chapters[currentChapterIndex + 1];
        var lessonInNextChapter = lessonRepository.GetLessons()
            .FirstOrDefault(l => l.ChapterId == nextChapter.ChapterId);
        if (lessonInNextChapter != null)
        {
            // Lấy lessonId của bài học đầu tiên trong chương tiếp theo
            var firstLessonInNextChapter = lessonRepository.GetLessons()
                .FirstOrDefault(l => l.ChapterId == nextChapter.ChapterId);
            // Chuyển hướng đến trang Index của LessonController với lessonId, chapterId và courseId
            return RedirectToAction("LearnerLesson", "Lesson", new { chapterId = nextChapter.ChapterId, courseId = model.Course.CourseId });
        }
    }
    return RedirectToAction("Test", "Quiz", new
    {
        chapterId = model.Chapter.ChapterId,
        courseId = model.Course.CourseId,
        numberOfQuestions = model.QuizList.Count,
        correctCount = model.CorrectCount,
        totalCount = model.CorrectCount + model.WrongCount,
    });
}


        public ActionResult Error()
        {
            return View();
        }
    }
}
