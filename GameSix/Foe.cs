using System;

namespace GameSix
{
    public class Foe
    {
        // variables
        private string name;
        private float health;
        private float shield;

        // Foe Constructor
       public Foe(string name) 
       {
        this.name = SetName();
        health = 100;
        shield = 0;
       }
    
        // Method that get the name of the Foe and returns it
        public string GetName()
        {
            return name;
        }

        // Method that calculates damage taken by Foe
        public void TakeDamage(float damage)
        {
            
            shield -= damage;
            // damage was enough to destroy the shield aka shield is lower than 0
            if (shield < 0)
            {
                // damage that still needs to be done = - shield
                // -shield represents how much damage the shield was not able to block
                float damageStillToInflict = -shield;
                // need to ask why shield = 0 
                shield = 0;
                /* health of enemy will be reduced by the damage
                that still needs to be inflicted*/
                health -= damageStillToInflict;
                /* we don´t want negative health so we make sure to put it at 0
                in case the damage number was higher than the health one*/
                if ( health < 0) health = 0;
            }
        }

        // Method that gets health of Foe and returns it
        public void GetHealth()
        {
            return health;
        }

        // Method that gets shield value of Foe and returns it
        public void GetShield()
        {
            return shield();
        }

        // Method to Set the name of Foe
        public void SetName(string newname)
        {
            name = newname;
        }
    }
}