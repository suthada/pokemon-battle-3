using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Pokemon
    {
        protected string Name;
        protected double height;
        protected double wirght;

        protected Gender gender;
        protected Category category;
        protected Abilities abilities;
        protected Bitmap image;
        protected Type type;
        protected Type weaknesses;

        public string getName()
        {
            return this.Name;

        }
        public Image getImage()
        {
            return this.image;
        }

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

    public enum Abilities
        {
            static_
        }

    public enum Type
        {
            electric, ground
        }
    
}
