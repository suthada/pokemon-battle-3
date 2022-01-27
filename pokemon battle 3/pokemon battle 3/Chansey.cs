using pokemon_battle_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Chansey : Pokemon
    {
        public Chansey()
        {
            base.Name = "Chansey";
            base.height = 3.07;
            base.wirght = 66.3;

            base.hp = 250;
            base.atk = 5;
            base.def = 5;
            base.speed = 50;

            base.gender = Gender.male;
            base.category = Category.egg;
            base.abilities = new Abilities[] { Abilities.natuialcure, Abilities.serenegrace };
            base.type = new Type[] { Type.normal };
            base.weaknesses = new Type[] { Type.fighting };

            base.image = Resources.Chansey;
        }
    }
}
