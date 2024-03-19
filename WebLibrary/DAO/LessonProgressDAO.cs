using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebLibrary.Models;

namespace WebLibrary.DAO
{
    public class LessonProgressDAO
    {
        private static LessonProgressDAO instance = null;
        private static readonly object instanceLock = new object();
        public static LessonProgressDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new LessonProgressDAO();

                    }
                    return instance;
                }
            }
        }
        private DBContext dbContext;
        public LessonProgressDAO()
        {
            dbContext = new DBContext(); 
        }

  
        public void AddLessonProgress(LessonProgress LessonProgress)
        {
            dbContext.LessonProgresses.Add(LessonProgress);
            dbContext.SaveChanges();
        }

        public void UpdateLessonProgress(LessonProgress LessonProgress)
        {
            var existingLessonProgress = dbContext.LessonProgresses.Find(LessonProgress.LessonProgressId);
            if (existingLessonProgress != null)
            {
                existingLessonProgress.LearnerId = LessonProgress.LearnerId;
                existingLessonProgress.ChapterId = LessonProgress.ChapterId;
                existingLessonProgress.LessonId = LessonProgress.LessonId;
                existingLessonProgress.Completed = LessonProgress.Completed;
                existingLessonProgress.StartAt = LessonProgress.StartAt;

                dbContext.SaveChanges();
            }
        }


        public List<LessonProgress> GetLessonProgressByUserId(int LearnerId)
        {
            return dbContext.LessonProgresses.Where(lp => lp.LearnerId == LearnerId).ToList();
        }


        public List<LessonProgress> GetLessonProgressByCourseId(int ChapterId)
        {
            return dbContext.LessonProgresses.Where(lp => lp.ChapterId == ChapterId).ToList();
        }

        public List<LessonProgress> GetLessonProgressByCompletionStatus(bool isCompleted)
        {
            return dbContext.LessonProgresses.Where(lp => lp.Completed == isCompleted).ToList();
        }

        public void DeleteLessonProgress(int LessonProgressId)
        {
            var LessonProgressToDelete = dbContext.LessonProgresses.Find(LessonProgressId);
            if (LessonProgressToDelete != null)
            {
                dbContext.LessonProgresses.Remove(LessonProgressToDelete);
                dbContext.SaveChanges();
            }
        }
        public List<LessonProgress> GetLessonProgressByProgressPercentage(double progressPercentage)
        {
            var completedLessonCount = dbContext.LessonProgresses.Count(lp => (bool)lp.Completed);
            var totalLessonCount = dbContext.LessonProgresses.Count();
            var progress = (double)completedLessonCount / totalLessonCount * 100;
            if (progress >= progressPercentage)
            {
                return dbContext.LessonProgresses.Where(lp => (bool)lp.Completed).ToList();
            }
            else
            {
                return dbContext.LessonProgresses.Where(lp => !(bool)lp.Completed).ToList();
            }
        }

    }

}