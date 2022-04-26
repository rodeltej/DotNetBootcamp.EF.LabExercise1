using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Schedule
    {
        public int ScheduleID { get; set; }

        [Required]
        public DateTime Day { get; set; }

        public int ShiftID { get; set; }

        public Shift Shift { get; set; }

        public int EmployeeID { get; set; }

        public Employee Employee { get; set; }

        [Required]
        public decimal HourlyWage { get; set; }

        [Required]
        public bool OverTime { get; set; }


    }
}
