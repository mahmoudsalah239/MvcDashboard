using TranningCenter.Models;

namespace TranningCenter.interfaces
{
    public interface IinstructorRepositery
    {
        List<Instructor> GetAll();
        Instructor Get(int id);
        void insert(Instructor obj);
        void update(Instructor obj);
        void delete(int id);
        int save();


    }
}
