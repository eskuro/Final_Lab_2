using Dominios.UnidadDeTrabajo;
using IServicios.Comprobante;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.Comprobante
{
	public class FacturaServicio:ComprobanteServicio,IFacturaServicio
	{

		public FacturaServicio(IUnidadDeTrabajo unidadDeTrabajo)
			: base(unidadDeTrabajo)
		{
		}

	}
}
