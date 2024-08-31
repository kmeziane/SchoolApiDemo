using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace SchoolApiDemo.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public ICollection<Course>? Courses { get; set; }
    }
}
