using PetSafe;
using PetSafe_Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSafe_Services
{
    internal class PetService
    {
        private readonly PetRepository _petRepository;
        public PetService(PetRepository petRepository)
        {
            _petRepository = petRepository;
        }

        public bool Salvar(Pet entidade)
        {
            return _petRepository.Salvar(entidade);
        }
    }
}
