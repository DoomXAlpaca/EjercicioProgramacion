using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class ArmaADistancia : Arma
    {
        public float dmg, aVelocidad, dmgproyectil;
        public override float DPS()
        {
            return (dmg + dmgproyectil) * aVelocidad;
        }
    }
}
