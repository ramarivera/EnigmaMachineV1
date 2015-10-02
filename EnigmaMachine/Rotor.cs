using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using static EnigmaMachine.TipoPosicion;

namespace EnigmaMachine
{
	internal class Rotor
	{
		private static readonly string[] BASE_CIPHER = { "PLFTDXSGJNEZOHCKUWYIMRABQV", "CKUWYIMRABQVPLFTDXSGJNEZOH" , "QVPLFTDXSGJNCKUWYIMRABEZOH" };
		private static readonly char[] BASE_MUESCA = { 'G', 'R' , 'A'};
		private static readonly string BASE_ANILLO = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		private char iMuesca;
		private StringBuilder iAnillo;
		private StringBuilder iCipher;
		
		public char Muesca
		{
			get { return this.iMuesca; }
			set { this.iMuesca = value; }
		}
		public StringBuilder Anillo
		{
			get { return this.iAnillo; }
			private set { this.iAnillo = value; }
		}

		public StringBuilder Cipher
		{
			get { return this.iCipher; }
			private set { this.iCipher = value; }
		}

		public Rotor(int pNum)
		{
			Anillo = new StringBuilder(Rotor.BASE_ANILLO);
			Muesca = Rotor.BASE_MUESCA[pNum - 1];
			Cipher = new StringBuilder(Rotor.BASE_CIPHER[pNum - 1]);
        }

	
		//		ABCDEFGHIJKLMNOPQRSTUVWXYZ
		public void Configurar (char pPosicionInicial)
		{
			string lAnillo = Anillo.ToString();
            
            int lPos = lAnillo.IndexOf(pPosicionInicial);

			if (lPos != 0)
			{
				Anillo.Clear();
				Anillo.Append(lAnillo.Substring(lPos, (lAnillo.Length)-lPos));
				Anillo.Append(lAnillo.Substring(0, lPos));
			}
			
        }

		public bool Girar () // antes de enviar la letra tengo que girar los rotores
		{
			char lActual = Anillo[0];
			Anillo.Insert(Anillo.Length - 1, Anillo[0]); //Inserto el primer caracter en el final del anillo
			Anillo.Remove(0, 1); // Elimino el primer caracter, caso contrario queda duplicado
			return (lActual == Muesca);
		}

		
		public int PosicionLetra (char pLetra, StringBuilder pCadena)
		{
			return pCadena.ToString().IndexOf(pLetra);
		}
		public char Cifrar (bool pDerecha, char pLetra)
		{
			return (pDerecha) ? CifrarHaciaDerecha(pLetra) : CifrarHaciaIzquierda(pLetra);
		}
		//		ABCDEFGHIJKLMNOPQRSTUVWXYZ
		//		PLFTDXSGJNEZOHCKUWYIMRABQV
		public char CifrarHaciaDerecha (char pLetra)//primer cifrado
		{
			return Cipher[PosicionLetra(pLetra, Anillo)];
		}
		public char CifrarHaciaIzquierda(char pLetra)//Cifrado en reversa
		{
			return Anillo[PosicionLetra(pLetra, Cipher)];
		}
	}
}
