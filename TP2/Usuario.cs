using System;

namespace TP2
{
    class Usuario
    {
        public int DNI { get; set; }

        public string Nombre { get; set; }

        public string Mail { get; set; }

        public string Password { get; set; }

        public bool EsAdmin { get; set; }

        public bool Bloqueado { get; set; }
    }
}