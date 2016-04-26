using Kata.StonePaperScissor.Core.Enums;
using Kata.StonePaperScissor.Core.PlayerTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Kata.StonePaperScissor.Core
{
    public static class PlayerFactory
    {
        internal static Dictionary<ePlayerType, Func<Player>> playerTypes = new Dictionary<ePlayerType, Func<Player>>
            {
                {ePlayerType.Stone, () => new Stone()},
                {ePlayerType.Paper, () => new Paper()},
                {ePlayerType.Scissor, () => new Scissor()},
                {ePlayerType.Spock, () => new Spock()},
                {ePlayerType.Lizzard, () => new Lizzard()}
            };
        public static Player Create(ePlayerType playerType)
        {
            return playerTypes.First(p => p.Key == playerType).Value.Invoke();
        }
    }
}
