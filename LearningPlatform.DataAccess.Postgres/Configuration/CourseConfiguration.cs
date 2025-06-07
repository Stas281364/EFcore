using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

//в Конфигурациях настраиваем наши класс для БД

namespace LearningPlatform.DataAccess.Postgres.Configuration
{
    public class CourseConfiguration : IEntityTypeConfiguration<CourseEntity>
    {
        public void Configure(EntityTypeBuilder<CourseEntity> builder)
        {

            //Настройка первичного ключа
            builder.HasKey(c => c.Id);

            //Настройка связи Автор имеет ОДИН КУРС и КУРС имеет ОДНОГО АВТОРА
            //Связь один к одному
            //Дублируем связь из AuthorEntity
            builder
                .HasOne(c => c.Author)
                .WithOne(c => c.Course);

            //Настройка связи Курс имеет МНОГО занятий и занятия имеют ОДИН курс
            //связь один ко многим
            //Занятие имеет внешний ключ указывающий на курс
            builder
                .HasMany(c => c.Lessons)
                .WithOne(l => l.Course)
                .HasForeignKey(l => l.CourseId);

            //Настройка связи Курс имеет много студентов и студетны имеют много курсов
            builder
               .HasMany(c => c.Students)
               .WithMany(s => s.Courses);
        }
    }
}
