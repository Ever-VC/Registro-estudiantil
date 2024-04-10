using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_estudiantil.Clases
{
    //Clase AspiranteEventArgs que hereda de EventArgs para manejar los eventos de la clase Aspirante
    //especificamente para el evento de inscripción
    public  class AspiranteEventArgs : EventArgs
    {
        //Propiedad de la clase Aspirante
        public Aspirante Aspirante { get; set; }

        //Constructor de la clase AspiranteEventArgs
        public AspiranteEventArgs(Aspirante aspirante)
        {
            Aspirante = aspirante;
        }
    }
}
