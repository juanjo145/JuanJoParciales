using System;
using linq.Torneo;

namespace linq.Observer
{
    public class Faltas : observerPartidos
    {
        public void update(Partido partido)
        {
            Console.WriteLine( "Las amarillas del equipo local son" + partido.EquipoLocal.TarjetasAmarillas);
            Console.WriteLine( "Las amarillas del equipo visitante son" + partido.EquipoVisitante.TarjetasAmarillas);

        }
    }
} 