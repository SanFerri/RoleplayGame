using System;
namespace Library
{
    public class SpellBook
    {
        public string name { get; set; }
        private static Dictionary<int,Spell> spells = new Dictionary<int, Spell>();
        
        public SpellBook(string name)
        {
            this.name = name;
        }
        
        public void PrettyPrint()
        {
            Console.WriteLine($"This is {this.name}, and it contains {this.spells.Count} spells");
        }
        
        public static void AddSpell(Spell Spell)
        {
            int number;
            if(spells.Count > 0)
            {
                number = spells.Count + 1;
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
            return spells[index-1].damage;
        }

    }
}