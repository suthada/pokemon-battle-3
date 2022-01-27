using pokemon_battle_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Snorlax : Pokemon
    {
        public Snorlax()
        {
            base.Name = "Snorlax";
            base.height = 6.11;
            base.wirght = 1014.1;

            base.hp = 160;
            base.atk = 110;
            base.def = 65;
            base.speed = 30;

            base.gender = Gender.male;
            base.category = Category.sleeping;
            base.abilities = new Abilities[] { Abilities.thickfat, Abilities.immunity };
            base.type = new Type[] { Type.normal };
            base.weaknesses = new Type[] { Type.fighting };

            base.image = Resources.Snorlax;
        }
    }
}
