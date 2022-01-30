﻿using pokemon_battle_3.Properties;
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
            base.height = 1.04;
            base.wirght = 13.2;

            base.hp = 35;
            base.atk = 55;
            base.def = 40;
            base.speed = 90;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = new Abilities[] { Abilities.static_ };
            base.type = new Type[] { Type.electric };
            base.weaknesses = new Type[] { Type.ground };

            base.image = Resources.Bayleef;

        }
    }
}
