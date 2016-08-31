using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3309_Group_Project
{
    public class PlayerList
    {
        private List<Player> player = new List<Player>();
        public PlayerList()
        {
            player = new List<Player>(); 
        }
        public int Count
        {
            get { return player.Count; }
        }
        public void Addplayer(Player e)
        {
            player.Add(e);
        }
        public void Remove(Player e)
        {
            player.Remove(e);
        }
    }
}
