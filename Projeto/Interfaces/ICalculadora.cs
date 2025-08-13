using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Interfaces
{
    public interface  ICalculadora
    {
        int Somar(int a, int b);
        int Subtrair(int a, int b);
        int Multiplicar(int a, int b);
        int Dividir(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Divisão por zero não é permitida.");
            return a / b;
        }
        
    }
}