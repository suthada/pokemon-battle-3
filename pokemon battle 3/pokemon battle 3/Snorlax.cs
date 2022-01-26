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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources.Snorlax;
        }
    }
}
