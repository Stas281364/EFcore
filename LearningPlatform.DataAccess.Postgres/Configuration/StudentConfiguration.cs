using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

//в Конфигурациях настраиваем наши класс для БД

namespace LearningPlatform.DataAccess.Postgres.Configuration
{
    public class StudentConfiguration : IEntityTypeConfiguration<StudentEntity>
    {
        public void Configure(EntityTypeBuilder<StudentEntity> builder)
        {

            //Настройка первичного ключа
            builder.HasKey(s => s.Id);

            //Настройка связи СТУДЕНТ имеет МНОГО Курсов и КУРС имеет МНОГО студентов
            //Связь многие ко многим
            builder
                .HasMany(s => s.Courses)
                .WithMany(c => c.Students);

            
        }
    }
}
