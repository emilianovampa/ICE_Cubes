using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaCrucero.model
{
    class Puerto
    {
        public Boolean activo = true;
        public String nombre;

        public Puerto (String nombre){
            this.nombre = nombre;
    }
        
        public void eliminar(){
            this.activo = false;
            /* Aca agregar la logica correspondiente de eliminar*/
        }
}
