using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pokemon_battle_3
{
    public class Pokemon
    {
        protected int hp;
        protected int atk;
        protected int def;
        protected int speed;

        protected string Name;
        protected double height;
        protected double wirght;

        protected Gender gender;
        protected Category category;
        protected Abilities[] abilities;
        protected Bitmap image;
        protected Type[] type;
        protected Type[] weaknesses;

        public string getName()
        {
            return this.Name;

        }
        public Image getImage()
        {
            return this.image;
        }

        public int getHP() { return hp; }
        private void setHP(int newHP ) { hp = newHP; }
        public int getATK() { return this.atk; }
        public int getDEF() { return this.def; }
        public int getSPEED() { return this.speed; }
        public void attackPokemon(ref Pokemon enemy)
        {
            int damage = this.atk - enemy.getDEF();
            int newHP = enemy.getHP() - damage;
            enemy.setHP(newHP);
        }

    }
    public enum Gender
        {
            male,
            female
        }

    public enum Category
        {
            mouse, lizard, seed, superpower, mushroom, waterfish, sleeping, egg, leaf
    }

    public enum Abilities
        {
            static_, blaze, overgrow, guts, no_gurad, effectspore, dryskin, damp,
            waterabsorb, thickfat, immunity, natuialcure, serenegrace

    }

    public enum Type
        {
            electric, ground, fire, water, rock, grass, poison, phychic, 
            flying, ice, fighting, fairy, bug, normal
    }
    
}
