using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    internal class Pokemon
    {
        double height;
        double wirght;

        Gender gender;
        Category category;
        Ability abilities;
        Image image;
        Type type;
        Type weaknesses;

        enum Gender
        {
            male,
            female
        }

        enum Category
        {
            mouse
        }

        enum Ability
        {
            static_
        }

        enum Type
        {
            electric, ground
        }
    }
}
