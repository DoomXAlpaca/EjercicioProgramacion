﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Inventario_Armas
{
    class Espada : Arma
    {
        private float dmg, aVelocidad, precio;
        private string nombre;

        public Espada(float dmg, float aVelocidad,float precio, string nombre)
        {
            this.dmg = dmg;
            this.aVelocidad = aVelocidad;
            this.precio = precio;
            this.nombre = nombre;
        }

        public override float DPS()
        {
            return dmg * aVelocidad;
        }
        public void ShowStats()
        {
            
        }
    }
}
