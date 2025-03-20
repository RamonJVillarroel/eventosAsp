using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Direccion
{
     public class NegocioDirecion
    {


        public List<Direccion> DireccionListar()
        {
         
            List<Direccion> listaDireccion = new List<Direccion>();
            listaDireccion.Add(new Direccion());
            listaDireccion.Add(new Direccion());
            listaDireccion[0].Id = 1;
            listaDireccion[0].Altura = 100;
            listaDireccion[0].Calle = "Juventud";

            listaDireccion[1].Id = 2;
            listaDireccion[1].Altura = 200;
            listaDireccion[1].Calle = "Estudios";
            
            return listaDireccion;
        }
        

        public void DireccionDeled(Direccion direccion)
        {
            List<Direccion> listaDireccion = new List<Direccion>();
            listaDireccion.Remove(direccion);
        }
        public void DireccionUpdate(Direccion direccion)
        {
            //List<Direccion> listaDireccion = new List<Direccion>();
            //listaDireccion.(direccion);
        }


       
    }
}
