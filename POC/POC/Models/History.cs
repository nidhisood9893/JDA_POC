using System;
using System.Collections.Generic;
using System.Text;

namespace POC
{
   public class History
    {
        public string Title { get; set; }
        public int Leaves { get; set; }
        public string FromDate { get; set; }
        public string ToDate { get; set; }
        public ApprovalStatus Status { get; set; }
    }

    public enum ApprovalStatus
    {
        Approved,
        Pending,
        Rejected
    }
}
