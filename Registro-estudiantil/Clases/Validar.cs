using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro_estudiantil.Clases
{
    public class Validar
    {
        //Variable para validar el ingreso de un punto
        private bool ingresoPunto = false;

        //Valida si existe al menos un campo vacío dentro de un control
        public bool CampoVacio(Control control)
        {
            //Retorna verdadero si el campo esta vacio
            bool camposVacios = false;

            //Recorre los controles del formulario o contenedor
            foreach (var elemento in control.Controls)
            {
                //Castea el control a TextBox
                //Verifica si el control es un TextBox
                if (elemento is TextBox txt)
                {
                    //Verifica si el campo esta vacio
                    if (string.IsNullOrEmpty(txt.Text))
                    {
                        camposVacios = true;
                    }
                }
                //Verifica si el control es un ComboBox
                if (elemento is ComboBox cmb)
                {
                    //Verifica si el ComboBox NO tiene nungún elemento seleccionado
                    if (cmb.SelectedItem == null)
                    {
                        camposVacios = true;
                    }
                }
            }

            return camposVacios;
        }

        //Valida números flotantes
        public void ValidarFlotantes(object  sender, KeyPressEventArgs e, ErrorProvider error, TextBox txt)
        {
            //Permite almacenar números flotantes (Con decimales)
            char caracterAnterior = 'n';
            if (txt.Text != "")//Verifica si la caja de texto tiene caracteres dentro.
            {
                caracterAnterior = txt.Text[txt.Text.Length - 1];//Almacena el ultimo caracter de la caja.
            }

            if (caracterAnterior == '.' && e.KeyChar == '.')//Verifica si hay un punto en la posicion aterior y si el nuevo caracter es otro punto.
            {
                //No permite almacenar otro punto (Porque ya existe uno en la posicion anterior)
                e.Handled = true;
                error.SetError(txt, "No es permitido usar puntos continuos.");
            }
            else if (caracterAnterior == 'n' && e.KeyChar == '.')//Verifica si el primer caracter es un punto
            {
                //No permite almacenar un punto al inicio
                e.Handled = true;
                error.SetError(txt, "No puede ingresar un punto al inicio.");
            }
            else if (ingresoPunto && e.KeyChar == '.')
            {
                //No permite almacenar más de un punto dentro de la caja de texto
                e.Handled = true;
                error.SetError(txt, "No puede ingresar más de un punto.");
            }
            else
            {
                //Validacion de datos
                if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) || '.' == e.KeyChar))
                {
                    e.Handled = true;
                    error.SetError(txt, "Caracter no válido.");
                }
                else
                {
                    if (e.KeyChar == '.')//Verifica si el nuevo caracter es un punto
                    {
                        ingresoPunto = true;//Cambia el valor de la variable a "true" (Para indicar que ya se ingresó un punto)
                    }
                    e.Handled = false;
                    error.Clear();
                }
            }
        }

        //Valida números enteros
        public void ValidarEnteros(object sender, KeyPressEventArgs e, ErrorProvider error, TextBox txt)
        {
            //Validacion de datos
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
                error.SetError(txt, "Caracter no válido.");
            }
            else
            {
                e.Handled = false;
                error.Clear();
            }
        }

        //Valida solo letras
        public void ValidarLetras(object sender, KeyPressEventArgs e, ErrorProvider error, TextBox txt)
        {
            //Validacion de datos
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                error.SetError(txt, "Caracter no válido.");
            }
            else
            {
                e.Handled = false;
                error.Clear();
            }
        }

        //Valida solo letras y números
        public void ValidarLetrasNumeros(object sender, KeyPressEventArgs e, ErrorProvider error, TextBox txt)
        {
            //Validacion de datos
            if (!(char.IsLetterOrDigit(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                error.SetError(txt, "Caracter no válido.");
            }
            else
            {
                e.Handled = false;
                error.Clear();
            }
        }

        //Valida si el correo es correcto
        public bool ValidarCorreo(string correo)
        {
            //Valida si el correo es correcto
            return System.Text.RegularExpressions.Regex.IsMatch(correo, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        }

        //Valida si el número de teléfono es correcto
        public bool ValidarTelefono(string telefono)
        {
            //Valida si el número de teléfono es correcto
            return System.Text.RegularExpressions.Regex.IsMatch(telefono, @"^([0-9]{8})$");
        }
        
        //Valida el número de DUI con el formato (xxxxxxxx-x)
        public bool ValidarDUI(string dui)
        {
            //Valida si el número de DUI es correcto
            return System.Text.RegularExpressions.Regex.IsMatch(dui, @"^([0-9]{8}[-][0-9]{1})$");
        }
    }
}
