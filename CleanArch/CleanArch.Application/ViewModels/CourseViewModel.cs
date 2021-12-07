using CleanArch.Domain.Models;

namespace CleanArch.Application.ViewModels
{
    public class CourseViewModel
    {
        public CourseViewModel()
        {
            courses = Enumerable.Empty<Course>();
        }
        public IEnumerable<Course> courses { get; set; }
    }
}
