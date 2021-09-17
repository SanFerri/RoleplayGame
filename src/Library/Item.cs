using System;
namespace Library
{
    public class Item
    {
        public string name { get; set; }
        public int damage {get; set;}
        public int endurance {get; set;}
        public Skill skill {get; set;}

        public Item(string name, int damage, int endurance, Skill skill)
        {
            this.name = name;
            this.damage = damage;
            this.endurance = endurance;
            this.skill = skill;
        }

        public int UseItem()
        {
            return this.skill.CastSpell(this) * this.damage;
        }
        public void PrettyPrint()
        {
            Console.WriteLine($"This is {this.name}, its damage is {this.damage}, it has an endurance of {this.endurance}, and its skill is {this.skill}");
        }

    }
}