namespace SportManagementSystem.Model
{
    public class Team
    {
        public string Name { get; set; }
        public string Captain { get; set; }
        public string Coach { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draw { get; set; }
    }
}
