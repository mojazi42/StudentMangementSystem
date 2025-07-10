using System;
using System.ComponentModel.DataAnnotations;

namespace StudentManagementSystem.Models
{
    public class Student
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot be longer than 100 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        [StringLength(100)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Course is required")]
        [StringLength(50, ErrorMessage = "Course cannot be longer than 50 characters")]
        public string Course { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Enrollment Date")]
        [Required(ErrorMessage = "Enrollment Date is required")]
        public DateTime EnrollmentDate { get; set; }
    }
}
