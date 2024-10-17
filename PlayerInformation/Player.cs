namespace Nojus_Matusevicius_SOA_CA1.PlayerInformation
{
    // Enum for player position
    public enum Position
    {
        PointGuard,
        ShotGuard,
        SmallForward,
        PowerForward,
        Center

    }

    public class Player : Athelete , IAthlete
    {
        public string position { get; set; }
        public string height { get; set; }

        public int? draft_year { get; set; }

        public int? draft_round { get; set; }

        public int? draft_number { get; set; }

        public Position PlayerPosition { get; set; }
        public Team team { get; set; }

        // Method to check if player was a top 10 draft pick
        public bool wasATop10Draft()
        {
            return draft_round == 1 && draft_number <= 10;
        }

        // Method to convert position to enum position 
        public void ConvertPosition()
        {
            if (Enum.TryParse(position, true, out Position enumPosition))
            {
                PlayerPosition = enumPosition;
            }
        }


        // Method to get full name of player
        public string GetFullName()
        {
            return $"{first_name} {last_name}";
        }

        // Method to get player position
        public Position GetPosition()
        {
            return PlayerPosition;
        }
    }
}

