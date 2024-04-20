namespace BugTracker.Models
{
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public IEnumerable<Ticket> ListOfTickets { get; set; }

    }
}
