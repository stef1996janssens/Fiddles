using Fiddles.Pages.Darts.Models;
using Microsoft.AspNetCore.Components;
using System.Text.Json;

namespace Fiddles.Pages.Darts;

public partial class DartsGame
{
    [SupplyParameterFromQuery(Name = "gameId")] public int Game { get; set; }
    [SupplyParameterFromQuery(Name = "players")] public required string SerializedPlayers { get; set; }

    private List<Player> _players;

    protected override void OnParametersSet()
    {
        _players = JsonSerializer.Deserialize<List<Player>>(SerializedPlayers) ?? [];
    }
}
