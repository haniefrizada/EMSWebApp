using EMSWebApp.Models;
using Microsoft.EntityFrameworkCore;

namespace EMSWebApp.Repository
{
    public class EMSInMemoryRepository : EMSRepository
    {
        static List<Employee> employeeList = new List<Employee>();
        static List<Department> departmentList = new List<Department>();

        /*static EMSInMemoryRepository()
        {
            employeeList.Add(new Employee("Administrator", 03/27/2000, "admin@gmail.com", "09655456839", 5));
        }*/
    }
}
