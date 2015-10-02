using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace EnigmaMachine
{
	internal class Rotores
	{
		private List<Rotor> iRotores;

		private List<Rotor> ListaRotores
		{
			get { return this.iRotores; }
			set { this.iRotores = value; }
		}

		private Rotor PrimerRotor
		{
			get { return ListaRotores.First(); }
		}

		private int CantidadRotores
		{
			get { return ListaRotores.Count; }
		}

		private Rotor RotorNum(int pNum)
		{
			return ListaRotores[pNum - 1];
		}

		public Rotores()
		{
			ListaRotores = new List<Rotor>();
		}

		private void AgregarRotor (Rotor pRotor)
		{
			ListaRotores.Add(pRotor);
		}

		private void EliminarRotores()
		{
			ListaRotores.Clear();
		}

		public void Girar ()
		{
			int i = 1;
			bool seguir = true;
			while ((seguir) && (i < CantidadRotores))
			{
				seguir = RotorNum(i).Girar();
				if (!RotorNum(i).Equals(PrimerRotor))
				{
					RotorNum(i-1).Girar();
				}
				i++;
			}
		}

		public void Inicializar(int[] pRotores)
		{
			EliminarRotores();
			for (int i = 1; i <= pRotores.Length; i++)
			{
				Rotor lRotor = new Rotor(i);
				AgregarRotor(lRotor);
			}
		}

		public void Configurar(char[] pAnillos)
		{
			int i = 0;
			foreach (Rotor lRotor in ListaRotores)
			{
				lRotor.Configurar(pAnillos[i++]);
			}
		}

		public char Cifrar (bool pDerecha, char pLetra)
		{
			List<Rotor> lLista = ((pDerecha) ? ListaRotores : Enumerable.Reverse(ListaRotores).ToList());
			char lResult = pLetra;
			foreach (Rotor lRotor in lLista)
			{
				lResult = lRotor.Cifrar(pDerecha, lResult);
			}
			return lResult;
		}
	}
}
