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
    [Table("Skills")]
    public class Skill
    {
        [Key]
        public int SkillID { get; set; }
        public string Description { get; set; }
        public Boolean RequiresTicket { get; set; }

        public virtual ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
