using pokemon_battle_3.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Pikachu : Pokemon
    {
       public Pikachu()
        {
            base.Name = "Pikachu";
            base.height = 1.04;
            base.wirght = 13.2;

            base.gender = Gender.male;
            base.category = Category.mouse;
            base.abilities = Abilities.static_;
            base.type = Type.electric;
            base.weaknesses = Type.ground;

            base.image = Resources.pkc;
        } 
    }
}
