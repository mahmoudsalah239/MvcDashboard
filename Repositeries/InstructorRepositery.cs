using Microsoft.EntityFrameworkCore;
using TranningCenter.DataAccessLayer;
using TranningCenter.interfaces;
using TranningCenter.Models;

namespace TranningCenter.Repositeries
{
    public class InstructorRepositery : IinstructorRepositery
    {
        Context Context;
        public InstructorRepositery(Context _Context)
        {
            Context = _Context;

        }
        public List<Instructor> GetAll()
        {
            return Context.Instructors.Include(c => c.Course)
                .ToList();
        }
        public Instructor Get(int id)
        {
            return Context.Instructors.Find(id);
        }
        public void insert(Instructor obj)
        {
            Context.Instructors.Add(obj);

        }

        public int save()
        {
            return Context.SaveChanges();
        }

        public void update(Instructor obj)
        {
            Context.Update(obj);
        }


        public void delete(int id)
        {
            Instructor obj = Get(id);
            Context.Remove(obj);
        }


    }
}
