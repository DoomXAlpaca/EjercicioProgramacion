using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Arco: Arma
    {
        private float dmg, aSpeed,precio;
        private string name;
        private int flechas;

        public Arco(float dmg, float aSpeed,float precio, string name, int flechas)
        {
            this.dmg = dmg;
            this.aSpeed = aSpeed;
            this.flechas = flechas;
        }

        public override float DPS()
        {
            return dmg * aSpeed;
        }
    }
}
