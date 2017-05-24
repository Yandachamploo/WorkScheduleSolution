using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endregion
namespace WorkScheduleSystem.Data.Entities
{
    [Table("Employees")]
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomePhone { get; set; }
        public Boolean Active { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
   
    }
}
