namespace SportManagementSystem.Model
{
    public class Team
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Captain { get; set; }
        public string Coach { get; set; }
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draw { get; set; }
    }
}
