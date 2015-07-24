using System;
using System.Collections.Generic;
using System.Linq;
using Camozzi.Model.DataService;
using Camozzi.Model.Services;

namespace Camozzi.Model.Repository
{
    public class ReclamationRepository : IReclamationRepository
    {
        private List<ReclamationDto> _reclamation = new List<ReclamationDto>();
        private readonly ILog _log;

        public ReclamationRepository(ILog log)
        {
            UpdateContext();
            _log = log;
        }

        public List<ReclamationDto> GetAll()
        {
            return _reclamation;
        }

        public IEnumerable<ReclamationDto> GetByDateAndDept(DateTime start, DateTime finish)
        {
            return (from rec in _reclamation
                    //where rec.Start > start
                    where rec.Finish < finish
                    select rec).ToList();
        }

        public List<ReclamationDto> GetByUser(int id)
        {
            return (from pr in _reclamation
                    where pr.UserId == id
                    select pr).ToList();
        }

        public List<ReclamationDto> GetByManager(int id)
        {
            return (from pr in _reclamation
                    where pr.ManagerId == id
                    select pr).ToList();
        }

        public List<ReclamationDto> GetAllByName(string name)
        {
            return (from rec in _reclamation
                    where rec.Nomenclature.Contains(name)
                    select rec).ToList();
        }

        public event Action ReclamationUpdated;

        public ReclamationDto FindById(int id)
        {
            return _reclamation.Find(x => x.Id == id);
        }

        public ReclamationDto FindByName(string name)
        {
            return _reclamation.Find(x => x.Nomenclature.Contains(name));
        }

        public void Add(ReclamationDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.AddReclamation(t);
                UpdateContext();
            }
        }

        public void Delete(ReclamationDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.DeleteReclamation(t);
                UpdateContext();
            }
        }

        public void Update(ReclamationDto t)
        {
            using (var client = new CServiceClient("BasicHttpBinding_ICService"))
            {
                client.UpdateReclamation(t);
                UpdateContext();
            }
        }

        public void UpdateContext()
        {
            try
            {
                using (var client = new CServiceClient("BasicHttpBinding_ICService"))
                {
                    _reclamation = client.GetReclamations().ToList();
                }
                if (ReclamationUpdated != null) ReclamationUpdated();
            }
            catch (Exception ex)
            {
                _log.Error("ReclamatonUpdateContext",ex.InnerException.ToString());
                
            }

        }

    }

}
