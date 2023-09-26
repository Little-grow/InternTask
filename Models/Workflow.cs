namespace Task.Models
{
    public class Workflow
    {
        public Guid Id { get; set; }
        public List<Stage> Stages { get; set; }
    }

}
