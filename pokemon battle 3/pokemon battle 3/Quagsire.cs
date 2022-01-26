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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources.Quagsire;
        }
    }
}
