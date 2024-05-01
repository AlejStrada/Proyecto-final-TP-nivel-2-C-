using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace presentacion
{
    public  class HelperPresentacion
    {
        public void cargarImagen(string imagenUrl, PictureBox pcbox) 
        {
            try
            {
                pcbox.Load(imagenUrl); 
            }
            catch
            {
                pcbox.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/d/da/Imagen_no_disponible.svg/300px-Imagen_no_disponible.svg.png");
            }
        }


    }
}
