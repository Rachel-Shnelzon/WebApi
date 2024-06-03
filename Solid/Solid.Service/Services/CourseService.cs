using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;
        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Course Get(int id)
        {
            return _courseRepository.Get(id);
        }
        public List<Course> Get()
        {
            return _courseRepository.Get();
        }
        public void Post(Course course)
        {
            _courseRepository.Post(course);
        }
        public void Put(int id, Course course)
        {
            _courseRepository.Put(id, course);
        }
        public void Delete(int id)
        {
            _courseRepository.Delete(id);  
        }
    }
}
