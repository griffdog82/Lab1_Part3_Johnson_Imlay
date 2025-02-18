namespace Lab1_Part3_Johnson_Imlay.Pages.DataClasses
{
    public class Task
    {
        public int TaskID { get; set; }
        public int ProjectID { get; set; }
        public string Description { get; set; }
        public DateTime DueDate { get; set; }
        public string Status { get; set; }
    }
}
