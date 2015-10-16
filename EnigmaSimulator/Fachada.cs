using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EnigmaMachine;

namespace EnigmaSimulator.WinForms
{
    class Fachada
    {
        private static readonly char[] BASE_ANILLO = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();


        public List<char> ListarLetras()
        {
            List<char> lLista = new List<char>();
            for (char letra = 'A'; letra <= 'Z'; letra++)
            {
                lLista.Add(letra);
            }
            return lLista;
        }

        public bool ValidarConfiguracionTablero(string pConfiguracion)
        {
            return EnigmaEngine.ValidarConfiguracionTablero(pConfiguracion);
        }


        public 
    }
}
