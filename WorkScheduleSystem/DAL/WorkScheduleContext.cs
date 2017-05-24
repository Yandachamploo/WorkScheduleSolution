using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.Data.Entity;
using WorkScheduleSystem.Data.Entities;
#endregion
namespace WorkScheduleSystem.DAL
{
    internal class WorkScheduleContext :DbContext
    {
        public WorkScheduleContext(): base("WorkScheduleDB")
            {}

        public DbSet<Employee> Employees { get; set; }

        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }
        public DbSet<Skill> Skills { get; set; }
    }
}
