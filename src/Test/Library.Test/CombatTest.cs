using NUnit.Framework;
using Library;

namespace Test.Library
{


    public class ExampleTest
    {
        [Test]
        public void TestingAttack() //Este test se encarga de comprobar que el metodo de ataque hace el daño estimado a la vida del personaje.
        {
            Spell BloodySpear = new Spell("Bloody Spear", 65);
            SpellBook DeathNote = new SpellBook("Death Note");
            DeathNote.AddSpell(BloodySpear);
            Skill DeathGaze = new Skill("Death Gaze", 80);
            Item Isolation = new Item("Isolation", 210, 15, DeathGaze);
            Item SacrificialShroud = new Item("Sacrificial Shroud", 300, 5, DeathGaze);
            Item BancroftsTalon = new Item("Bancroft's Talon", 100, 25, DeathGaze);
            UnDead Anubis = new UnDead("Anubis", 10, 5500, DeathNote);
            UnDead.AddItem(SacrificialShroud);
            UnDead.AddItem(BancroftsTalon);
            UnDead.AddItem(Isolation);
            Anubis.item = Isolation;

            Skill HammersAnger = new Skill("Hammer´s Anger", 40);
            Item VoidStone = new Item("Void Stone", 210, 15, HammersAnger);
            Item TitansBane = new Item("TitansBane", 300, 5, HammersAnger);
            Item JottuunsWrath = new Item("Jottuns Wrath", 100, 25, HammersAnger);
            Dwarf Fafnir = new Dwarf("Fafnir", 10, 168001);
            Dwarf.AddItem(VoidStone);
            Dwarf.AddItem(TitansBane);
            Dwarf.AddItem(JottuunsWrath);

            int expected = 1;
            Anubis.Attack(Fafnir);
            Assert.AreEqual(expected, Fafnir.health);
        }

        [Test]
        public void TestingSpell() // Este test se encarga de comprobar que se añaden correctamente los spells, así como su funcionamiento a la hora de ser usados para atacar a otro personaje
        {
            Spell BloodySpear = new Spell("Bloody Spear", 65);
            SpellBook DeathNote = new SpellBook("Death Note");
            DeathNote.AddSpell(BloodySpear);
            Skill DeathGaze = new Skill("Death Gaze", 80);
            Item Isolation = new Item("Isolation", 210, 15, DeathGaze);
            Item SacrificialShroud = new Item("Sacrificial Shroud", 300, 5, DeathGaze);
            Item BancroftsTalon = new Item("Bancroft's Talon", 100, 25, DeathGaze);
            UnDead Anubis = new UnDead("Anubis", 10, 5500, DeathNote);
            UnDead.AddItem(SacrificialShroud);
            UnDead.AddItem(BancroftsTalon);
            UnDead.AddItem(Isolation);

            Skill HammersAnger = new Skill("Hammer´s Anger", 40);
            Item VoidStone = new Item("Void Stone", 210, 15, HammersAnger);
            Item TitansBane = new Item("TitansBane", 300, 5, HammersAnger);
            Item JottuunsWrath = new Item("Jottuns Wrath", 100, 25, HammersAnger);
            Dwarf Fafnir = new Dwarf("Fafnir", 10, 8000);
            Dwarf.AddItem(VoidStone);
            Dwarf.AddItem(TitansBane);
            Dwarf.AddItem(JottuunsWrath);

            Fafnir.Damaged(BloodySpear.damage);
            int expected = 7935;
            Assert.AreEqual(expected, Fafnir.health);
        }
        [Test]
        public void healtest()  //Este test se encarga de comprobar que el metodo de curar restaure adecuadamente la salud del personaje a su valor inicial
        {
            Spell BloodySpear = new Spell("Bloody Spear", 65);
            SpellBook DeathNote = new SpellBook("Death Note");
            DeathNote.AddSpell(BloodySpear);
            UnDead Anubis = new UnDead("Anubis", 10, 5500, DeathNote);

            int expected = 5500;
            Anubis.Damaged(5);
            Anubis.Heal();
            Assert.AreEqual(expected, Anubis.health);
        }
    
    }


}