using System;
using System.Linq;
using linq.Torneo;

namespace linq.Observer
{
    public class Resultado : observerPartidos
    {
       public void update( Partido partido )
       {
           Console.WriteLine( "Los puntos del equipo local son: " + partido.EquipoLocal.Goles);
           Console.WriteLine( "Los puntos del equipo visitante son: " + partido.EquipoVisitante.Goles);

       }
    }
}