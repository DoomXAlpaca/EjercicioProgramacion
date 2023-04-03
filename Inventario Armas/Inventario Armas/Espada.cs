using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Espada : Arma
    {
        private float dmg, aSpeed, price;
        private string name;

        public Espada(float dmg, float aSpeed,float price, string name)
        {
            this.dmg = dmg;
            this.aSpeed = aSpeed;
            this.price = price;
            this.name = name;
        }

        public override float DPS()
        {
            return dmg * aSpeed;
        }
        public void ShowStats()
        {
            
        }
    }
}
