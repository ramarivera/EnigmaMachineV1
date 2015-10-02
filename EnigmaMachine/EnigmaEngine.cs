using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnigmaMachine
{
	public class EnigmaEngine
	{

		private static readonly int TAMAÑO_BLOQUE = 6;
		private static readonly char[] CONVERSION_NUMEROS = ("PQWERTZUIO".ToCharArray());

		private Rotores iRotores;
		private Reflector iReflector;
		private TableroConexiones iPlugBoard;



		private Rotores Rotores
		{
			get { return this.iRotores; }
			set { this.iRotores = value; }
		}

		private Reflector Reflector
		{
			get { return this.iReflector; }
			set { this.iReflector = value; }
		}

		private TableroConexiones Tablero
		{
			get { return this.iPlugBoard; }
			set { this.iPlugBoard = value; }
		}


		public EnigmaEngine()
		{
			Rotores = new Rotores();
			Tablero = new TableroConexiones();
			Reflector = new Reflector();
		}

	
		public void Configurar(int[] pRotores, char[] pAnillos, string pConexiones)
		{
			Rotores.Inicializar(pRotores);
			Rotores.Configurar(pAnillos);
			Tablero.Configurar(pConexiones);
		}

		public string Encriptar(string pCadena)
		{
			string lCadena = pCadena;
			lCadena = PrepararCadenaEncriptacion(lCadena);
			return CifrarCadena(lCadena);
		}

		public string Desencriptar(string pCadena)
		{
			string lCadena = pCadena;
			lCadena = CifrarCadena(lCadena);
			lCadena = PrepararCadenaDesencriptacion(lCadena);
			return lCadena;
		}
		private string PrepararCadenaEncriptacion (string pCadena)
		{
			string lCadena  = pCadena.ToUpper().Replace(" ", "$20");
            StringBuilder lConv = new StringBuilder ();
			
			for (int i = 0; i < lConv.Length; i++)
			{
				if (Char.IsDigit(lCadena[i]))
				{
					lConv.Append("YY" + CONVERSION_NUMEROS[lCadena[i]]);
				}
				else
				{
					lConv.Append(lCadena[i]);
				}
				if (lCadena.Length % TAMAÑO_BLOQUE == 0)
				{
					lConv.Append(' ');
				}
			}
			return lCadena.ToString();
		}

		private string PrepararCadenaDesencriptacion(string pCadena)
		{
			string lCadena = pCadena.Replace(" ", String.Empty);
			lCadena = lCadena.Replace("YYP", "0");
			lCadena = lCadena.Replace("YYQ", "1");
			lCadena = lCadena.Replace("YYW", "2");
			lCadena = lCadena.Replace("YYE", "3");
			lCadena = lCadena.Replace("YYR", "4");
			lCadena = lCadena.Replace("YYT", "5");
			lCadena = lCadena.Replace("YYZ", "6");
			lCadena = lCadena.Replace("YYU", "7");
			lCadena = lCadena.Replace("YYO", "8");
			lCadena = lCadena.Replace("YYI", "9");
			lCadena = pCadena.Replace("$20", " ");
			return lCadena;
		}
		private string CifrarCadena(string pCadena)
		{
			StringBuilder lResult = new StringBuilder();
			for (int i = 0; i < pCadena.Length; i++)
			{
				lResult.Append(CifrarChar(pCadena[i]));
			}
			return lResult.ToString();
		} 

		private char CifrarChar(char pChar)
		{
			char lResult = pChar;
			if (Char.IsLetter(pChar))
			{
				lResult = Tablero.Conectar(lResult);
				lResult = Rotores.Cifrar(true, lResult);
				lResult = Reflector.Reflejar(lResult);
				lResult = Rotores.Cifrar(false, lResult);
				lResult = Tablero.Conectar(lResult);
				Rotores.Girar();
			}
			return lResult;
		}



	}
}
