using System;
using System.Collections.Generic;
using System.Linq;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Repository
{
    public class ReclamationRepository : IReclamationRepository
    {
        private List<Reclamation> _reclamations = new List<Reclamation>();

        public ReclamationRepository()
        {
            UpdateReclamations();
        }

        public List<Reclamation> GetAll()
        {
            return _reclamations;
        }

        public IEnumerable<Reclamation> GetByDateAndDept(DateTime start, DateTime finish)
        {
            return (from rec in _reclamations
                    where rec.Start > start
                    where rec.Finish < finish
                    select rec).ToList();
        }

        public List<Reclamation> GetByUser(int id)
        {
            return (from pr in _reclamations
                    where pr.UserId == id
                    select pr).ToList();
        }

        public List<Reclamation> GetByManager(int id)
        {
            return (from pr in _reclamations
                    where pr.ManagerId == id
                    select pr).ToList();
        }

        public List<Reclamation> GetAllByName(string name)
        {
            return (from rec in _reclamations
                    where rec.Nomenclature.Contains(name)
                    select rec).ToList();
        }

        public Reclamation FindById(int id)
        {
            return _reclamations.Find(x => x.Id == id);
        }

        public Reclamation FindByName(string name)
        {
            return _reclamations.Find(x => x.Nomenclature.Contains(name));
        }

        public void Add(Reclamation t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.AddReclamationAsync(t);
                UpdateReclamations();
            }
        }

        public void Delete(Reclamation t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.UpdateReclamationAsync(t);
                UpdateReclamations();
            }
        }

        public void Update(Reclamation t)
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                client.UpdateReclamationAsync(t);
                UpdateReclamations();
            }
        }

        private void UpdateReclamations()
        {
            using (var client = new CServiceClient("NetTcpBinding_ICService"))
            {
                _reclamations = client.GetReclamations().ToList();
            }
        }

    }

}
