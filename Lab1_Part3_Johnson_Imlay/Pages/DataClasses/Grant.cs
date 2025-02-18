namespace Lab1_Part3_Johnson_Imlay.Pages.DataClasses
{
    public class Grant
    {
        public int GrantID { get; set; }
        public string Category { get; set; }
        public string FundingSource { get; set; }
        public DateTime SubmissionDate { get; set; }
        public DateTime? AwardDate { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public int LeadFacultyID { get; set; }
        public int? BusinessPartnerID { get; set; }
    }
}
