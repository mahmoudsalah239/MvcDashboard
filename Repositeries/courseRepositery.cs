using TranningCenter.DataAccessLayer;
using TranningCenter.interfaces;
using TranningCenter.Models;
namespace TranningCenter.Repositeries
{
    public class courseRepositery : IcourseRepositery

    {
        Context context;
        public courseRepositery(Context _context)
        {
            context = _context;
        }


        public List<Course> GetAll()
        {
            return context.Courses.ToList();
        }

        public void insert(Course obj)
        {
            context.Add(obj);

        }
        public void update(Course obj)
        {
            context.Update(obj);
        }
        public void delete(int id)
        {
            Course course = Get(id);
            context.Courses.Remove(course);
        }

        public Course Get(int id)
        {
            return context.Courses.Find(id);
        }

        public int save()
        {
            return context.SaveChanges();
        }


    }
}
