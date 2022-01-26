using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    internal class Pokemon
    {
        protected string Name;
        protected double height;
        protected double wirght;

        protected Gender gender;
        protected Category category;
        protected Ability abilities;
        protected Image image;
        protected Type type;
        protected Type weaknesses;
    }
    public enum Gender
        {
            male,
            female
        }

    public enum Category
        {
            mouse
        }

    public enum Ability
        {
            static_
        }

    public enum Type
        {
            electric, ground
        }
    
}
