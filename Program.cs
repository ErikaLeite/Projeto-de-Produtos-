using System;
using Projeto_de_Produtos_.classes;

namespace Projeto_de_Produtos_
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto item = new Produto();
            item.CadastrarItem();
            item.ListarItem();
            

        }
    }
}
