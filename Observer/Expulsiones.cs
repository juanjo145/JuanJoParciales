using System;
using linq.Torneo;

namespace linq.Observer
{
    public class Expulsiones : observerPartidos
    {
        public void update(Partido partido)
        {
            Console.WriteLine( "Las expulsiones del equipo local son: " + partido.EquipoLocal.TarjetasRojas);
            Console.WriteLine( "Las expulsiones del equipo visitante son: " + partido.EquipoVisitante.TarjetasRojas);

        }

        
    }
} 