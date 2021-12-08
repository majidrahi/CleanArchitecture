using CleanArch.Domain.Interfaces;
using CleanArch.Domain.Models;
using CleanArch.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace CleanArch.Infra.Data.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly UniversityDbContext context;

        public CourseRepository(UniversityDbContext context)
        {
            this.context = context;
        }
        public async Task<IEnumerable<Course>> GetCourses()
        {
            return await context.Courses.ToListAsync();
        }
    }
}
