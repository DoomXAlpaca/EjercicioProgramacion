using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class ArmaMelee : Arma
    {
        public float dmg, aVelocidad;
        public override float DPS()
        {
            return dmg / aVelocidad;
        }
    }
}
