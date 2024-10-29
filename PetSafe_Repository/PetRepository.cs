using PetSafe_Domain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetSafe
{
    public class PetRepository
    {
        private readonly PetSafeContext _context;

        public PetRepository(PetSafeContext context)
        {
            _context = context;
        }
        public bool Salvar(Pet entity)
        {
            try
            {
                if (entity.Id == 0)
                {
                    _context.Pet.Add(entity);
                }
                else
                {
                    _context.Pet.Update(entity);
                }
                _context.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
