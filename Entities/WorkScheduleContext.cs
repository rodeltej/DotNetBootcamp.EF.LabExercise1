using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkScheduleSolution.Entities
{
    public class WorkScheduleContext: DbContext
    {
        public DbSet<Location> Locations { get; set; }

        public DbSet<PlacementContract> PlacementContracts { get; set; }

        public DbSet<Shift> Shifts { get; set; }

        public DbSet<Schedule> Schedules { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<Skill> Skills { get; set; }

        public DbSet<EmployeeSkill> EmployeeSkills { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseSqlServer("Server=2LMBQG3;Database=WorkSchedule;User Id=sa;Password=P@ssw0rd");
            }
        }


    }
}
