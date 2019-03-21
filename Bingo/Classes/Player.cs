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

        //sets player name
        public Player(String name)
        {
            this.playerName = name;
        }

        public Player(String name, int id)
        {
            this.playerName = name;
            this.playerID = id;
        }
    }
}
