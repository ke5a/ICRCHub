using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICRC.Domain.Entities
{
    public class Complaint 
    {
        public int ComplaintId { get; set; }
        public String From { get; set; }
        public String To { get; set; }
        public String Subject { get; set; }
        public String Description { get; set; }
        public int Priority { get; set; }

        public bool Treated { get; set; }

        
        // ADD ADMIN 
    }
}
