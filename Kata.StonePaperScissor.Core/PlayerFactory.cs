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
        public static Player Create(ePlayerType playerType)
        {
            switch (playerType)
            {
                case ePlayerType.Stone:
                    return new Stone();
                case ePlayerType.Paper:
                    return new Paper();
                case ePlayerType.Scissor:
                    return new Scissor();
                case ePlayerType.Spock:
                    return new Spock();
                case ePlayerType.Lizzard:
                    return new Lizzard();
                default:
                    return null;
            }
        }
    }
}
