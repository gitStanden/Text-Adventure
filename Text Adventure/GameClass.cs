using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Text_Adventure
{
    abstract class GameClass : ICharacterInterface
    {
        public string Name
        { get; set; }
        
        public int Health
        { get; set; }

        public double Magic
        { get; set; }

        virtual public int MinDamage { get; set; }

        virtual public int MaxDamage { get; set; }
        //spells

        public GameClass(string name, int health, double magic)
        {
            Name = name;
            Health = health;
            Magic = magic;
        }

        public GameClass(string name, int health, double magic, int minDamage, int maxDamage)
        {
            Name = name;
            Health = health;
            Magic = magic;
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
    }
}
