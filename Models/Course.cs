using System.ComponentModel.DataAnnotations.Schema;

namespace TranningCenter.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Degree { get; set; }
        public double MinDegree { get; set; }
        public int Hours { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public bool isDeleted { get; set; } = false;

        public List<CrsResualt> CrsResualts { get; set; }
        public List<Instructor> Instructors { get; set; }
        public Department Department { get; set; }

    }
}
