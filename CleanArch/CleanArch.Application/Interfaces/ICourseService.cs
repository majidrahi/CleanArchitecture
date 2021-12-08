using CleanArch.Application.ViewModels;

namespace CleanArch.Application.Interfaces
{
    public interface ICourseService
    {
        Task<CourseViewModel> GetCourses();
    }
}
