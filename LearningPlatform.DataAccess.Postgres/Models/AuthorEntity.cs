using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningPlatform.DataAccess.Postgres.Models
{
    public class AuthorEntity
    {
        //Id
        public Guid Id { get; set; }

        //Имя автора
        public string UserName { get; set; } = string.Empty;

        //Внешний ключ для курса связывающий курс и автора - связь ОДИН К ОДНОМУ
        public Guid CoursId { get; set; }

        //Ссылка на курс автора - связь ОДИН К ОДНОМУ
        public CourseEntity? Course { get; set; }
    }
}
