using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

//в Конфигурациях настраиваем наши класс для БД

namespace LearningPlatform.DataAccess.Postgres.Configuration
{
    public class LessonConfiguration : IEntityTypeConfiguration<LessonEntity>
    {
        public void Configure(EntityTypeBuilder<LessonEntity> builder)
        {

            //Настройка первичного ключа
            builder.HasKey(l => l.Id);

            //Настройка связи ЗАНЯТИЕ имеет ОДИН Курс и КУРС имеет МНОГО Занятий
            //Связь один ко многим
            //Занятие имеет внешний ключ указывающее на курс
            builder.HasOne(l => l.Course)
                .WithMany(c => c.Lessons)
                .HasForeignKey(l => l.CourseId);


        }
    }
}
