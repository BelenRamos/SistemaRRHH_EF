using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.AccesoDatos
{
    [PrimaryKey(nameof(Fecha), nameof(Horario))]
    public class Turno
    {
       
        public string Fecha { get; set; }
        public string Horario { get; set; }
        public int NroEntrevista { get; set; }
        [ForeignKey("NroEntrevista")]
        public string PsicologoEntrevista { get; set; }
        [ForeignKey("PsicologoEntrevista")]

        public bool Disponible { get; set; }

        public virtual EntrevistaPerfil EntrevistaPerfil { get; set; }
        public virtual Psicologo Psicologo { get; set; }    




    }
}
