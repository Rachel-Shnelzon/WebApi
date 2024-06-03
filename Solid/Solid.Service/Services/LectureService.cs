using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service.Services
{
    public class LectureService : ILectureService
    {
        private readonly ILectureRepository _lectureRepository;
        public LectureService(ILectureRepository lectureRepository)
        {
            _lectureRepository = lectureRepository;
        }
        public Lecture Get(int id)
        {
            return _lectureRepository.Get(id);  
        }
        public List<Lecture> Get()
        {
            return _lectureRepository.Get();
        }
        public void Post(Lecture lecture)
        {
            _lectureRepository.Post(lecture);
        }
        public void Put(int id, Lecture lecture)
        {
            _lectureRepository.Put(id, lecture);
        }
        public void Delete(int id)
        {
            _lectureRepository.Delete(id);
        }
    }
}
