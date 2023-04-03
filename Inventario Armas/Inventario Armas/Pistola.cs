using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Pistola : Arma
    {
        private float dmg, aSpeed, precio;
        private string name;

        public Pistola(float dmg, float aSpeed, float precio, string name)
        {
            this.dmg = dmg;
            this.aSpeed = aSpeed;
        }

        public override float DPS()
        {
            return dmg * aSpeed;
        }
    }
}
