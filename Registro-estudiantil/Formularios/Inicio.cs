using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.Marshalling;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro_estudiantil.Clases;

namespace Registro_estudiantil.Formularios
{
    public partial class Inicio : Form
    {
        //Lista de aspirantes
        private List<Aspirante> lstRegistroAspirantes = [];
        //Objeto de la clase aspirante
        private Aspirante aspirante = null;

        public Inicio()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //Almacenamos la informaci[on del aspirante
            int id = 1;//Almacen el id del aspirante (segun la cantidad de registros en la lista)

            //Validamos si la lista de aspirantes es nula
            if (lstRegistroAspirantes.Count > 0)
            {
                id = lstRegistroAspirantes.Count + 1;//Crea el id con la cantidad de elemento que hay en la lista
            }

            aspirante = new Aspirante
            {
                Id = id,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Edad = Convert.ToInt32(txtEdad.Text),
                Direccion = txtDireccion.Text,
                Dui = txtDui.Text,
                Telefono = txtTelefono.Text
            };

            //Asigna las notas promedio de las asignaturas básicas
            aspirante.AsignaturasCursadas[0].NotaPromedio = float.Parse(txtPromedioLenguaje.Text);
            aspirante.AsignaturasCursadas[1].NotaPromedio = float.Parse(txtPromedioMatematica.Text);
            aspirante.AsignaturasCursadas[2].NotaPromedio = float.Parse(txtPromedioSociales.Text);
            aspirante.AsignaturasCursadas[3].NotaPromedio = float.Parse(txtPromedioCiencias.Text);
            aspirante.AsignaturasCursadas[4].NotaPromedio = float.Parse(txtPromedioIngles.Text);

            //Agrega el objeto aspirante a la lista
            lstRegistroAspirantes.Add(aspirante);
            ActualizarDataGrid();

        }

        private void ActualizarDataGrid()
        {
            //Limpiar el datagridview
            dgvAspirantes.Rows.Clear();
            dgvAspirantes.Columns.Clear();

            //Agregar las columnas al datagridview
            dgvAspirantes.Columns.Add("id", "Id");
            dgvAspirantes.Columns.Add("nombre", "Nombre");
            dgvAspirantes.Columns.Add("apellido", "Apellido");
            dgvAspirantes.Columns.Add("adad", "Edad");
            dgvAspirantes.Columns.Add("direccion", "Dirección");
            dgvAspirantes.Columns.Add("dui", "DUI");
            dgvAspirantes.Columns.Add("telefono", "Teléfono");
            dgvAspirantes.Columns.Add("rendimientoAcademico", "Promedio");
            dgvAspirantes.Columns.Add("asignaturasInscritas", "Asignaturas Inscritas");


            foreach (Aspirante aspirante in lstRegistroAspirantes)
            {
                float sumaPromedios = 0;//Almacena la suma de los promedios de las asignaturas cursadas

                for (int i = 0; i < aspirante.AsignaturasCursadas.Length; i++)
                {
                    sumaPromedios += aspirante.AsignaturasCursadas[i].NotaPromedio;
                }

                //Calcula el rendimiento academico del aspirante (promedio de asignaturas cursadas)
                float rendimientoAcademico = sumaPromedios / aspirante.AsignaturasCursadas.Length;

                string asignaturasInscritas = "";//Almacena las asignaturas inscritas del el aspirante

                //Verifica si el aspirante tiene asignaturas inscritas
                if (aspirante.AsignaturasInscritas.Count > 0)
                {
                    foreach (Asignatura asignatura in aspirante.AsignaturasInscritas)
                    {
                        //Verifica si es la primer asignatura a agregar en la cadena
                        if (asignaturasInscritas == "")
                        {
                            asignaturasInscritas += asignatura.Nombre;//Agrega el nombre de la asignatura
                        }
                        else
                        {
                            asignaturasInscritas += ", " + asignatura.Nombre;//Agrega el nombre de la asignatura seguido de una coma
                        }
                    }
                }
                else
                {
                    asignaturasInscritas = "Sin Asignaturas";//Asigna el mensaje de que no tiene asignaturas inscritas
                }

                //Crea la nueva fila para el DataGridView
                string[] row = new string[] {
                    aspirante.Id.ToString(),
                    aspirante.Nombre,
                    aspirante.Apellido,
                    aspirante.Edad.ToString(),
                    aspirante.Direccion,
                    aspirante.Dui,
                    aspirante.Telefono,
                    rendimientoAcademico.ToString("F2"),
                    asignaturasInscritas
                };

                dgvAspirantes.Rows.Add(row);
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            //Verificamos el estado del label que debe contener el ID del aspirante si se ha hecho una selección
            if (lblIdSeleccionado.Text != "ID SELECCIONADO")
            {
                this.Hide();//Oculta el formulario actual
                int idAspirante = int.Parse(lblIdSeleccionado.Text);//Almacena el id del aspirante seleccionado
                //El 'id' del aspirante seleccionado es la (posición - 1) en donde se encuentra
                //dentro de la lista
                Aspirante aspirante = lstRegistroAspirantes[idAspirante - 1];//Indicamos el 'id' a buscar (que es su posición - 1)

                Inscripcion inscripcion = new Inscripcion();
                inscripcion.setAspirante(aspirante);
                inscripcion.Show();//Muestra el formulario de inscripción
                inscripcion.FormClosed += Salir;//Se ejecuta cuando se cierra el nuevo formulario
            }
            else
            {
                MessageBox.Show("Por favor seleccione el aspirante al que le desea incribir asignaturas", "¡ATENCIÓN!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvAspirantes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblIdSeleccionado.Text = dgvAspirantes.CurrentRow.Cells[0].Value.ToString();
        }

        private void Salir(Object sender, FormClosedEventArgs e)//Se ejecuta cuando se cierra el nuevo formulario
        {
            //limpiarTodo();
            this.Show();//Muestra el formulario de de controlBoletos
        }
    }
}
