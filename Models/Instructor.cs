using System.ComponentModel.DataAnnotations.Schema;

namespace TranningCenter.Models
{
    public class Instructor
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public double Salary { get; set; }
        public string? Phone { get; set; }
        public string? Address { get; set; }
        [ForeignKey("Department")]
        public int departmentId { get; set; }
        [ForeignKey("Course")]
        public int courseId { get; set; }

        public Department Department { get; set; }
        public Course Course { get; set; }






    }
}
