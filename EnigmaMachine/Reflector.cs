using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
	internal class Reflector
	{
		private static readonly string BASE_REFLECTOR = "PZOEJDHCGFUTXMALRBKYINSQVW";

		private string iConfiguracion;

        private string Configuracion
		{
			get { return this.iConfiguracion; }
			set { this.iConfiguracion = value; }
		}

		public Reflector()
		{
			Configuracion = Reflector.BASE_REFLECTOR;
		}

		//		PZOEJDHCGFUTX
		//		MALRBKYINSQVW
		public char Reflejar(char pLetra)
		{
			int lPos = Configuracion.IndexOf(pLetra);
            return Configuracion[(lPos+13) % 26];
		}
	}
}
