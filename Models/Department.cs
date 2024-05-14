namespace TranningCenter.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Manager { get; set; }
        public string? Discription { get; set; }
        public DateTime creationDate { get; set; }
        public bool IsDeleted { get; set; } = false;



        public List<Instructor> instructors { get; }
        public List<Course> courses { get; }
        public List<Traniee> Traniees { get; }

    }
}
