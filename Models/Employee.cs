using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EMSWebApp.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }

        [ForeignKey("DepartmentId")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        /*public Employee(int id, string name, DateTime dateOfBirth, string email, string phone, int departmentId)
        {
            Id = id;
            Name = name;
            DateOfBirth = dateOfBirth;
            Email = email;
            Phone = phone;
            DepartmentId = departmentId;
        }*/
    }
}
