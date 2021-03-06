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
            Game newGame = new Game(userInput);

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
            string winner = "You Win!";
            Game newGame = new Game(userInput);

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
            string winner = "Computer Wins!";
            Game newGame = new Game(userInput);

            // Act
            newGame.SetUserMove(userInput);
            newGame.SetComputerMove(computerMove);
            string gameResult = newGame.CompareMoves();

            // Assert
            Assert.Equal(winner, gameResult);
        }

        [Fact]
        public void CompareMoves_FindOutcome_Tie()
        {

            // Arrange
            string userInput = "rock";
            string computerMove = "rock";
            string winner = "Tie";
            Game newGame = new Game(userInput);

            // Act
            newGame.SetUserMove(userInput);
            newGame.SetComputerMove(computerMove);
            string gameResult = newGame.CompareMoves();

            // Assert
            Assert.Equal(winner, gameResult);
        }

        [Fact]
        public void SetRandomComputerMove_GenerateRandomOption_NormalDistribution()
        {

            // Arrange
            string userInput = "rock";
            Game newGame = new Game(userInput);
            Dictionary<string, int> _moveCounter = new Dictionary<string, int>{
                {"rock", 0},
                {"paper", 0},
                {"scissors", 0}
            };


            // Act
            for (int i = 0; i < 1000; i++)
            {
                newGame.SetRandomComputerMove();
                _moveCounter[newGame.GetComputerMove()]++;
            }
            // Assert
            foreach(KeyValuePair<string, int> moveScore in _moveCounter)
            {
                Console.WriteLine(moveScore);
            }
        }

        [Fact]
        public void CompareMoves_FindOutcome_Final()
        {

            // Arrange
            string userInput = "rock";
            Game newGame = new Game(userInput);

            // Act
            newGame.SetUserMove(userInput);
            newGame.SetRandomComputerMove();
            string gameResult = newGame.CompareMoves();

            // Assert
            Console.WriteLine(gameResult);
        }
    }
}
