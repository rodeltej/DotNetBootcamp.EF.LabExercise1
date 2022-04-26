using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Shift
    {
        [Key]
        public int ShiftID { get; set; }

        public int PlacementContractID { get; set; }

        [Required]
        public int DayOfWeek { get; set; }

        [Required]
        public DateTime StartTime { get; set; }

        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public Byte NumberOfEmployees { get; set; }

        [Required]
        public bool Active { get; set; }

        public string? Notes { get; set; }

        public PlacementContract PlacementContract { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
    }
}
