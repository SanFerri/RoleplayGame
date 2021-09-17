using System.Collections;
using System.Collections.Generic;
using System;

namespace Library
{
    public class Spell //Esta clase se encarga de crear los hechizos para los magos
    {
        public int damage {get; set;}
        public string name {get; set;}

        public Spell(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }

        public int CastSpell()
        {
            return this.damage;
        }
    }   
}