using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LearningPlatform.DataAccess.Postgres.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

//в Конфигурациях настраиваем наши класс для БД

namespace LearningPlatform.DataAccess.Postgres.Configuration
{
    public class AuthorConfiguration : IEntityTypeConfiguration<AuthorEntity>
    {
        public void Configure(EntityTypeBuilder<AuthorEntity> builder)
        {

            //Настройка первичного ключа
            builder.HasKey(a => a.Id);

            //Настройка связи Автор имеет ОДИН КУРС и КУРС имеет ОДНОГО АВТОРА
            //Связь один к одному
            builder
                .HasOne(a => a.Course)
                .WithOne(c => c.Author);

        }
    }
}
