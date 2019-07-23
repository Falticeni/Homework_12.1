using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyMVCApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Display(Name = "StudentName")]
        [Required]
        public string StudentName { get; set; }
        [Range(5, 50)]
        [Required(ErrorMessage = "Please enter student name.")]
        public int Age { get; set; }
        public bool isNewlyEnrolled { get; set; }
        public Standard standard { get; set; }
        public Gender Gender { get; set; }
        public string Password { get; set; }

    }

    public class Standard
    {
        public int StandardId { get; set; }
        public string StandardName { get; set; }
        public string StandardAge { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}