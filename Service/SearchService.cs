using Nojus_Matusevicius_SOA_CA1.PlayerInformation;

namespace Nojus_Matusevicius_SOA_CA1.Service
{
    public class SearchService
    {
        public List<Player> SearchPlayers(List<Player> players, string searchTerm)
        {
            // if search term is empty, return all players
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return players;
            }

            var lowerCaseTerm = searchTerm.ToLower();

            // filter players by first name or last name
            return players.Where(player =>
                player.first_name.ToLower().Contains(lowerCaseTerm) ||
                player.last_name.ToLower().Contains(lowerCaseTerm))
                .ToList();
        }
    }
}
