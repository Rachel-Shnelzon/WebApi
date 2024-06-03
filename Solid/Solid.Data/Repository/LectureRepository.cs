using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data.Repository
{
    public class LectureRepository : ILectureRepository
    {
        private readonly DataContext _dataContext;
        public LectureRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public Lecture Get(int id)
        {
            return _dataContext.Lectures.ToList().Find(p => p.Id == id);
        }
        public List<Lecture> Get()
        {
            return _dataContext.Lectures.ToList();
        }
        public void Post(Lecture lecture)
        {
            _dataContext.Lectures.Add(lecture);
        }
        public void Put(int id, Lecture lecture)
        {
            _dataContext.Lectures[id] = lecture;
        }
        public void Delete(int id)
        {
            var lecture= _dataContext.Lectures.Find(p => p.Id == id);
            _dataContext.Lectures.Remove(lecture);
        }
    }
}
