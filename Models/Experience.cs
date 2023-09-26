namespace Task.Models
{
    public class Experience
    {
        public string CompanyName { get; set; } = "";
        public string JobTitle { get; set; } = "";
        public string Location { get; set; } = "";
        public DateOnly StartDate { get; set; }
        public DateOnly EndDate { get; set; }
        public bool IsCurrent { get; set; }
    }
}