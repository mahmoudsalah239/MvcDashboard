using System.ComponentModel.DataAnnotations.Schema;

namespace TranningCenter.Models
{
    public class Traniee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
        public string Address { get; set; }
        public int Grade { get; set; }
        public string Phone { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }


        public Department Department { get; set; }

    }
}
