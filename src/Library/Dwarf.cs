using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf
    {
        private string name { get; set; }
        private int attack { get; set; }
        private int health { get; set; }
        private Item item { get; set; }
        private static Dictionary<int,Item> items = new Dictionary<int, Item>();

        public Dwarf(string name, int attack, int health)
        {
            this.name = name;
            this.attack = attack;
            this.health = health;
        }

        public void Equip()
        {
            Console.WriteLine("The items available are the following ones: \n");
            foreach(KeyValuePair<int, Item> obj in items)
            {
                Console.WriteLine($"{obj.Key}. {obj.Value.name}");
            }
            Console.WriteLine("Pick a number to equip the item: \n");
            int index = Console.Read() - 48;
            this.item = items[index];
        }
        
        public static void AddItem(Item item)
        {
            int number;
            if(items.Count > 0)
            {
                number = items.Count + 1;
            }
            else
            {
                number = 1;
            }
            items.Add(number, item);
            items.Remove(0);
        }

        public void Damaged(int damage)
        {
            this.health = this.health - damage;
        }

        public void PrettyPrint()
        {
            Console.WriteLine($"This is the dwarf {this.name}, his hp is {this.health} and he his attack damage is {this.attack}, rightnow he is equipped with {this.item.name}");
        }
    }
}