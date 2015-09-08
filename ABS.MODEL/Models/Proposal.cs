using System;
using System.ComponentModel.DataAnnotations;

namespace ABS.MODEL
{
    public class Proposal
    {
        [Key]
        public int Id { get; set; }

        public string FileNumber { get; set; }
        public string ProposalNumber { get; set; }
        public string PolicyNumber { get; set; }
        public string UnderWritingYear { get; set; }
        public string BusinessSource { get; set; }
        public DateTime ProposalDate { get; set; }
        public string ProdeuctCategory { get; set; }
        public string ProductCode { get; set; }
        public string CoverCode { get; set; }
        public string PlanCode { get; set; }
        public string BrokerCode { get; set; }
        public string MarketerCode { get; set; }
        public string AssuredCode { get; set; }
        //public string FullName { get; set; }
        



        public string ProposalFlag { get; set; }
        public DateTime DateAdded { get; set; }
        public string AddedBy { get; set; }
        public DateTime LastModified { get; set; }

    }
}