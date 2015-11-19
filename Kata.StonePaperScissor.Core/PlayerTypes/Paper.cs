
using Kata.StonePaperScissor.Core.Enums;
namespace Kata.StonePaperScissor.Core.PlayerTypes
{
    public class Paper : Player
    {

        public Paper()
        {
            PlayerType = ePlayerType.Paper;
            Enemies = new System.Collections.Generic.List<ePlayerType>() { ePlayerType.Lizzard, ePlayerType.Scissor };
        }
    }
}
