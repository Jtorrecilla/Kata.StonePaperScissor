using Kata.StonePaperScissor.Core.Enums;
namespace Kata.StonePaperScissor.Core.PlayerTypes
{
    public class Lizzard : Player
    {

        public Lizzard()
        {
            PlayerType = ePlayerType.Lizzard;
            Enemies = new System.Collections.Generic.List<ePlayerType>() { ePlayerType.Scissor, ePlayerType.Stone};
        }
    }
}
