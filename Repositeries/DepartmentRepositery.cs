using Microsoft.EntityFrameworkCore;
using TranningCenter.DataAccessLayer;
using TranningCenter.interfaces;
using TranningCenter.Models;

namespace TranningCenter.Repositeries
{
    public class DepartmentRepositery : IdepartmentRepositery
    {
        Context Context;
        public DepartmentRepositery(Context _Context)
        {
            Context = _Context;

        }

        public int Add(Department Entity)
        {
            Context.Add(Entity);
            return Context.SaveChanges();
        }

        public int Delete(Department Entity)
        {
            Context.Remove(Entity);
            return Context.SaveChanges();
        }

        public Department Get(int id)
        {
            return Context.Departments.Find(id);
        }

        public IEnumerable<Department> GetAll()
        {
            return Context.Departments.AsNoTracking().ToList();
        }
        public int Update(Department Entity)
        {
            Context.Update(Entity);
            return Context.SaveChanges();
        }
    }
}
