using System.ComponentModel.DataAnnotations;

namespace LecCRUDRelatedData2.Models.Entities;

public class Student
{
    [Key, StringLength(10)]
    public string ENumber { get; set; } = String.Empty;
    [StringLength(32)]
    public string FirstName { get; set; } = String.Empty;
    [StringLength(32)]
    public string LastName { get; set; } = String.Empty;
    public ICollection<StudentCourseGrade> CourseGrades { get; set; }
        = new List<StudentCourseGrade>();
}

