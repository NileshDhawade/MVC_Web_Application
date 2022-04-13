namespace MVC_WebApplication.Models
{
    public enum Gender { Male, Female }
    public class Employee
    {
      
        public int empId { get; set; }
        public string empName { get; set; }

        public decimal empSalary { get; set; }
    }
}
