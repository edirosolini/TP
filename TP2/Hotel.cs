using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    class Hotel : Alojamiento
    {
        protected float precioPorPersona;

        public Hotel()
        {

        }
        public Hotel(float PrecioPP)
        {
            this.precioPorPersona = PrecioPP;
        }
        public void setPrecioPorPersona(float nuevoPrecioPP) { precioPorPersona = nuevoPrecioPP; }

        public float getPrecioPorPersona() { return precioPorPersona; }

        public override string ToString()
        {
            return base.ToString() + " Precio: " + precioPorPersona;
        }

    }
}
