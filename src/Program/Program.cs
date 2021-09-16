using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            // Setup for the game

            // Wizard Set-Up
            Item SpellBook = new Item("SpellBook", 210, 15);
            Item ChronosPendant = new Item("Chronos Pendant", 300, 5);
            Item DoomOrb = new Item("Doom Orb", 100, 25);
            Wizard Thoth = new Wizard("Thoth", 10, 10);
            Wizard.AddItem(DoomOrb);
            Wizard.AddItem(ChronosPendant);
            Wizard.AddItem(SpellBook);
            Thoth.Equip();
            Thoth.PrettyPrint();

            Item VoidStone = new Item("Void Stone", 210, 15);
            Item TitansBane = new Item("TitansBane", 300, 5);
            Item JottuunsWrath = new Item("Jottuns Wrath", 100, 25);
            Dwarf Fafnir = new Dwarf("Fafnir", 10, 10);
            Dwarf.AddItem(VoidStone);
            Dwarf.AddItem(TitansBane);
            Dwarf.AddItem(JottuunsWrath);
            Fafnir.Equip();
            Fafnir.PrettyPrint();

        }
    }
}
