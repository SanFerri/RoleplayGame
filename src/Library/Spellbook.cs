using System;
using System.Collections.Generic;

namespace Library
{
    public class SpellBook
    {
        public string name { get; set; }
        private Dictionary<int,Spell> spells = new Dictionary<int, Spell>();
        
        public SpellBook(string name)
        {
            this.name = name;
            this.spells = spells;
        }
        
        public void PrettyPrint()
        {
            Console.WriteLine($"This is {this.name}, and it contains {this.spells.Count} spells");
        }
        
        public void AddSpell(Spell spell)
        {
            int number;
            if(this.spells.Count > 0)
            {
                number = this.spells.Count + 1;
            }
            else
            {
                number = 1;
            }
            spells.Add(number, spell);
            spells.Remove(0);
        }
        
        public int CastSpell()
        {
            foreach(KeyValuePair<int, Spell> obj in spells)
            {
                Console.WriteLine($"{obj.Key}. {obj.Value.name}- {obj.Value.damage} damage");
            }
            Console.WriteLine("Pick a skill: \n");
            int index = Convert.ToInt32(Console.ReadLine());
            return spells[index].damage;
        }

    }
}