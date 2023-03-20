using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

namespace EMSWebApp.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        public string DeptName { get; set; }

        public ICollection<Employee> Employees { get; set; }

        /*public Department() { }

        public Department(int deptId, string deptName)
        {
            DeptId = deptId;
            DeptName = deptName;
        }*/
    }
}
