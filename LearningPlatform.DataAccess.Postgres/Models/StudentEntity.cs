namespace LearningPlatform.DataAccess.Postgres.Models
{
    public class StudentEntity
    {
        //Id
        public Guid Id { get; set; }

        //Имя автора
        public string UserName { get; set; } = string.Empty;



        //У студента может быть множетсво курсов - один ко многим
        public List<CourseEntity>? Courses { get; set; } = [];
    }
}
