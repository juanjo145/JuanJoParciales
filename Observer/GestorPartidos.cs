using System;
using System.Collections.Generic;
using linq.Torneo;

namespace linq.Observer
{
    public class GestorPartidos
    {
        #region Properties
        private List<observerPartidos> suscribers;  

        public List<observerPartidos> Suscribers
        {
            get { return suscribers; }
            set {  suscribers = value; }
        }

        public List<Seleccion> Selecciones
        {
            get ; set;
        }

        public List<Partido> Partidos
        {
            get ; set;
        }

        #endregion Properties

        #region Initialize
        public GestorPartidos()
        {
            Suscribers = new List<observerPartidos>();
        }
        #endregion Initialize


        #region Methods
        public void Suscribe(observerPartidos SeleccionesB)
        {
            Suscribers.Add(SeleccionesB);
        }

        public void Unsuscribe(observerPartidos SeleccionB)
        {
            Suscribers.Remove(SeleccionB);
        }

        public void Notify(Partido partido)
        {
            Suscribers.ForEach(s => {
                s.update(partido);
            });
        }

        #endregion Methods
    }
}