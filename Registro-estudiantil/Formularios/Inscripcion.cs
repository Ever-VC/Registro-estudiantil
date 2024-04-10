using Registro_estudiantil.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Registro_estudiantil.Formularios
{
    public partial class Inscripcion : Form
    {
        //Lista de aspirantes
        private Aspirante aspirante = null;
        //Almacena la cantidad de asignaturas que el aspirante puede inscribir
        private int cantidadAsignaturas;

        public Inscripcion()
        {
            InitializeComponent();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            float rendimientoAcademico = aspirante.CalcularRendimiento();
            lblNombreAspirante.Text = aspirante.Nombre + " " + aspirante.Apellido;
            lblRendimientoAspirante.Text = rendimientoAcademico.ToString("F2");

            if (rendimientoAcademico < 5)
            {
                cantidadAsignaturas = 0;
                BloquearCheckBox();
            }
            else if (rendimientoAcademico < 6)
            {
                cantidadAsignaturas = 2;
            }
            else if (rendimientoAcademico < 7)
            {
                cantidadAsignaturas = 3;
            }
            else if (rendimientoAcademico < 8)
            {
                cantidadAsignaturas = 4;
            }
            else
            {
                cantidadAsignaturas = 5;
            }
        }

        public void setAspirante(Aspirante aspirante)
        {
            this.aspirante = aspirante;
        }

        private void BloquearCheckBox()
        {
            foreach (CheckBox elemento in gbAsignaturas.Controls)
            {
                if (!elemento.Checked)
                {
                    elemento.Enabled = false;
                }
            }
        }

        public void HabilitarCheckBox()
        {
            foreach (CheckBox elemento in gbAsignaturas.Controls)
            {
                if (!elemento.Checked)
                {
                    elemento.Enabled = true;
                }
            }
        }

        private void chkIntroInformatica_CheckedChanged(object sender, EventArgs e)
        {
            AumentarDisminuirAsignaturas(chkIntroInformatica);
        }

        private void chkMate1_CheckedChanged(object sender, EventArgs e)
        {
            AumentarDisminuirAsignaturas(chkMate1);
        }

        private void chkPsicologiaSocial_CheckedChanged(object sender, EventArgs e)
        {
            AumentarDisminuirAsignaturas(chkPsicologiaSocial);
        }

        private void chkFisica1_CheckedChanged(object sender, EventArgs e)
        {
            AumentarDisminuirAsignaturas(chkFisica1);
        }

        private void chkProba_CheckedChanged(object sender, EventArgs e)
        {
            AumentarDisminuirAsignaturas(chkProba);
        }

        private void chkIngles_CheckedChanged(object sender, EventArgs e)
        {
            AumentarDisminuirAsignaturas(chkIngles);
        }

        private void chkIngeEco_CheckedChanged(object sender, EventArgs e)
        {
            AumentarDisminuirAsignaturas(chkIngeEco);
        }

        private void AumentarDisminuirAsignaturas(CheckBox checkbox)
        {
            //Si la cantidad de asignaturas es mayor a 0
            if (cantidadAsignaturas > 0)
            {
                //Verifica si se está seleccionando el checkbox
                if (checkbox.Checked)
                {
                    //Si se está seleccionando, verificamos si es su última selección posible
                    //(si la cantidad de asignaturas es igual a 1) para bloquear los checkboxs restantes
                    if (cantidadAsignaturas == 1)
                    {
                        cantidadAsignaturas -= 1;//Resta 1 a la cantidad de asignaturas que puede isncribir (quedando en 0)
                        BloquearCheckBox();//Bloquea los checkboxs restantes
                    }
                    else
                    {
                        //Si no es su última selección posible, se resta 1 a la cantidad de asignaturas que puede inscribir
                        cantidadAsignaturas -= 1;
                    }
                }
                else
                {
                    //--------------------------
                    //Si se está deseleccionando el checkbox, se aumenta la cantidad de asignaturas
                    //para que pueda inscribir +1 asignatura y se habilitan los checkboxs que no estén seleccionados
                    cantidadAsignaturas += 1;
                    HabilitarCheckBox();
                }
            }
            else
            {
                //Si la cantidad de asignaturas es igual a 0 verificamos si se está deseleccionando el checkbox
                if (!checkbox.Checked)
                {
                    //Si se está deseleccionando el checkbox, se aumenta la cantidad de asignaturas
                    //para que pueda inscribir +1 asignatura y se habilitan los checkboxs que no estén seleccionados
                    cantidadAsignaturas += 1;
                    HabilitarCheckBox();
                }
            }
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            if (!(aspirante.CalcularRendimiento() < 5))
            {
                if (chkIntroInformatica.Checked)
                {
                    aspirante.AsignaturasInscritas.Add(new Asignatura("Introducción a la Informática", 0));
                }
                if (chkMate1.Checked)
                {
                    aspirante.AsignaturasInscritas.Add(new Asignatura("Matemática I", 0));
                }
                if (chkPsicologiaSocial.Checked)
                {
                    aspirante.AsignaturasInscritas.Add(new Asignatura("Psicología Social", 0));
                }
                if (chkFisica1.Checked)
                {
                    aspirante.AsignaturasInscritas.Add(new Asignatura("Física I", 0));
                }
                if (chkProba.Checked)
                {
                    aspirante.AsignaturasInscritas.Add(new Asignatura("Probabilidad y Estadística", 0));
                }
                if (chkIngles.Checked)
                {
                    aspirante.AsignaturasInscritas.Add(new Asignatura("Inglés", 0));
                }
                if (chkIngeEco.Checked)
                {
                    aspirante.AsignaturasInscritas.Add(new Asignatura("Ingeniería Económica", 0));
                }

                MessageBox.Show("Inscripción realizada con éxito.", "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show($"No se pueden inscribir asignaturas, el rendimiento académico de {aspirante.Nombre} {aspirante.Apellido} es menor a 5.", "Inscripción", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }

        }

        //Evento de inscripción de asignaturas al aspirante
        public event EventHandler<AspiranteEventArgs> AspiranteInscrito;

        private void Inscripcion_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Al cerrar el formulario de inscripción, se ejecuta el evento de inscripción
            AspiranteInscrito(this, new AspiranteEventArgs(aspirante));
            //AspiranteInscrito?.Invoke(this, new AspiranteEventArgs(aspirante));
        }
    }
}
