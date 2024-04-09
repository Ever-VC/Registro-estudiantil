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

namespace Registro_estudiantil.Formularios
{
    public partial class Inscripcion : Form
    {
        //Lista de aspirantes
        private Aspirante aspirante = null;

        public Inscripcion()
        {
            InitializeComponent();
        }

        private void Inscripcion_Load(object sender, EventArgs e)
        {
            lblNombreAspirante.Text = aspirante.Nombre + " " + aspirante.Apellido;
            lblRendimientoAspirante.Text = aspirante.CalcularRendimiento().ToString("F2");
        }

        public void setAspirante(Aspirante aspirante)
        {
            this.aspirante = aspirante;
        }

        
    }
}
