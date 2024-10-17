namespace Nojus_Matusevicius_SOA_CA1.GameInformation
{
    // NBA game class inheriting from INbaGame interface
    public class NbaGame : INbaGame
    {
        public string id { get; set; }
        public string sport_key { get; set; }
        public string sport_title { get; set; }
        public DateTime commence_time { get; set; }
        public bool completed { get; set; }
        public string home_team { get; set; }
        public string away_team { get; set; }
        public object scores { get; set; }
        public object last_update { get; set; }

        // converts scores to string
        public string convertScore()
        { 
            return scores == null ? "0 : 0" : scores.ToString();
        }

        // converts last update to string
        public string convertLastUpdate()
        {
            return last_update == null ? "no update" : last_update.ToString();
        }
    }
}
