
using Kata.StonePaperScissor.Core.Enums;
namespace Kata.StonePaperScissor.Core.PlayerTypes
{
    public class Stone : Player
    {
        public Stone()
        {
            PlayerType = ePlayerType.Stone;
            Enemies = new System.Collections.Generic.List<ePlayerType>() { ePlayerType.Spock, ePlayerType.Paper };
        }
       
       
    }
}
