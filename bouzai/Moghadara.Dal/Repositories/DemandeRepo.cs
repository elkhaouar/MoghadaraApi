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
    internal class DemandeRepo : IRepository<Demande>
    {
        MoghadaraateContext _context;
        public void Delete(int id)
        {
            var demande = GetById(id);
            demande.FlagSupp = 1;
            _context.SaveChanges();
        }

        public IEnumerable<Demande> GetAll()
        {
            return _context.Demandes.Where(f => f.FlagSupp == 1);
        }

        public Demande GetById(int id)
        {
            return _context.Demandes.FirstOrDefault(f => f.IdDemd == id && f.FlagSupp == 1);
        }

        public void Post(Demande model)
        {
            _context.Add(model);
            _context.SaveChanges();
        }

        public void Put(Demande model, int id)
        {
            var demande = GetById(id);
           demande.IdQuitterTerritoir = model.IdQuitterTerritoir;
            demande.DateDebut=model.DateDebut;
            demande.NumDemande=model.NumDemande;
            demande.UserSaisie = model.UserSaisie;
            demande.DateSaisie = model.DateSaisie;
            demande.Valide=model.Valide;
            demande.Cause = model.Cause;
            demande.Dure = model.Dure;
            demande.DateValideTab = model.DateValideTab;
            demande.TelPay=model.TelPay;
            demande.AdressPay=model.AdressPay;
            demande.InfoSuppTab=model.InfoSuppTab;
            demande.DateAutorisation  =model.DateAutorisation;
            demande.IdFonct=model.IdFonct;
            demande.IdPay=model.IdPay;
            demande.IdEtab=model.IdEtab;
            _context.SaveChanges();
        }
    }
}
