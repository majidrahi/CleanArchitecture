using CleanArch.Domain.Models;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel()
        {
            Courses = Enumerable.Empty<Course>();
        }
        public IEnumerable<Course> Courses { get; set; }
    }
}
