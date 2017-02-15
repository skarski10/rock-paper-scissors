using System;
using System.Collections.Generic;

namespace RockPaperScissorsApp.Objects
{
    public class Game
    {
        private Dictionary<string, string> _winCombos = new Dictionary<string, string>{
            {"rock", "scissors"},
            {"paper", "rock"},
            {"scissors", "paper"}
        };
        private string _userMove;
        private string _computerMove;

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

        public bool CheckWinner()
        {
            if (_winCombos[_userMove] == _computerMove)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
