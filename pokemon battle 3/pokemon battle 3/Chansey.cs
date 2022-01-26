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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources.Chansey;
        }
    }
}
