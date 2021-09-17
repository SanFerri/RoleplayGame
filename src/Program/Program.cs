
﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Item DeathBringer = new Item("DeathBringer", 210, 15);
            Item Asi = new Item("Asi", 300, 5);
            Item Executioner = new Item("Executioner", 100, 25);
            Elf Neith = new Elf("Neith", 10, 5000);
            Elf.AddItem(DeathBringer);
            Elf.AddItem(Asi);
            Elf.AddItem(Executioner);
            Neith.Equip();
            Neith.PrettyPrint();

            Skill ArcaneMissiles = new Skill("Arcane Missiles", 80);

            Item Polynomicon = new Item("Polynomicon", 210, 0);
            Item ChronosPendant = new Item("Chronos Pendant", 300, 5);
            Item DoomOrb = new Item("Doom Orb", 100, 25);
            Wizard Thoth = new Wizard("Thoth", 10, 5000);
            Wizard.AddItem(DoomOrb);
            Wizard.AddItem(ChronosPendant);
            Wizard.AddItem(SpellBook);
            Thoth.Equip();
            Thoth.PrettyPrint();
            Thoth.CastSpell();

            Item VoidStone = new Item("Void Stone", 210, 15);
            Item TitansBane = new Item("TitansBane", 300, 5);
            Item JottuunsWrath = new Item("Jottuns Wrath", 100, 25);
            Dwarf Fafnir = new Dwarf("Fafnir", 10, 5000);
            Dwarf.AddItem(VoidStone);
            Dwarf.AddItem(TitansBane);
            Dwarf.AddItem(JottuunsWrath);
            Fafnir.Equip();
            Fafnir.PrettyPrint();

            Spell DeathGaze = new Spell("Death Gaze", 80);
            SpellBook DeathNote = new SpellBook("Death Note");
            Item SacrificialShroud = new Item("Sacrificial Shroud", 300, 5);
            Item BancroftsTalon = new Item("Bancroft's Talon", 100, 25);
            UnDead Anubis = new UnDead("Anubis", 10, 10, DeathNote);
            DeathNote.AddSpell(DeathGaze);
            Undead.AddItem(SacrificialShroud);
            Undead.AddItem(BancroftsTalon);
            Anubis.Equip();
            Anubis.PrettyPrint();
            Anubis.CastSpell();

        }
    }
}
