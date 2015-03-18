using Camozzi.Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Camozzi.Model.Repository
{
    public interface IReclamationRepository
    {
        List<Reclamation> GetAll();
        List<Reclamation> GetByDateAndDept(DateTime Start, DateTime Finish);
        List<Reclamation> GetByUser(int id);
        List<Reclamation> GetByManager(int id);
        List<Reclamation> GetAllByName(string name);

        Reclamation FindById(int id);
        Reclamation FindByName(string name);

        void Update(Reclamation t);
    }
}
