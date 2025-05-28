using System;
using System.Collections.Generic;

namespace Treino
{
    class Usuario
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        private static List<Usuario> Usuarios = new List<Usuario>();

        public Usuario(string nome, string email)
        {
            this.Nome = nome;
            this.Email = email;
        }

        private void MudarCor()
        {
            Console.ForegroundColor = ConsoleColor.Green;
        }

        public void CadastroConcluido()
        {
            Console.WriteLine($"\nNome: {Nome}");
            MudarCor();
            Console.WriteLine("Cadastrado com sucesso!");
            Console.ResetColor();

            Console.WriteLine($"\nEmail: {Email}");
            MudarCor();
            Console.WriteLine("Cadastrado com sucesso!");
            Console.ResetColor();
        }

        public static void AdicionarUsuarioNaLista(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        public static void ListarUsuarios()
        {
            Console.WriteLine("\n ---  Usuários cadastrados --- ");
            foreach (var usuario in Usuarios)
            {
                Console.WriteLine($"Nome: {usuario.Nome}");
                Console.WriteLine($"Email: {usuario.Email}");
                Console.WriteLine("-------------------------");
            }
        }
    }
}

namespace Treino

{
    class Program
    { 
        static void Main(string[] args) 

        {
     
            int opcao = 0;


            do
            {
                Console.WriteLine("\n______________________________________");
                Console.WriteLine("\n=== MENU DE CADASTRO DE USUÁRIOS ===");
                Console.WriteLine("\n 1 - Cadastrar novo usuário");
                Console.WriteLine(" 2 - Listar usuários cadastrados");
                Console.WriteLine(" 3 - sair");
                opcao = int.Parse(Console.ReadLine());


                switch (opcao)
                {
                    case 1:
                        
                        Console.Write("Digite seu nome: ");
                        string NomeA = Console.ReadLine();

                        Console.Write("Digite seu email: ");
                        string EmailA = Console.ReadLine();
                        
                        Usuario cadastroA = new Usuario(NomeA, EmailA);
                        Usuario.AdicionarUsuarioNaLista(cadastroA);
                        cadastroA.CadastroConcluido();
                        break;

                    case 2:

                        Usuario.ListarUsuarios();

                        break;
                }
            
            } while (opcao != 3);               
             
        }
    }
}
