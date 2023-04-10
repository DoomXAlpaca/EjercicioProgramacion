using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Flecha : Proyectil
    { 
        public float dmg;
        public float precio;
        private string nombre;
        public Flecha(float dmg, float precio, string nombre)
        {
            this.dmg = dmg;
            this.precio = precio;
            this.nombre = nombre;
        }
    }
}
