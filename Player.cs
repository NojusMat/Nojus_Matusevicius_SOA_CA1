namespace Nojus_Matusevicius_SOA_CA1
{
    public enum Position
    {
        PointGuard,
        ShotGuard,
        SmallForward,
        PowerForward,
        Center

    }

    public class Player
    {
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string position { get; set; }
        public string height { get; set; }

        public int? draft_year { get; set; }

        public int? draft_round { get; set; }

        public int? draft_number { get; set; }

        public Position PlayerPosition { get; set; }
        public Team team { get; set; }

        public bool wasATop10Draft()
        {
                return draft_round == 1 && draft_number <= 10;
        }
        public void ConvertPosition()
        {
           if (Enum.TryParse(position,true,out Position enumPosition))
            {
                PlayerPosition = enumPosition;
            }
        }
    }
}

