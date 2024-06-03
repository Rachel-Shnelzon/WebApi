using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ICourseRepository
    {
        public Course Get(int id);
        public List<Course> Get();
        public void Post(Course course);
        public void Put(int id,Course course);
        public void Delete(int id);
    }
}
