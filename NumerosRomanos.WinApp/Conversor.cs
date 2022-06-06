using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosRomanos.WinApp
{
    public class Conversor
    {
        #region dicionario de regras dos simbolos romanos
        Dictionary<char, int> regrasRomano = new Dictionary<char, int>() {
        {' ',0},
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
    };
        
       
        #endregion
        public double Converter(string valor)
        {
            var resultadoNumeroDecimal = 0;
            var simbolosRomanos = valor.ToUpper().ToCharArray();
            for (int i = 0; i <= simbolosRomanos.Length - 1; i++)
            {
                if (simbolosRomanos.Length - 1 == i)
                {
                    return resultadoNumeroDecimal += regrasRomano[simbolosRomanos[i]];
                }
                if (regrasRomano[simbolosRomanos[i]] >= regrasRomano[simbolosRomanos[(i + 1)]])
                {
                    resultadoNumeroDecimal += regrasRomano[simbolosRomanos[i]];
                }
                if (regrasRomano[simbolosRomanos[i]] < regrasRomano[simbolosRomanos[(i + 1)]])
                {
                    resultadoNumeroDecimal -= regrasRomano[simbolosRomanos[i]];
                }
            }
            return resultadoNumeroDecimal;
        }
        public bool ValidarNumeroRomano(string valor)
        {
            var simbolosRomanos = valor.ToUpper().ToCharArray();
            int contador = 0;
            for (int i = 0; i < simbolosRomanos.Length - 1; i++)
            {
                if (char.IsNumber(simbolosRomanos[i]))
                {
                    return false;
                }
                
                if (regrasRomano[simbolosRomanos[i]] == regrasRomano[simbolosRomanos[(i + 1)]])
                {
                    contador++;
                    if (contador == 3)
                    {
                        return false;
                    }
                }
                if (regrasRomano[simbolosRomanos[i]] != regrasRomano[simbolosRomanos[(i + 1)]])
                {
                    contador = 0;
                }
            }
            return true;

        }
    }
}
