using Microsoft.EntityFrameworkCore;
using PetSafe_Domain.Entidades;

namespace PetSafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //private readonly PetService _petRepository;
            //public PetService(PetRepository petRepository)
            //{
            //    _petRepository = petRepository;
            //}

                // Adicionar um usuário
                var usuario = new Usuario
                {
                    Nome = "Maria Santos",
                    Email = "maria@example.com",
                    Senha = "password123",
                    Telefone = "999888777",
                    Endereco = "Rua XYZ, 123",
                    DataCriacao = DateTime.UtcNow
                };
                
                // Adicionar um pet para o usuário
                var pet = new Pet
                {
                    Nome = "LEci",
                    Raca = "Aleatorio",
                    Idade = 4,
                    Peso = 35.7M,
                    DataCadastro = DateTime.UtcNow,
                    Usuario = usuario // Associando o pet ao usuário
                };
                
                

                // Consultar dados inseridos
                var usuarios = context.Usuarios.Include(u => u.Pets).ToList();
                foreach (var user in usuarios)
                {
                    Console.WriteLine($"Usuário: {user.Nome}, Pet: {user.Pets.FirstOrDefault()?.Nome}");
                }
            
        }
    }
}
