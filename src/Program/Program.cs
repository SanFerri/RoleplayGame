
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

            Skill.AddSkill(ArcaneMisseles);
            Skill ArcaneMissiles = new Skill("Arcane Missiles", 80);

            Item SpellBook = new Item("SpellBook", 210, 15, ArcaneMissiles);
            Item ChronosPendant = new Item("Chronos Pendant", 300, 5);
            Item DoomOrb = new Item("Doom Orb", 100, 25);
            Wizard Thoth = new Wizard("Thoth", 10, 5000);
            Wizard.AddItem(DoomOrb);
            Wizard.AddItem(ChronosPendant);
            Wizard.AddItem(SpellBook);
            Thoth.Equip();
            Thoth.PrettyPrint();

            Item VoidStone = new Item("Void Stone", 210, 15);
            Item TitansBane = new Item("TitansBane", 300, 5);
            Item JottuunsWrath = new Item("Jottuns Wrath", 100, 25);
            Dwarf Fafnir = new Dwarf("Fafnir", 10, 5000);
            Dwarf.AddItem(VoidStone);
            Dwarf.AddItem(TitansBane);
            Dwarf.AddItem(JottuunsWrath);
            Fafnir.Equip();
            Fafnir.PrettyPrint();

            Skill DeathGaze = new Skill("Death Gaze", 80);
            Item SpellBook = new Item("SpellBook", 210, 15, DeathGaze);
            Item SacrificialShroud = new Item("Sacrificial Shroud", 300, 5);
            Item BancroftsTalon = new Item("Bancroft's Talon", 100, 25);
            UnDead Anubis = new UnDead("Anubis", 10, 10);
            Undead.AddItem(SacrificialShroud);
            Undead.AddItem(BancroftsTalon);
            Undead.AddItem(SpellBook);
            Anubis.Equip();
            Anubis.PrettyPrint();
            Anubis.CastSkill();

        }
    }
}
