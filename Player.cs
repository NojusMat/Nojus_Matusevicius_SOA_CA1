namespace Nojus_Matusevicius_SOA_CA1
{
    public class Player
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public Team team { get; set; }

    }

    public class Team
    {
        public string full_name { get; set; }
        public string city { get; set; }
        public string abbreviation { get; set; }
    }
}

