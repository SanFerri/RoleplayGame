using System.Collections;

namespace Library
{
    public class Skill
    {
        public int damage {get; set;}
        public string type {get; set;}
        public ArrayList skills;
        public Skill()
        {
            this.skills.Add((this.damage,this.type));
        }
        
        public ArrayList Skills
        {
            get {return skills;}
            set {skills.Add(value);}
        }

        public int CastSpell(Item item)
        {
            
        }

    }
    
}