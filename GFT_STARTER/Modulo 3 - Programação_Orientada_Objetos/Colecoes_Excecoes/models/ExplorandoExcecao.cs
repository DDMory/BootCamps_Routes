using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Colecoes_Excecoes.models
{
    public class ExplorandoExcecao
    {

        public void Metodo1()
        {
            try
            {
                Metodo2();
            }
            catch (Exception e)
            {
                Console.WriteLine("Excecao tratada. " + e.StackTrace);
            }
        }
        public void Metodo2()
        {
            Metodo3();
        }
        public void Metodo3()
        {
            Metodo4();
        }
        public void Metodo4()
        {
            throw new Exception("Ocorreu uma exceção");
        }
    
    }
    
    
}