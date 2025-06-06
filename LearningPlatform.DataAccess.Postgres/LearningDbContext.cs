using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.DataAccess.Postgres
{
    public class LearningDbContext : DbContext
    {
        //Представляем наши сущности в таблице БД
        public DbSet<AuthorEntity> Authors {  get; set; }

        public DbSet<CourseEntity> Courses { get; set; }

        public DbSet<LessonEntity> Lesson { get; set; }

        public DbSet<StudentEntity> Students { get; set; }

    }
}
