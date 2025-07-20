using eShift_Logistics_System.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eShift_Logistics_System.Business.Interface
{
    public interface IUnitService
    {
       
        void AddUnit(TransportUnit unit);
       
        void UpdateUnit(TransportUnit unit);
       
        bool DeleteUnit(int id);
       
        List<TransportUnit> GetAllUnits();
        
        TransportUnit GetUnitById(int id);

        int GetLastUnitId();

        List<TransportUnit> GetAvailableUnits(int? currentUnitId = null);
    }
}
