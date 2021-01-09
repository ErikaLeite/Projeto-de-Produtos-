using System;
using System.Collections.Generic;

namespace Projeto_de_Produtos_.classes
{
    public class Usuario
    {
        int CodigoUser { get; set; }
        string NomeUser { get; set; }
        string Email { get; set; }
        string Senha { get; set; }
        DateTime DataCadastroUser { get; set; }

        //Incrementar uma lista para melhorar o Método DeletarUser
        // List<Usuario> listaUser = new List <Usuario>();

        public Usuario()
        {
            //cadastrar um usuário automaticamente quando a classe for instanciado
            CadastrarUser();
        }
        public Usuario (int _codUser, string _nomeUser, string _email, string _senha)
        {
            CodigoUser       = _codUser;
            NomeUser         = _nomeUser;
            Email            = _email;
            Senha            = _senha;
            DataCadastroUser = DateTime.UtcNow;
        }
        
        public void CadastrarUser()
        {
            // Usuario user = new Usuario();
            Console.WriteLine("Digite seu nome completo: ");
            NomeUser = Console.ReadLine();
            
            Console.WriteLine("Digite seu e-mail:");
            Email = Console.ReadLine();
            
            Console.WriteLine("Digite uma senha:");
            Senha = Console.ReadLine();

            DataCadastroUser = DateTime.UtcNow;

            // listaUser.Add(user);                    
        }

        public void DeletarUser()
        {   
            // Usuario userDelete = new Usuario();
            NomeUser         = "";
            Email            = "";
            Senha            = "";
            DataCadastroUser = DateTime.Parse("0000-00-00t00:00:00");
            //Formato DateTime: AAAA-MM-DDTHH:MM-SS

            // listaUser.Remove(userDelete);
        }

        // public void ListarUser()
        // {
        //     foreach (Usuario user in listaUser)
        //     {
        //         Console.WriteLine($"Nome Usuário: {user.NomeUser} \nE-mail cadastrado: {user.Email} \nSenha Usuário: ****** \nData do Cadastro: {user.DataCadastroUser}");
                
        //     }
        // }  
    }
}