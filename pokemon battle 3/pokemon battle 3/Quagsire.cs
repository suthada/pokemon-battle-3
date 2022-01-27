using pokemon_battle_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Quagsire : Pokemon
    {
        public Quagsire()
        {
            base.Name = "Quagsire";
            base.height = 4.07;
            base.wirght = 165.3;

            base.hp = 95;
            base.atk = 85;
            base.def = 85;
            base.speed = 35;

            base.gender = Gender.male;
            base.category = Category.waterfish;
            base.abilities = new Abilities[] { Abilities.damp, Abilities.waterabsorb };
            base.type = new Type[] { Type.water, Type.ground };
            base.weaknesses = new Type[] { Type.grass };

            base.image = Resources.Quagsire;
        }
    }
}
