using System;
using System.Collections.Generic;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Repository
{
    public interface IReclamationRepository:IRepository<Reclamation>
    {
        IEnumerable<Reclamation> GetByDateAndDept(DateTime start, DateTime finish);
        List<Reclamation> GetByUser(int id);
        List<Reclamation> GetByManager(int id);
        List<Reclamation> GetAllByName(string name);

        event Action ReclamationUpdated;
    }
}
