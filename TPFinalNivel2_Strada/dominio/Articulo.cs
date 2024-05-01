using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        [DisplayName("Codigo")]
        public string Codigo { get; set; }
        
        [DisplayName ("Precio")]
        public decimal Precio { get; set; }

        [DisplayName ("Nombre")]
        public string Nombre { get; set;}

        [DisplayName ("Descripcion")]
        public string Descripcion { get; set;}

        public string ImagenUrl { get;  set; }

        public int IdMarca { get; set; }
        public int IdCategoria { get; set; }

        [DisplayName ("Marca")]
        public Marca Marca { get; set; }

        [DisplayName("Categoria")]
        public Categoria Categoria { get; set; }

        public int Id { get; set; }

    }
}
