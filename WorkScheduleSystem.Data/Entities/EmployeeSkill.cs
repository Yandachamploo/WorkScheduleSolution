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
    [Table("EmployeeSkills")]
    public class EmployeeSkill
    {
        [Key]
        public int EmployeeSkillID { get; set; }
        public int EmployeeID { get; set; }
        public int SkillID { get; set; }
        public int Level { get; set; }
        public int YearsOfExperience { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Skill Skill { get; set; }
    }
}
