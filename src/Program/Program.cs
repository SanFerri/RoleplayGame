using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
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
