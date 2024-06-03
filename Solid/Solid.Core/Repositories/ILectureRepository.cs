using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ILectureRepository
    {
        public Lecture Get(int id);
        public List<Lecture> Get();
        public void Post(Lecture lecture);
        public void Put(int id, Lecture lecture);
        public void Delete(int id);
    }
}
