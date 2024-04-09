using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registro_estudiantil.Clases
{
    public class Aspirante
    {
        //Atributos con sus respectivos metodos de acceso
        private int id;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private int edad;

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        private string direccion;

        public string Direccion
        {
            get { return direccion; }
            set { direccion = value; }
        }

        private string dui;

        public string Dui
        {
            get { return dui; }
            set { dui = value; }
        }

        private string telefono;

        public string Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }

        private Asignatura[] asignaturasCursadas;

        public Asignatura[] AsignaturasCursadas
        {
            get { return asignaturasCursadas; }
            set { asignaturasCursadas = value; }
        }

        private List<Asignatura> asignaturasInscritas;

        public List<Asignatura> AsignaturasInscritas
        {
            get { return asignaturasInscritas; }
            set { asignaturasInscritas = value; }
        }

        //Metodo constructor con parametros
        public Aspirante(int id, string nombre, string apellido, int edad, string direccion, string dui, string telefono, Asignatura[] asignaturasCursadas, List<Asignatura> asignaturasInscritas)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.direccion = direccion;
            this.dui = dui;
            this.telefono = telefono;
            this.asignaturasCursadas = asignaturasCursadas;
            this.asignaturasInscritas = asignaturasInscritas;
        }

        //Metodo constructor sin parametros
        public Aspirante()
        {
            //Instanciamos el arreglo de asignaturas cursadas con 5 elementos que representan las 5 asignaturas básicas
            asignaturasCursadas = [new Asignatura(), new Asignatura(), new Asignatura(), new Asignatura(), new Asignatura()];

            //Asignamos los nombres de las asignaturas basicas
            asignaturasCursadas[0].Nombre = "Lenguaje";
            asignaturasCursadas[1].Nombre = "Matemática";
            asignaturasCursadas[2].Nombre = "Sociales";
            asignaturasCursadas[3].Nombre = "Ciencias";
            asignaturasCursadas[4].Nombre = "Inglés";

            //Instanciamos la lista de asignaturas inscritas (vacía ya que el usuario asinará la información)
            asignaturasInscritas = [];

            //Inicializar los atributos
            this.id = 0;
            this.nombre = "";
            this.apellido = "";
            this.edad = 0;
            this.direccion = "";
            this.dui = "";
            this.telefono = "";
        }

        public float CalcularRendimiento()
        {
            float sumaPromedios = 0;//Almacena la suma de los promedios de las asignaturas cursadas

            for (int i = 0; i < asignaturasCursadas.Length; i++)
            {
                sumaPromedios += asignaturasCursadas[i].NotaPromedio;
            }

            //Calcula el rendimiento academico del aspirante (promedio de asignaturas cursadas)
            return sumaPromedios / asignaturasCursadas.Length;
        }

    }
}
