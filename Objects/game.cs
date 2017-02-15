using System;
using System.Collections.Generic;
using System.IO;

namespace RockPaperScissorsApp.Objects
{
    public class Game
    {
        private Dictionary<string, string> _winCombos = new Dictionary<string, string>{
            {"rock", "scissors"},
            {"paper", "rock"},
            {"scissors", "paper"}
        };

        private string[] computerMoveOptions = new string[] {"rock", "scissors", "paper"};

        private Random _computerThinker;

        private string _userMove;
        private string _computerMove;

        public Game(string newUserMove)
        {
            _computerThinker = new Random();
            _userMove = newUserMove;
            SetRandomComputerMove();
        }

        public void SetUserMove(string newUserMove)
        {
            _userMove = newUserMove;
        }
        public string GetUserMove()
        {
            return _userMove;
        }

        public void SetComputerMove(string newComputerMove)
        {
            _computerMove = newComputerMove;
        }
        public string GetComputerMove()
        {
            return _computerMove;
        }

        public string CompareMoves()
        {
            if (_winCombos[_userMove] == _computerMove)
            {
                return "You Win!";
            }
            else if (_userMove == _computerMove)
            {
                return "Tie";
            }
            else
            {
                return "Computer Wins!";
            }
        }

        public void SetRandomComputerMove()
        {
            int j = _computerThinker.Next(0, 3);
            _computerMove = computerMoveOptions[j];
        }
    }
}
