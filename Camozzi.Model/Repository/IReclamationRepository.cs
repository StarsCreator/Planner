using System;
using System.Collections.Generic;
using Camozzi.Model.DataService;

namespace Camozzi.Model.Repository
{
    public interface IReclamationRepository:IRepository<ReclamationDto>
    {
        IEnumerable<ReclamationDto> GetByDateAndDept(DateTime start, DateTime finish);
        List<ReclamationDto> GetByUser(int id);
        List<ReclamationDto> GetByManager(int id);
        List<ReclamationDto> GetAllByName(string name);

        event Action ReclamationUpdated;
    }
}
