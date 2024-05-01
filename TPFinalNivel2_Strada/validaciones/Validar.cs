using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace validaciones
{
    public class Validar
    {
        public bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }  
        public bool requeridos(string txtBox)
        {
        if (string.IsNullOrEmpty(txtBox))
           {
            return true;
           }
        return false;
        }
    }



}
