using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace TP2
{
    class Agencia
    {
        protected List<Alojamiento> misAlojamientos;
        protected int cantAlojamientos;
        protected List<Usuario> misUsuarios;

        public Agencia()
        {

        }

        public Agencia(int CantidadAlojamientos)
        {
            this.misAlojamientos = new List<Alojamiento>();
            this.cantAlojamientos = CantidadAlojamientos;
        }

        //reviso que no haya otro con el mismo código, si ya hay devuelvo false
        public bool insertarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.Codigo == aloj.Codigo)
                    return false;
            //si llegó hasta acá es porque no está ese código
            misAlojamientos.Add(aloj);
            return true;
        }

        public bool eliminarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.Codigo == aloj.Codigo)
                    return false;
            //si llegó hasta acá es porque no está ese código
            misAlojamientos.Remove(aloj);
            return true;
        }

        public bool modificarAlojamiento(Alojamiento aloj)
        {
            foreach (Alojamiento a in misAlojamientos)
                if (a.Codigo == aloj.Codigo)
                {
                    misAlojamientos.Remove(a);
                    misAlojamientos.Add(aloj);
                    return true;
                }
            return false;

        }

        public Alojamiento[] alojamientosEntrePrecios(float d, float h)
        {
            var arr = new List<Alojamiento>();

            foreach (Alojamiento a in misAlojamientos)
            {
                if (a is Cabaña c)
                {
                    if (c.getPrecioPorPersona() <= h && c.getPrecioPorPersona() >= d)
                        arr.Add(c);
                }

                if (a is Hotel ho)
                {
                    if (ho.getPrecioPorPersona() <= h && ho.getPrecioPorPersona() >= d)
                        arr.Add(ho);
                }
            }

            return arr.ToArray();
        }

        //public bool estaAlojamiento(Alojamiento aloj)
        //{
        //    foreach (Alojamiento a in misAlojamientos)
        //        if (a.igualCodigo(aloj))
        //            return true;
        //    //si llegó hasta acá es porque no está ese código
        //    return false;
        //}

        //public bool estaLlena() { return cantAlojamientos == misAlojamientos.Count; }
        //public bool hayAlojamientos() { return misAlojamientos.Count > 0; }

        //public Agencia soloHoteles()
        //{
        //    Agencia Salida = new Agencia(this.cantAlojamientos);
        //    foreach (Alojamiento a in misAlojamientos)
        //        if (a is Hotel)
        //            Salida.insertarAlojamiento(a);
        //    return Salida;
        //}

        //public Agencia masEstrellas(int cant)
        //{
        //    Agencia Salida = new Agencia(this.cantAlojamientos);
        //    foreach (Alojamiento a in misAlojamientos)
        //        if (a.getEstrellas() >= cant)
        //            Salida.insertarAlojamiento(a);
        //    return Salida;
        //}

        //public bool AñadirAlojamiento(Alojamiento aloj)
        //{
        //    foreach (Alojamiento a in misAlojamientos)
        //        if (a.igualCodigo(aloj))
        //            return false;
        //    //si llegó hasta acá es porque no está ese código
        //    misAlojamientos.Add(aloj);
        //    return true;
        //}

        //public bool alojamientosEntrePrecios(Alojamiento aloj)
        //{
        //    return true;
        //}



        //public int getCantidad() { return cantAlojamientos; }
        //public void setCantidad(int CantAlojamientos) { cantAlojamientos = CantAlojamientos; }

        //public List<Alojamiento> getAlojamientos()
        //{
        //    return misAlojamientos.OrderBy(a => a.getEstrellas()).ThenBy(a => a.getCantPersonas()).ThenBy(a => a.getCodigo()).ToList();
        //}
    }
}
