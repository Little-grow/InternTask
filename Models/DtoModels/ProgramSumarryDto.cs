namespace Task.Models.DtoModels
{
    public class ProgramSummaryDto
    {
        public string ProgramTitle { get; set; } = "";
        public string ProgramSummary { get; set; } = "";
        public string ProgramDescription { get; set; } = "";
        public List<string>? ProgramSkills { get; set; }
       
        public string ProgramBenefits { get; set; } = "";
       
        public string ApplicationCriteria { get; set; } = "";
    }
}
