using Camozzi.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Model.Repository
{
    public class ReclamationRepository : RepositoryBase<Reclamation>, IReclamationRepository
    {
        public override Reclamation FindByName(string name)
        {
            return _context.Reclamations.Where(x => x.Nomenclature == name).First();
        }

        public List<Reclamation> GetByDateAndDept(DateTime Start, DateTime Finish)
        {
            var proj = (from rec in _context.Reclamations
                        where rec.Start>Start 
                        where rec.Finish < Finish
                        select rec).ToList();
            return proj;
        }

        public List<Reclamation> GetAllByName(string name)
        {
            var proj = (from rec in _context.Reclamations
                        where rec.Nomenclature.Contains(name)
                        select rec).ToList();
            return proj;
        }

        public List<Reclamation> GetByUser(int id)
        {
            var proj = (from pr in _context.Reclamations
                        where pr.UserId == id
                        select pr).ToList();
            return proj;
        }

        public List<Reclamation> GetByManager(int id)
        {
            var proj = (from pr in _context.Reclamations
                        where pr.ManagerId == id
                        select pr).ToList();
            return proj;
        }

        public override void Update(Reclamation t)
        {
            _context.Reclamations.Attach(t);
            var entry = _context.Entry(t);
            entry.Property(e => e.Act).IsModified = true;
            entry.Property(e => e.Count).IsModified = true;
            entry.Property(e => e.Nomenclature).IsModified = true;
            entry.Property(e => e.ReclamationAct).IsModified = true;
            entry.Property(e => e.Send).IsModified = true;
            entry.Property(e => e.Start).IsModified = true;
            entry.Property(e => e.Finish).IsModified = true;
            entry.Property(e => e.Solution).IsModified = true;
            entry.Property(e => e.UserId).IsModified = true;
            entry.Property(e => e.ManagerId).IsModified = true;
            entry.Property(e => e.Comment).IsModified = true;
            entry.Property(e => e.Production).IsModified = true;
            entry.Property(e => e.State).IsModified = true;
            _context.SaveChanges();
        }
    }
}
