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
        public void CompareMoves_FindOutcome_Winner()
        {

            // Arrange
            string userInput = "scissors";
            string computerMove = "paper";
            string winner = "user";
            Game newGame = new Game();

            // Act
            newGame.SetUserMove(userInput);
            newGame.SetComputerMove(computerMove);
            string gameResult = newGame.CompareMoves();

            // Assert
            Assert.Equal(winner, gameResult);
        }

        [Fact]
        public void CompareMoves_FindOutcome_Loser()
        {

            // Arrange
            string userInput = "rock";
            string computerMove = "paper";
            string winner = "computer";
            Game newGame = new Game();

            // Act
            newGame.SetUserMove(userInput);
            newGame.SetComputerMove(computerMove);
            string gameResult = newGame.CompareMoves();

            // Assert
            Assert.Equal(winner, gameResult);
        }

        // [Fact]
        // public void CompareMoves_FindOutcome_Tie()
        // {
        //
        //     // Arrange
        //     string userInput = "scissors";
        //     string computerMove = "paper";
        //     Game newGame = new Game();
        //
        //     // Act
        //     newGame.SetUserMove(userInput);
        //     newGame.SetComputerMove(computerMove);
        //     bool winner = newGame.CheckWinner();
        //
        //     // Assert
        //     Assert.Equal(true, winner);
        // }
    }
}
