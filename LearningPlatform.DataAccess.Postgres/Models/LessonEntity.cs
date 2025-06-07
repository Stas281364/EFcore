namespace LearningPlatform.DataAccess.Postgres.Models
{

    //Класс описывающий модель для БД
    //Класс описывает модель сущности "Урока/Занятия"
    public class LessonEntity
    {
        //id
        public Guid Id { get; set; }

        //заголовок
        public string Title { get; set; } = string.Empty;

        //Описание
        public string Description { get; set; } = string.Empty;

        //Cодержание урока
        public string LessonText { get; set; } = string.Empty;

        //Внешний ключ для связи урока с его курсом
        public Guid CourseId { get; set; }

        //Cсылка на курс, для взаимодейтсвия с сущностью курса
        public CourseEntity? Course { get; set; }
    }
}
