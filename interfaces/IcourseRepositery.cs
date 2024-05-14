using TranningCenter.Models;

namespace TranningCenter.interfaces
{
    public interface IcourseRepositery
    {
        List<Course> GetAll();
        Course Get(int id);
        void insert(Course obj);
        void update(Course obj);
        void delete(int id);
        int save();

    }
}
