using System;
using System.Collections.Generic;
using System.Text;

namespace TP2
{
    class Cabaña : Alojamiento
    {
        protected float precioDia;
        protected int habitaciones;
        protected int baños;

        public Cabaña()
        {

        }
        public Cabaña(float precioDia, int habitaciones, int baños)
        {
            this.precioDia = precioDia;
            this.habitaciones = habitaciones;
            this.baños = baños;

        }

        public void setPrecioPorPersona(float nuevoPrecioPP) { precioDia = nuevoPrecioPP; }

        public float getPrecioPorPersona() { return precioDia; }

        public void setHabitaciones(int Habitaciones) { habitaciones = Habitaciones; }

        public int getHabitaciones() { return habitaciones; }

        public void setBaños(int Baños) { baños = Baños; }

        public int getBaños() { return baños; }

        public override string ToString()
        {
            return base.ToString() + " Precio: " + precioDia;
        }

    }
}
