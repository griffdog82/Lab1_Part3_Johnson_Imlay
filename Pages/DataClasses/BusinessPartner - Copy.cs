namespace Lab1_Part3_Johnson_Imlay.Pages.DataClasses
{
    public class BusinessPartner
    {
        public int BusinessPartnerID { get; set; }
        public string Name { get; set; }
        public string OrgType { get; set; }
        public string? PrimaryContact { get; set; }
        public string BusinessType { get; set; }
        public string StatusFlag { get; set; }
        public bool ActiveStatus { get; set; }
    }
}
