using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class Player
    {
        private string playerName;
        private int Score;
        private int move;
        public Player(string name)
        {
            this.playerName = name;
            Score = 0;
        }
        public string getName
        {
            get { return playerName; }
            set { playerName = value; }
        }
        public int getScore
        {
            get { return Score; }
            set { Score = value; }
        }
        public int getMove
        {
            get { return move; }
        }
        public int numMove(int numPlayers)
        {
            if (numPlayers == 1)
            {
                move = 6;
                return move;
            }
            else if (numPlayers == 2)
            {
                move = 3;
                return move;
            }
            else if (numPlayers == 3)
            {
                move = 2;
                return move;
            }
            return move;
        }
        public string PlayerWin()
        {
            Score++;
            move--;
            return "You won this game.";
        }
        public string PlayerLose()
        {
            move--;
            return "You lose this game.";
        }
        public string MoveToFinal() //1 player
        {
            return "You now moving to the final showdown";
        }
        public int MoveToFinal(int Player1Score, int Player2Score)           //2 Players
        {
            if (Player1Score > Player2Score)
                return 1;       //Player 1 Advance
            else if (Player2Score > Player1Score)
                return 2;       //Player 2 Advance
            else if (Player1Score == Player2Score)
                return 3;       //All 2 player Advance
            return 0;
        }

        public int MoveToFinal(int Player1Score, int Player2Score, int Player3Score) //3 players
        {
            if (Player1Score > Player2Score && Player1Score > Player3Score)
                return 1;           //Player 1 Advance
            else if (Player2Score > Player1Score && Player2Score > Player3Score)
                return 2;           //Player 2 Advance
            else if (Player3Score > Player1Score && Player3Score > Player1Score)
                return 3;           //Player 3 Advance
            else if (Player1Score == Player2Score && Player1Score > Player3Score)
                return 4;           //Player 1 and 2 Advance
            else if (Player1Score == Player3Score && Player1Score > Player2Score)
                return 5;           //Player 1 and 3 Advance
            else if (Player2Score == Player3Score && Player2Score > Player1Score)
                return 6;           //Player 2 and 3 Advance
            else if (Player1Score == Player3Score && Player1Score == Player2Score)
                return 7;           //All players Advance

            return 0;
        }
    }
}

