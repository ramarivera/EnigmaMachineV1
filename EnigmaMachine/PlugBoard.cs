using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
	internal class TableroConexiones
	{
		
	
		private Dictionary<char, char> iConfiguracion;
		public Dictionary<char, char> Configuracion
		{
			get { return this.iConfiguracion; }
			set { this.iConfiguracion = value; }
		}

		public TableroConexiones()
		{
			Configuracion = new Dictionary<char, char>();
		}

		public void AgregarConexion (char p1, char p2)
		{
			if (!Configuracion.ContainsKey(p1) && !Configuracion.ContainsKey(p2))
			{
				Configuracion.Add(p1, p2);
				Configuracion.Add(p2, p1);
			}
		}

		public void Configurar(string pConfiguracion)
		{
			int i = 0;
			while (i < pConfiguracion.Length)
			{
				AgregarConexion(pConfiguracion[i++], pConfiguracion[i++]);
			}
		}

	
		public static bool ConfiguracionValida (string pConfiguracion)
		{
			if (pConfiguracion.Length % 2 != 0)
			{
				return false;
			}
			if (!(pConfiguracion.Any(char.IsUpper)))
			{
				return false;
			}
			return ((new HashSet<char>(pConfiguracion.ToArray())).Count == pConfiguracion.Length);
		}

		public char Conectar (char pLetra)
		{
			char lResult;
			if (!Configuracion.TryGetValue(pLetra,out lResult))
			{
				lResult = pLetra;
			}
			return lResult;
		}
	
	}
}
