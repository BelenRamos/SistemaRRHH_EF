using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    public class OfertaLaboral
    {
      

        public int _id { get; set; }

        public string _titulo { get; set; }

        public string _descripcion { get; set; }

        public DateOnly _fechaCreacion { get; set; }

        public DateOnly _fechaPublicacion { get; set; }

        public DateOnly _fechaCierre { get; set; }

        public List<Requisito> _requisitos { get; set; }


    }


}
