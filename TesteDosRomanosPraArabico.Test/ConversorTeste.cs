using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDosRomanosPraArabico.Test
{
    public class ConversorTeste
    {
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

        public double ConverterRomano(string valor)
        {
            var resultado = 0;
            var simbolosRomanos = valor.ToUpper().ToCharArray();
            for (int i = 0; i <= simbolosRomanos.Length - 1; i++)
            {
                if (simbolosRomanos.Length - 1 == i)
                {
                    return resultado += regrasRomano[simbolosRomanos[i]];
                }
                if (regrasRomano[simbolosRomanos[i]] >= regrasRomano[simbolosRomanos[(i + 1)]])
                {
                    resultado += regrasRomano[simbolosRomanos[i]];
                }
                if (regrasRomano[simbolosRomanos[i]] < regrasRomano[simbolosRomanos[(i + 1)]])
                {
                    resultado -= regrasRomano[simbolosRomanos[i]];
                }
            }
            return resultado;
        }

        public string ConverterArabico(int valor)
        {
            Dictionary<int, string> regrasArabico = new Dictionary<int, string>()
        {
            {1,"I" },
            {5,"V" },
            {10,"X" },
            {50,"L" },
            {100,"C" },
            {500,"D" },
            {1000,"M" }
        };
            var resultado = "";
            while(valor != 0)
            {
                if(valor >= 1000)
                {
                    resultado += "M";
                    valor -= 1000;
                }
                else if(valor >= 500)
                {
                    if (valor >= 900)
                    {
                        resultado += "CM";
                        valor -= 900;
                        continue;
                    }
                    resultado += "D";
                    valor -= 500;
                }
                else if ( valor >= 100)
                {
                    if (valor >= 400)
                    {
                        resultado += "CD";
                        valor -= 400;
                        continue;
                    }
                    resultado += "C";
                    valor -= 100;
                }
                else if (valor >= 50)
                {
                    if (valor >= 90)
                    {
                        resultado += "XC";
                        valor -= 90;
                        continue;
                    }
                    resultado += "L";
                    valor -= 50;
                }
                else if(valor >= 10)
                {
                    if (valor >= 40)
                    {
                        resultado += "XL";
                        valor -= 40;
                        continue;
                    }
                    resultado += "X";
                    valor -= 10;
                }
                else if(valor >= 5)
                {
                    if(valor == 9)
                    {
                        resultado += "IX";
                        valor -= 9;
                        continue;
                    }
                    resultado += "V";
                    valor -= 5;
                }
                else if(valor >= 1)
                {
                    if(valor == 4)
                    {
                        resultado += "IV";
                        valor -= 4;
                        continue;
                    }
                    resultado += "I";
                    valor -= 1;
                }
            }
            return resultado;
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
