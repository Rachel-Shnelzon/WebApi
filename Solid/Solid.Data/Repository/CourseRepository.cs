using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private readonly DataContext _dataContext;
        public CourseRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Course Get(int id)
        {
            return _dataContext.Courses.ToList().Find(c => c.Id == id);
        }

        public List<Course> Get()
        {
            return _dataContext.Courses;
        }

        public void Post(Course course)
        {
            _dataContext.Courses.Add(course);
        }

        public void Put(int id, Course course)
        {
            _dataContext.Courses[id] = course;
        }
        public void Delete(int id)
        {
            var course = _dataContext.Courses.Find(c => c.Id == id);
            _dataContext.Courses.Remove(course);
        }
    }
}
