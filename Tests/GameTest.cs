using System;
using Xunit;
using System.Collections.Generic;
using RockPaperScissorsApp.Objects;

namespace RockPaperScissorAppTest
{
    public class GameTest
    {
        [Fact]
        public void GetUserMove_AcceptAndReturn_UsersInput()
        {
            // Arrange
            string userInput = "rock";
            Game newGame = new Game();

            // Act
            newGame.SetUserMove(userInput);

            // Assert
            Assert.Equal(userInput, newGame.GetUserMove());
        }

        [Fact]
        public void CompareMoves_FindAWinner_True()
        {

            // Arrange
            string userInput = "scissors";
            string computerMove = "paper";
            Game newGame = new Game();

            // Act
            newGame.SetUserMove(userInput);
            newGame.SetComputerMove(computerMove);
            bool winner = newGame.CheckWinner();

            // Assert
            Assert.Equal(true, winner);
        }
    }
}
