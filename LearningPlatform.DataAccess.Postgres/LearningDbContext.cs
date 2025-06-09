using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningPlatform.DataAccess.Postgres.Configuration;
using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;

namespace LearningPlatform.DataAccess.Postgres
{
    public class LearningDbContext : DbContext
    {

        //Конструктор для регистрации DbContext в Depencity Injection
        public LearningDbContext(DbContextOptions<LearningDbContext> options)
            :base(options)
        {
            
        }

        //Представляем наши сущности в таблице БД
        public DbSet<AuthorEntity> Authors {  get; set; }

        public DbSet<CourseEntity> Courses { get; set; }

        public DbSet<LessonEntity> Lesson { get; set; }

        public DbSet<StudentEntity> Students { get; set; }


        //Применение конфигураций
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new LessonConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());

            base.OnModelCreating(modelBuilder);
        }

    }
}
