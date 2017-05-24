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
    public class EmployeeSkillsController
    {
        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public List<SkillsList> SkillsList_Get(int employeeID) {
            using (var context = new WorkScheduleContext())
            {
                var results = from x in context.EmployeeSkills
                              where x.EmployeeID == employeeID
                              select new SkillsList
                              {
                                  ID = x.SkillID,
                                  Description = x.Skill.Description

                              };
                return results.ToList();
            }

        }

    }
}
