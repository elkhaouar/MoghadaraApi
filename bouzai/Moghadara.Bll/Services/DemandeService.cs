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
    public class DemandeService : IServices<Demande>
    {
        IRepository<Demande> repository;

        public DemandeService(IRepository<Demande> repository)
        {
            this.repository = repository;
        }

        public void Delete(int id)
        {
            repository.Delete(id);
        }

        public IEnumerable<Demande> GetAll()
        {
            return repository.GetAll();
        }

        public Demande GetById(int id)
        {
            return repository.GetById(id);
        }

        public void Post(Demande model)
        {
            repository.Post(model);
        }

        public void Put(Demande model, int id)
        {
            repository.Put(model, id);
        }
    }
}
