using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Item SpellBook = new Item("SpellBook", 210, 15);
            Item ChronosPendant = new Item("Chronos Pendant", 300, 5);
            Item DoomOrb = new Item("Doom Orb", 100, 25);
            Wizard Thoth = new Wizard("Thoth", 10, 10);
            Wizard.AddItem(DoomOrb);
            Wizard.AddItem(ChronosPendant);
            Wizard.AddItem(SpellBook);
            Thoth.Equip();
            Thoth.PrettyPrint();

            Item DeathBringer = new Item("DeathBringer", 210, 15);
            Item Asi = new Item("Asi", 300, 5);
            Item Executioner = new Item("Executioner", 100, 25);
            Elf Neith = new Elf("Neith", 10, 10);
            Elf.AddItem(DeathBringer);
            Elf.AddItem(Asi);
            Elf.AddItem(Executioner);
            Neith.Equip();
            Neith.PrettyPrint();
   
        }
    }
}
