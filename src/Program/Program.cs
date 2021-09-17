
﻿using System;
using Library;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Skill FireArrow = new Skill("Fire Arrow", 60);
            Item DeathBringer = new Item("DeathBringer", 210, 15, FireArrow);
            Item Asi = new Item("Asi", 300, 5, FireArrow);
            Item Executioner = new Item("Executioner", 100, 25, FireArrow);
            Elf Neith = new Elf("Neith", 10, 6000);
            Elf.AddItem(DeathBringer);
            Elf.AddItem(Asi);
            Elf.AddItem(Executioner);
            Neith.Equip();
            Neith.PrettyPrint();

            SpellBook BookOfThoth = new SpellBook("Book Of Thoth");
            Spell FireBall = new Spell("Fireball", 70);
            BookOfThoth.AddSpell(FireBall);
            Skill ArcaneMissiles = new Skill("Arcane Missiles", 80);
            Item Polinomicon = new Item("Polinomicon", 210, 15, ArcaneMissiles);
            Item ChronosPendant = new Item("Chronos Pendant", 300, 5, ArcaneMissiles);
            Item DoomOrb = new Item("Doom Orb", 100, 25, ArcaneMissiles);
            Wizard Thoth = new Wizard("Thoth", 10, 5000, BookOfThoth);
            Wizard.AddItem(DoomOrb);
            Wizard.AddItem(ChronosPendant);
            Wizard.AddItem(Polinomicon);
            Thoth.Equip();
            Thoth.PrettyPrint();
            BookOfThoth.PrettyPrint();

            Skill HammersAnger = new Skill("Hammer´s Anger", 40);
            Item VoidStone = new Item("Void Stone", 210, 15, HammersAnger);
            Item TitansBane = new Item("TitansBane", 300, 5, HammersAnger);
            Item JottuunsWrath = new Item("Jottuns Wrath", 100, 25, HammersAnger);
            Dwarf Fafnir = new Dwarf("Fafnir", 10, 8000);
            Dwarf.AddItem(VoidStone);
            Dwarf.AddItem(TitansBane);
            Dwarf.AddItem(JottuunsWrath);
            Fafnir.Equip();
            Fafnir.PrettyPrint();

            Spell BloodySpear = new Spell("Bloody Spear", 65);
            SpellBook DeathNote = new SpellBook("Death Note");
            DeathNote.AddSpell(BloodySpear);
            Skill DeathGaze = new Skill("Death Gaze", 80);
            Item Isolation = new Item("Isolation", 210, 15, DeathGaze);
            Item SacrificialShroud = new Item("Sacrificial Shroud", 300, 5, DeathGaze);
            Item BancroftsTalon = new Item("Bancroft's Talon", 100, 25, DeathGaze);
            UnDead Anubis = new UnDead("Anubis", 10, 10, DeathNote);
            UnDead.AddItem(SacrificialShroud);
            UnDead.AddItem(BancroftsTalon);
            UnDead.AddItem(Isolation);
            Anubis.Equip();
            Anubis.PrettyPrint();
            DeathNote.PrettyPrint();

            Anubis.spellbook.CastSpell();
        }
    }
}
