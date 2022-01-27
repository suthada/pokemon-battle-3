using pokemon_battle_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Machamp : Pokemon
    {
        public Machamp()
        {
            base.Name = "Machamp";
            base.height = 5.03;
            base.wirght = 256.6;

            base.hp = 90;
            base.atk = 180;
            base.def = 30;
            base.speed = 55;

            base.gender = Gender.male;
            base.category = Category.superpower;
            base.abilities = new Abilities[] { Abilities.blaze };
            base.type = new Type[] { Type.grass };
            base.weaknesses = new Type[] { Type.fire, Type.flying, Type.ice, Type.poison, Type.bug };

            base.image = Resources.Machamp01;
        }
    }
}
