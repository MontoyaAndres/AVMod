using System;
using System.Windows.Forms;
namespace AVMod2
{
    class validacion
    {
        public void validarIP(KeyPressEventArgs e)
        {
            //si el dato es un numero, se permite.
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //si se decea borrar, se permite
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            //si se ingresa un . es permitido 
            else if (e.KeyChar =='.')
            {
                e.Handled = false;
            }
            else
            {
            //de lo contrario, no se permite
                e.Handled = true;
            }
        }
        public void validarPUERTO(KeyPressEventArgs e)
        {
            //si el dato es un numero, se permite.
            if (char.IsNumber(e.KeyChar))
            {
                e.Handled = false;
            }
            //si se decea borrar, se permite
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                //de lo contrario, no se permite
                e.Handled = true;
            }
        }
    }
}
