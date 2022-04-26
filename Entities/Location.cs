using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WorkScheduleSolution.Entities
{
    public class Location
    {
        [Key]
        public int LocationID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Street { get; set; }

        [Required]
        public string City { get; set; }

        [Required]
        public string Province { get; set; }

        public string? Contact { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        public bool Active { get; set; }

        public ICollection<PlacementContract> PlacementContracts { get; set; }
    }
}
