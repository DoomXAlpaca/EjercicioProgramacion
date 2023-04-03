using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Pistola : Arma
    {
        private float dmg, aSpeed, precio;
        private string name;
        private int balas;

        public Pistola(float dmg, float aSpeed, float precio, string name, int balas)
        {
            this.dmg = dmg;
            this.aSpeed = aSpeed;
            this.balas = balas;
        }

        public override float DPS()
        {
            return dmg * aSpeed;
        }
    }
}
