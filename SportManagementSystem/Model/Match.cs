using SportManagementSystem.Model.Enum;

namespace SportManagementSystem.Model
{
    public class Match
    {
        public int ID { get; set; }
        public int EventID { get; set; }
        public int HomeTeamID { get; set; }
        public int AwayTeamID { get; set; }
        public DateTime MatchDate { get; set; }
        public string Venue { get; set; }
        public string Referee { get; set; }
        public MatchStatus Status { get; set; }
        public int HomeTeamScore { get; set; }
        public int AwayTeamScore { get; set; }
    }
}
