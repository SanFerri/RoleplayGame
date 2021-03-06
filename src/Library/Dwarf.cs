using System;
using System.Collections.Generic;

namespace Library
{
    public class Dwarf  //Esta clase se encarga de crear obetos tipo dwarf
    {
        private string name { get; set; }
        private int attack { get; set; }
        public int health { get; set; }
        private Item item { get; set; }
        private int inicialhealth;
        private static Dictionary<int,Item> items = new Dictionary<int, Item>();

        public Dwarf(string name, int attack, int health)
        {
            this.name = name;
            this.attack = attack;
            this.health = health;
            this.inicialhealth = health;
        }

        public void Equip()
        {
            Console.WriteLine("The items available are the following ones: \n");
            foreach(KeyValuePair<int, Item> obj in items)
            {
                Console.WriteLine($"{obj.Key}. {obj.Value.name}");
            }
            Console.WriteLine("Pick a number to equip the item: \n");
            int index = Convert.ToInt32(Console.ReadLine());
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

        public void Attack(Elf elf)
        {
            elf.Damaged(this.item.UseItem());
        }
        
        
        public void Attack(Wizard wizard)
        {
            wizard.Damaged(this.item.UseItem());
        }

        
        public void Attack(UnDead unDead)
        {
            unDead.Damaged(this.item.UseItem());
        }
        
        public void Damaged(int damage)
        {
            this.health = this.health - damage;
        }

        public void Heal()
        {
            this.health = inicialhealth;
        }

        public void PrettyPrint()
        {
            Console.WriteLine($"This is the dwarf {this.name}, his hp is {this.health} and he his attack damage is {this.attack}, rightnow he is equipped with {this.item.name}");
        }
    }
}