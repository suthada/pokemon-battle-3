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

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources.Parasect;
        } 
    }
}
