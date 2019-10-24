using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentProjectManagement.Models
{
    public class Proposal
    {
        public int Id { get; set; }
        public string DocumentURL { get; set; }
        public DateTime SubmissionDate { get; set; }
        public bool Approved { get; set; }
        public string RejectedReason { get; set; }
        public string RejectionDate { get; set; }

        public Project Project { get; set; }
    }
}
