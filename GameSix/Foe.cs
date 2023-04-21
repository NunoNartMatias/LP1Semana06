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
        this.name = name;
        health = 100;
        shield = 0;
       }
    }
}