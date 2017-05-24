using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel;
using WorkScheduleSystem.Data.Entities;
using WorkScheduleSystem.DAL;
using WorkScheduleSystem.Data.POCOS;
#endregion
namespace WorkScheduleSystem.BLL
{
    [DataObject]
    public class EmployeeController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<EmployeeNamesList> EmployeeNamesList_Get()
        {
            using (var context = new WorkScheduleContext())
            {
                var results = from x in context.Employees
                              orderby x.LastName
                              select new EmployeeNamesList
                              {
                                  ID = x.EmployeeID,
                                  Name = x.LastName + "," + x.FirstName

                              };
                return results.ToList();

            }

        }

    }
}
