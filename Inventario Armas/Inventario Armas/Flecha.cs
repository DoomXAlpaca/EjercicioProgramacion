using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Flecha : Proyectil
    { 
        private float dmg;
        private float precio;

        public Flecha(float dmg, float precio)
        {
            this.dmg = dmg;
            this.precio = precio;
        }
    }
}
