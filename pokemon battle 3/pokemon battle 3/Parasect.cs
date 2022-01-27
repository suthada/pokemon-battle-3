using pokemon_battle_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Parasect : Pokemon
    {
        public Parasect()
        {
            base.Name = "Parasect";
            base.height = 3.03;
            base.wirght = 65.0;

            base.hp = 60;
            base.atk = 95;
            base.def = 80;
            base.speed = 30;

            base.gender = Gender.male;
            base.category = Category.mushroom;
            base.abilities = new Abilities[] { Abilities.effectspore, Abilities.dryskin };
            base.type = new Type[] { Type.bug, Type.grass };
            base.weaknesses = new Type[] { Type.fire, Type.flying, Type.ice, Type.poison, Type.rock, Type.bug };

            base.image = Resources.Parasect;
        } 
    }
}
