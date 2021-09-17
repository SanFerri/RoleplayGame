using System.Collections;
using System.Collections.Generic;
using System;

namespace Library
{
    public class Skill //Esta clase se encarga de crear habilidades para los diferentes items
    {
        public int damage {get; set;}
        public string name {get; set;}

        public Skill(string name, int damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }   
}