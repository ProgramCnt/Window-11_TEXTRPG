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
