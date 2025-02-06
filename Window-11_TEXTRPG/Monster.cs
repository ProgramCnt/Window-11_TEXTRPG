using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_11_TEXTRPG
{
    public class Monster
    {
        string name { get; set; }
        int level { get; set; }
        string type { get; set; }
        int hp { get; set; }

        public Monster(string name, int level, string type, int hp)
        {
            this.name = name;
            this.level = level;
            this.type = type;
            this.hp = hp;
        }

        public bool IsDie() 
        {
            if (hp <= 0) 
            {
                return true;
            }
            return false;
        }
    }
}
