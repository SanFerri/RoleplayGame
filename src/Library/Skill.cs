using System.Collections;
using System.Collections.Generic;
using System;

namespace Library
{
    public class Skill
    {
        public int damage {get; set;}
        public string name {get; set;}
        private static Dictionary<int,Skill> skills = new Dictionary<int, Skill>();
        public Skill(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
        
        public static void AddSkill(Skill skill)
        {
            int number;
            if(skills.Count > 0)
            {
                number = skills.Count + 1;
            }
            else
            {
                number = 1;
            }
            skills.Add(number, skill);
            skills.Remove(0);
        }

        public int CastSpell(Item item)
        {
            foreach(KeyValuePair<int, Skill> obj in skills)
            {
                Console.WriteLine($"{obj.Key}. {obj.Value.name}- {obj.Value.damage} damage");
            }
            Console.WriteLine("Pick a skill: \n");
            int index = Convert.ToInt32(Console.ReadLine());
            return skills[index-1].damage;
        }
    }   
}