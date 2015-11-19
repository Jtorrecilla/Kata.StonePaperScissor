using Kata.StonePaperScissor.Core.Enums;
namespace Kata.StonePaperScissor.Core.PlayerTypes
{
    public class Scissor : Player
    {

        public Scissor()
        {
            PlayerType = ePlayerType.Scissor;
            Enemies = new System.Collections.Generic.List<ePlayerType>() { ePlayerType.Stone, ePlayerType.Spock};
        }
    }
}
