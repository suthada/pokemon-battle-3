using pokemon_battle_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Bayleef : Pokemon
    {
        public Bayleef()
        {
            base.Name = "Bayleef";
            base.height = 3.11;
            base.wirght = 34.8;

            base.hp = 60;
            base.atk = 62;
            base.def = 80;
            base.speed = 80;

            base.gender = Gender.male;
            base.category = Category.leaf;
            base.abilities = new Abilities[] { Abilities.overgrow };
            base.type = new Type[] { Type.grass };
            base.weaknesses = new Type[] { Type.fire, Type.flying, Type.ice, Type.poison, Type.bug };

            base.image = Resources.Bayleef;

        }
    }
}
