using System;

namespace TP2
{
    class Reserva
    {
        public int Id { get; set; }

        public DateTime fDesde { get; set; }

        public DateTime fHasta { get; set; }

        public Alojamiento Propiedad { get; set; }

        public Usuario Persona { get; set; }

        public float Precio { get; set; }
    }
}