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
            base.height = 3.11;
            base.wirght = 34.8;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources.Bayleef;
        }
    }
}
