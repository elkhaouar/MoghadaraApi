using Moghadara.Bll.ServiceAbstractions;
using Moghadara.Dal.RepositoryAbstractions;
using MoghadaraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moghadara.Bll.Services
{
    public class FonctionnaireService : IServices<Fonctionnaire>
    {
        IRepository<Fonctionnaire> repository;

        public FonctionnaireService(IRepository<Fonctionnaire> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<Fonctionnaire> GetAll()
        {
                return repository.GetAll(); 
          }

        public Fonctionnaire GetById(int id)
        {
            return  repository.GetById(id);
                }

        public void Post(Fonctionnaire model)
        {
            repository.Post(model);
        }

        public void Put(Fonctionnaire model, int id)
        {
            repository.Put(model, id);
        }
    }
}
