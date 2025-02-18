namespace Lab1_Part3_Johnson_Imlay.Pages.DataClasses
{
    public class Project
    {
        public int ProjectID { get; set; }
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public int CreatedBy { get; set; }
        public int? BusinessPartnerID { get; set; }
        public int? GrantID { get; set; }
    }
}
