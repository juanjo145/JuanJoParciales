using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using linq.Torneo;
using Newtonsoft.Json;
using linq.Observer;

namespace linq.Torneo
{
    public class ManejarPartidos
    {

        public Partido iniciarPartido(Partido partido2)
        {
            Console.WriteLine(partido2.Resultado());
            return partido2;
        }
        public void finalizarPartido(Partido partido1)
        {
            GestorPartidos gestor = new GestorPartidos(); 
            Resultado resultado1 = new Resultado();
            Faltas amarillas = new Faltas();
            Expulsiones rojas= new Expulsiones();
            gestor.Suscribe(amarillas);
            gestor.Suscribe(rojas);
            gestor.Suscribe(resultado1);
            gestor.Notify(partido1);
            
        }
        
    }
}