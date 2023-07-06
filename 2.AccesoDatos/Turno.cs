using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
	public class Turno
	{

		public string _fecha { get; set; }

		public string _horario { get; set; }

		public bool _disponible { get; set; }

		public EntrevistaPerfil _nroEntrevista { get; set; }

		public Psicologo _psicologo { get; set; }

		

	}
}
