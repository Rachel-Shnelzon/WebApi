using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface IPupilRepository
    {
        public Pupil Get(int id);
        public List<Pupil> Get();
        public void Post(Pupil pupil);
        public void Put(int id, Pupil pupil);
        public void Delete(int id);
    }
}
