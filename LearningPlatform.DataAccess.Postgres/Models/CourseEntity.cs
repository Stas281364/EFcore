namespace LearningPlatform.DataAccess.Postgres.Models
{
    //Класс описывающий модель для БД
    //Класс описывает модель сущности "Курса"
    public class CourseEntity
    {
        //id
        public Guid Id { get; set; }

        //заголовок
        public string Title { get; set; } = string.Empty;

        //Описание
        public string Description { get; set; } = string.Empty;

        //Цена курса
        public decimal price { get; set; } = 0;

        //Связь один-ко многим (1 курс имеет множество уроков)
        //Занятие 
        public List<LessonEntity> Lessons { get; set; } = [];

        //Id автора
        public Guid AuthorId {  get; set; }

        public AuthorEntity? Author { get; set; }

        public List<StudentEntity> Students { get; set; } = [];
    }
}
