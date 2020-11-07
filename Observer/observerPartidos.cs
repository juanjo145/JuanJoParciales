using linq.Torneo;
using System;
using System.Collections.Generic;

namespace linq.Observer

{
    public interface observerPartidos
    {

        void update(Partido partido);
        
    }
}