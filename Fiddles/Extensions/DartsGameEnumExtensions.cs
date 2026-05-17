using Fiddles.Enums;

namespace Fiddles.Extensions;

public static class DartsGameEnumExtensions
{
    public static string GetName(this DartsGame dartsGame)
    {
        return dartsGame switch
        {
            DartsGame.Match => "Match",
            DartsGame.Shangai => "Shangai",
            DartsGame.AroundTheClock => "Around the clock",
            DartsGame.ScoreTraining => "Score training",
            DartsGame.SinglesTraining => "Singles training",
            DartsGame.DoublesTraining => "Doubles training",
            DartsGame.Cricket => "Cricket",
            DartsGame.Unknown => throw new NotImplementedException()
        };
    }

}
