using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tetris_Proyecto_Final
{
    class Puntuacion : IComparable<Puntuacion>
    {
        string nombre;
        int puntuacion;
        DateTime fecha;

        public Puntuacion(string nombre, int puntuacion, DateTime fecha)
        {
            this.nombre = nombre;
            this.puntuacion = puntuacion;
            this.fecha = fecha;
        }

        public int CompareTo(Puntuacion p)
        {
            if (p.puntuacion > puntuacion)
                return 1;
            else if (p.puntuacion < puntuacion)
                return -1;

            return 0;
        }

        public override string ToString()
        {
            return nombre + ";" + puntuacion + ";" + fecha.ToString("dd-MM-yyyy");
        }

        public string GetNombre()
        {
            return nombre;
        }

        public int GetPuntuacion()
        {
            return puntuacion;
        }

        public DateTime GetFecha()
        {
            return fecha;
        }
    }
}
