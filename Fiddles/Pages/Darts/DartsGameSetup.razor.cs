using Fiddles.Pages.Darts.Models;
using Microsoft.AspNetCore.Components;

namespace Fiddles.Pages.Darts;

public partial class DartsGameSetup
{

    [SupplyParameterFromQuery(Name = "game")] public int Game { get; set; }

    private List<Player> Players { get; set; } = [];

    private Player? _newPlayer;

    protected override void OnInitialized()
    {
        Players.Clear();
        OnAddPlayer();
    }

    private void GetGameSettings()
    {

    }

    private void OnAddPlayer()
    {
        var lastPlayer = Players.LastOrDefault();
        var newPlayerId = lastPlayer?.Id + 1 ?? 1;
       _newPlayer = new Player { Id = newPlayerId, Name = $"Player {newPlayerId}" };
        Players.Add(_newPlayer);
    }

    private void OnRemovePlayer(Player player) { 
        if (player != null)
        {
            Players.Remove(player);
        }
    }

}
