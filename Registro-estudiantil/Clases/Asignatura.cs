using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_estudiantil.Clases
{
    public class Asignatura
    {
		//Atributos con sus respectivos metodos de acceso
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private float notaPromedio;

		public float NotaPromedio
		{
			get { return notaPromedio; }
			set { notaPromedio = value; }
		}

		//Metodo constructor con parametros
		public Asignatura(string nombre, float notaPromedio)
		{
            this.nombre = nombre;
            this.notaPromedio = notaPromedio;
        }

		//Metodo constructor sin parametros
		public Asignatura()
		{
			//Inicializar los atributos
			this.nombre = "";
            this.notaPromedio = 0;
        }
	}
}
