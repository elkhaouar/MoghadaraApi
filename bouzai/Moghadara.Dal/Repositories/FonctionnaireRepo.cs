using Microsoft.EntityFrameworkCore;
using Moghadara.Dal.RepositoryAbstractions;
using MoghadaraApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moghadara.Dal.Repositories
{
    public class FonctionnaireRepo : IRepository<Fonctionnaire>
    {
        MoghadaraateContext _context;

        public FonctionnaireRepo(MoghadaraateContext context)
        {
            _context = context;
        }

        public void Delete(int id)
        {
            var fonctionnaire = GetById(id);
            fonctionnaire.FlaFonctionnaire = true;
            _context.SaveChanges();

        }

        public IEnumerable<Fonctionnaire> GetAll()
        {
            return _context.Fonctionnaires.Include(fon=> fon.Demandes).Where(f=>f.FlaFonctionnaire==false);
        }

        public Fonctionnaire GetById(int id)
        {
            return _context.Fonctionnaires.Include(fon => fon.Demandes).FirstOrDefault(f => f.IdFonct == id && f.FlaFonctionnaire == false);
        }
        public void Post(Fonctionnaire model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }

        public void Put(Fonctionnaire model, int id)
        {
          var fonctionnaire=GetById(id);
            fonctionnaire.Email=model.Email;
            fonctionnaire.Cin=model.Cin;
            fonctionnaire.Matricule=model.Matricule;    
            fonctionnaire.Tel=model.Tel;
            fonctionnaire.NumSomme=model.NumSomme;
            fonctionnaire.Nom=model.Nom;
            fonctionnaire.Prenom=model.Prenom;
            fonctionnaire.IdEtab=model.IdEtab;
            _context.SaveChanges();
        }
    }
}
