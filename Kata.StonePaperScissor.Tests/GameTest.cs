using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kata.StonePaperScissor.Core;
using Kata.StonePaperScissor.Enums.Model;
using Kata.StonePaperScissor.Core.Enums;

namespace Kata.StonePaperScissor.Tests
{
    [TestClass]
    public class GameTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void ThrowExceptionIfAnyPlayerIsNull()
        {
            Game.Play(null, null);
        }

        [TestMethod]
        public void ReturnDrawIfPlayersAreEqual()
        {
            Assert.AreEqual(eResult.Draw, Game.Play(PlayerFactory.Create(ePlayerType.Stone), PlayerFactory.Create(ePlayerType.Stone)));
        }
        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsStoneAndPlayer2IsScissor()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Stone), PlayerFactory.Create(ePlayerType.Scissor)));
        }
        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsStoneAndPlayer2IsLizzard()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Stone), PlayerFactory.Create(ePlayerType.Lizzard)));
        }
        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsStoneAndPlayer2IsSpock()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Stone), PlayerFactory.Create(ePlayerType.Spock)));
        }
        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsStoneAndPlayer2IsPaper()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Stone), PlayerFactory.Create(ePlayerType.Paper)));
        }

        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsPaperAndPlayer2IsStone()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Paper), PlayerFactory.Create(ePlayerType.Stone)));
        }
        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsPaperAndPlayer2IsSpock()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Paper), PlayerFactory.Create(ePlayerType.Spock)));
        }
        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsPaperAndPlayer2IsLizzard()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Paper), PlayerFactory.Create(ePlayerType.Scissor)));
        }
        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsPaperAndPlayer2IsScissor()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Paper), PlayerFactory.Create(ePlayerType.Scissor)));
        }
        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsSpockAndPlayer2IsScissor()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Spock), PlayerFactory.Create(ePlayerType.Scissor)));
        }

        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsSpockAndPlayer2IsStone()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Spock), PlayerFactory.Create(ePlayerType.Stone)));
        }


        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsSpockAndPlayer2IsLizzard()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Spock), PlayerFactory.Create(ePlayerType.Lizzard)));
        }

        [TestMethod]
        public void ReturnPlayer21IfPlayer1IsSpockAndPlayer2IsPaper()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Spock), PlayerFactory.Create(ePlayerType.Paper)));
        }

        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsScissorAndPlayer2IsPaper()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Scissor), PlayerFactory.Create(ePlayerType.Paper)));
        }

        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsScissorAndPlayer2IsLizzard()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Scissor), PlayerFactory.Create(ePlayerType.Lizzard)));
        }

        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsScissorAndPlayer2IsStone()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Scissor), PlayerFactory.Create(ePlayerType.Stone)));
        }

        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsScissorAndPlayer2IsSpock()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Scissor), PlayerFactory.Create(ePlayerType.Spock)));
        }

        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsLizzardAndPlayer2IsPaper()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Lizzard), PlayerFactory.Create(ePlayerType.Paper)));
        }

        [TestMethod]
        public void ReturnPlayer1IfPlayer1IsLizzardAndPlayer2IsSpock()
        {
            Assert.AreEqual(eResult.Player1, Game.Play(PlayerFactory.Create(ePlayerType.Lizzard), PlayerFactory.Create(ePlayerType.Spock)));
        }
        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsLizzardAndPlayer2IsStone()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Lizzard), PlayerFactory.Create(ePlayerType.Stone)));
        }

        [TestMethod]
        public void ReturnPlayer2IfPlayer1IsLizzardAndPlayer2IsScissor()
        {
            Assert.AreEqual(eResult.Player2, Game.Play(PlayerFactory.Create(ePlayerType.Lizzard), PlayerFactory.Create(ePlayerType.Scissor)));
        }
    }
}
