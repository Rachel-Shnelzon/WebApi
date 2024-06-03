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
    public class PupilService : IPupilService
    {
        private readonly IPupilRepository _pupilRepository;
        public PupilService(IPupilRepository pupilRepository)
        {
            _pupilRepository = pupilRepository;
        }
        public Pupil Get(int id)
        {
            return _pupilRepository.Get(id);
        }
        public List<Pupil> Get()
        {
            return _pupilRepository.Get();
        }
        public void Post(Pupil pupil)
        {
            _pupilRepository.Post(pupil);
        }
        public void Put(int id, Pupil pupil)
        {
            _pupilRepository.Put(id, pupil);
        }
        public void Delete(int id)
        {
            _pupilRepository.Delete(id);
        }
    }
}
