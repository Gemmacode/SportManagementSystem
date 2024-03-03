namespace SportManagementSystem.Model
{
    public class MatchResult
    {
        public int ID { get; set; }
        public int MatchID { get; set; }
        public int WinningTeamID { get; set; }
        public int LosingTeamID { get; set; }
        public bool Draw { get; set; }
    }
}
