using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string HomePhone { get; set; }

        [Required]
        public bool Active { get; set; }

        public ICollection<Schedule> Schedules { get; set; }

        public ICollection<EmployeeSkill> EmployeeSkills { get; set; }
    }
}
