using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class Evaluacion
	{

		public int _numero { get; set; }

		public string _resultado { get; set; }

		public DateOnly _fechaEvaluacion { get; set; }

		public string _profesional { get; set; }

		public TipoEvalucion _tipo { get; set; }

		public string _observacion { get; set; }
	}

}
