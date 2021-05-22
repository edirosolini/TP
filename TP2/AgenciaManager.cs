using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using Newtonsoft.Json;
using System.IO;

namespace TP2
{
    class AgenciaManager
    {

        protected Agencia miAgencia;
        protected List<Usuario> misUsuarios;
        protected List<Reserva> misReservas;

        protected List<Alojamiento> misAlojamientos;

        protected int dniConAuticacionFalsa;
        protected int cantidadDeIntentosDeInicio = 0;

        public AgenciaManager()
        {
            using StreamReader r = new StreamReader("./datos/usuarios.json");
            string json = r.ReadToEnd();
            misUsuarios = JsonConvert.DeserializeObject<List<Usuario>>(json);
        }

        public List<string> buscarAlojamiento(string ciudad, DateTime pDesde, DateTime pHasta, int cantPersonas, string tipo)
        {
            var lst = new List<string>();

            foreach (var item in misReservas)
            {
                if (tipo == "Hotel")
                {
                    if (item is Hotel)
                    {
                        if (item.Propiedad.Ciudad == ciudad
                            && item.fDesde == pDesde
                            && item.fHasta == pHasta
                            && item.Propiedad.CantidadDePersonas == cantPersonas)
                        {
                            lst.Add(item.Propiedad.Nombre);
                        }
                    }
                }

                if (tipo == "Cabaña")
                {
                    if (item is Cabaña)
                    {
                        if (item.Propiedad.Ciudad == ciudad
                            && item.fDesde == pDesde
                            && item.fHasta == pHasta
                            && item.Propiedad.CantidadDePersonas == cantPersonas)
                        {
                            lst.Add(item.Propiedad.Nombre);
                        }
                    }
                }
            }

            return lst;
        }

        public bool agregarAlojamientos(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.Codigo == aloj.Codigo)
                {
                    return false;
                }

            //si llegó hasta acá es porque no está ese código
            misAlojamientos.Add(aloj);

            return true;
        }
        public bool modificarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.Codigo == aloj.Codigo)
                {
                    misAlojamientos.Remove(aloj);
                    misAlojamientos.Add(aloj);
                    return true;
                }

            //si llegó hasta acá es porque no está ese código
            return false;
        }

        public bool quitarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.Codigo == aloj.Codigo)
                {
                    misAlojamientos.Remove(aloj);
                    return true;
                }
            //si llegó hasta acá es porque no está ese código
            return false;
        }

        public List<string> buscarReservas(int DNI)
        {
            var lst = new List<string>();

            foreach (var item in misReservas)
            {
                if (item.Persona.DNI == DNI)
                {
                    lst.Add(item.Propiedad.Nombre);
                }
            }

            return lst;
        }

        public bool reservar(int codAloj, int dniUsuario, DateTime FDesde, DateTime FHasta)
        {
            Alojamiento alo = null;
            Usuario usr = null;

            foreach (var item in misAlojamientos)
            {
                if (item.Codigo == codAloj)
                {
                    alo = item;
                }
            }

            foreach (var item in misUsuarios)
            {
                if (item.DNI == dniUsuario)
                {
                    usr = item;
                }
            }

            if (alo == null && usr == null)
            {
                return false;
            }

            var reserva = new Reserva
            {
                Propiedad = alo,
                Persona = usr,
                fDesde = FDesde,
                fHasta = FHasta
            };

            return true;
        }

        public bool ModificarReserva(Reserva reserve)
        {
            foreach (Reserva r in misReservas)
                if (r.Id == reserve.Id)
                {
                    misReservas.Remove(reserve);
                    misReservas.Add(reserve);
                    return true;
                }

            return false;
        }

        public bool eliminarReserva(Reserva reserve)
        {
            foreach (Reserva r in misReservas)
                if (r.Id == reserve.Id)
                {
                    misReservas.Remove(reserve);
                    return true;
                }

            //si llegó hasta acá es porque no está ese código
            return false;
        }

        public Usuario autenticarUsuario(int DNI, string password)
        {
            foreach (var item in misUsuarios)
            {
                if (item.DNI == DNI && PasswordHash.ValidatePassword(password, item.Password))
                {
                    return item;
                }
            }

            if (dniConAuticacionFalsa == DNI)
            {
                cantidadDeIntentosDeInicio++;

                if (cantidadDeIntentosDeInicio == 3)
                {
                    foreach (var item in misUsuarios)
                    {
                        if (item.DNI == DNI)
                        {
                            item.Bloqueado = true;
                        }
                    }
                }
            }
            else
            {
                dniConAuticacionFalsa = DNI;
                cantidadDeIntentosDeInicio = 1;
            }

            return null;
        }

        public bool desbloquearUsuario(int DNI)
        {
            foreach (var item in misUsuarios)
            {
                if (item.DNI == DNI)
                {
                    item.Bloqueado = false;

                    return true;
                }
            }

            return false;
        }

        public bool AgregarUsuario(Usuario user)
        {
            foreach (Usuario u in misUsuarios)
                if (u.DNI == user.DNI)
                    return false;

            //si llegó hasta acá es porque no está ese código
            misUsuarios.Add(user);
            return true;

        }

        public bool modificarUsuario(Usuario user)
        {
            foreach (Usuario u in misUsuarios)
                if (u.DNI == user.DNI)
                {
                    misUsuarios.Remove(u);
                    misUsuarios.Add(user);
                    return true;
                }

            return false;
        }

        public bool eliminarUsuario(Usuario user)
        {
            foreach (Usuario u in misUsuarios)
                if (u.DNI == user.DNI)
                {
                    misUsuarios.Remove(u);
                    return true;
                }

            return false;
        }
    }
}
