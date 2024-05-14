using TranningCenter.Models;

namespace TranningCenter.interfaces
{
    public interface IdepartmentRepositery
    {
        IEnumerable<Department> GetAll();

        Department Get(int id);

        int Add(Department Entity);

        int Update(Department Entity);

        int Delete(Department Entity);


    }
}
