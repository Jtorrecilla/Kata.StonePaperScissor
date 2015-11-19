using System;
using System.Collections.Generic;
using System.Linq;
using Kata.StonePaperScissor.Core.Enums;
namespace Kata.StonePaperScissor.Core
{
    public abstract class Player
    {
        internal ePlayerType PlayerType;
        internal List<ePlayerType> Enemies { get; set; }
        public bool WinVersus(Player player)
        {
            return !Enemies.Any(enemie => enemie.Equals(player.PlayerType));
        }
        public override bool Equals(object obj)
        {
            if (obj is Player)
            {
                return (obj as Player).PlayerType == this.PlayerType;
            }
            return base.Equals(obj);
        }
    }
}
