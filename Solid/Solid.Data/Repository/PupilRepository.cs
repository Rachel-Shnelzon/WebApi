using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class PupilRepository : IPupilRepository
    {
        private readonly DataContext _dataContext;
        public PupilRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Pupil> Get()
        {
            return _dataContext.Pupils;
        }
        public Pupil Get(int id)
        {
            return _dataContext.Pupils.ToList().Find(p=>p.Id==id);
        }
        
        public void Post(Pupil pupil)
        {
            _dataContext.Pupils.Add(pupil);
        }
        public void Put(int id, Pupil pupil)
        {
            _dataContext.Pupils[id] = pupil;
        }
        public void Delete(int id)
        {
            var pupil = _dataContext.Pupils.Find(p=>p.Id==id);
            _dataContext.Pupils.Remove(pupil);  
        }
    }
}
