using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominios.MetaData
{
	public interface IRubro
	{

		[Required(ErrorMessage = "El campo {0} es Obligatorio")]
		[StringLength(250, ErrorMessage = "El campo {0} debe ser menor {1} caracteres.")]
		string Descripcion { get; set; }
	}
}
