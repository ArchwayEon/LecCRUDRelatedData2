using LecCRUDRelatedData2.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace LecCRUDRelatedData2.Services;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();
    public DbSet<Course> Courses => Set<Course>();
    public DbSet<StudentCourseGrade> StudentCourseGrades => Set<StudentCourseGrade>();
    public DbSet<Internship> Internships => Set<Internship>();
}

