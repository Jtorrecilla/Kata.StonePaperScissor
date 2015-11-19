using Kata.StonePaperScissor.Core.Enums;
namespace Kata.StonePaperScissor.Core.PlayerTypes
{
    public class Spock : Player
    {

        public Spock()
        {
            PlayerType = ePlayerType.Spock;
            Enemies = new System.Collections.Generic.List<ePlayerType>() { ePlayerType.Lizzard, ePlayerType.Paper };
        }
    }
}
