using System;
using System.ComponentModel.DataAnnotations;

namespace ICRC.Domain.Entities
{
    public class Request 
    {
        public int RequestId { get; set; }
        public String From { get; set; }
        public String To { get; set; }
        public String ProductType { get; set; }

        [Range(0, int.MaxValue)]
        public float Quantity { get; set; }
        public int Priority { get; set; }
        public String Notes { get; set; }
  
        public bool Treated { get; set; }

        // Add CELL MANAGER ATTRIBUTE OF TYPE USER


    }
}
