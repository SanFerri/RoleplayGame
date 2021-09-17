using System.Collections;
using System.Collections.Generic;
using System;

namespace Library
{
    public class Skill
    {
        public int damage {get; set;}
        public string name {get; set;}
        private static Dictionary<int,Skill> skills = new Dictionary<int, Skill>()
        public Skill(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
            this.skills.Add((this.damage,this.type));
        }
        
        public Dictionary<int,Skill> Skill()
        {
            get {return skills;}
            set {skills.Add(value);}
        }

        public int CastSpell(Item item)
        {
            foreach(KeyValuePair<int, Skill> obj in skills)
            {
                Console.WriteLine($"(obj.Key). (obj.Value.name)");
            }
            Console.WriteLine("Pick a skill: \n");
            int index = Convert.ToInt32(Console.ReadLine());
            return this.skills[index-1].damage;
        }

    }
    
}