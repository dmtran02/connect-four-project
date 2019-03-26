/*Tommy Huynh
 * 1/29/19
 * Purpose: Holds player name*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bingo.Classes
{
    public class Player
    {
        String playerName;
        int playerID;
        string playerColor;

        //sets player name
        public Player()
        {

        }

        public Player(String name, int id, String color)
        {
            this.playerName = name;
            this.playerID = id;
            this.playerColor = color;
        }

        public void setPlayerName(string name)
        {
            this.playerName = name;
        }

        public String getPlayerName()
        {
            return this.playerName;
        }

        public void setPlayerID(int id)
        {
            this.playerID = id;
        }

        public int getPlayerID()
        {
            return this.playerID;
        }

        public void setPlayerColor(string color)
        {
            this.playerColor = color;
        }

        public String getPlayerColor()
        {
            return this.playerColor;
        }
    }
}
