namespace SportManagementSystem.Model
{
    public class MatchResult
    {
        public string Id { get; set; }
        public int MatchId { get; set; }
        public int WinningTeamId { get; set; }
        public int LosingTeamId { get; set; }
        public bool Draw { get; set; }
    }
}
