using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSafe_Domain.Entidades
{
    public class Pet : BaseEntity
    {
        public string Nome { get; set; }
        public string Raca { get; set; }
        public int Idade { get; set; }
        public decimal Peso { get; set; }
        public DateTime DataCadastro { get; set; }

        // Foreign key (chave estrangeira)
        public int IDUsuario { get; set; }
        public Usuario Usuario { get; set; }
    }
}
