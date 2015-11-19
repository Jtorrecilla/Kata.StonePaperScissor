using Kata.StonePaperScissor.Enums.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace Kata.StonePaperScissor.Core
{
    public class Game
    {
        public static eResult Play(Player player1, Player player2)
        {
            if (player1 == null || player2 == null)
                throw new ArgumentNullException("Both Players are required.");
            return player1.Equals(player2) ? eResult.Draw : EvaluatePlayers(player1,player2);
        }

        private static eResult EvaluatePlayers(Player player1, Player player2)
        {
            return player1.WinVersus(player2) ? eResult.Player1 : eResult.Player2;
          
        }
    }
}
