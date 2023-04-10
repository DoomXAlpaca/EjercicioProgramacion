using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Bala : Proyectil
    {
        public float dmg;
        public float precio;

        public Bala (float dmg, float precio)
        {
            this.dmg = dmg;
            this.precio = precio;
        }
    }
}
