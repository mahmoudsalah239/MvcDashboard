namespace TranningCenter.Models
{
    public class CrsResualt
    {
        public int Id { get; set; }
        public double Degree { get; set; }
        public int TranieeId { get; set; }
        public int CourseId { get; set; }

        public Traniee Traniee { get; set; }
        public Course Course { get; set; }



    }
}
