using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR.Models
{
    public class Termination
    {
        public int id { get; set; }
        public Employee Employee { get; set; }
        public Nullable<System.DateTime> TerminationDate { get; set; }
        public Nullable<System.DateTime> LastDayOfWork { get; set; }
        public Nullable<System.DateTime> BenefitsEndDate { get; set; }
        public TerminationType TerminationType { get; set; }
        public TerminationReason TerminationReason { get; set; }
        public string NewEmployer { get; set; }
        public string ReceivedSeverance { get; set; }
        public string SeveranceTotal { get; set; }
        public Nullable<System.DateTime> DateEnteredHRIS { get; set; }
        public string Comments { get; set; }

    }
}
