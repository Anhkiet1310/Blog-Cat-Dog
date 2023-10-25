using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;
using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.ObjectModel;
using System.Xml.Linq;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service
{
    public class PetService :  IPetService
    {
        private  SwpProjectContext _context = new SwpProjectContext() ;


        

        public Pet GetPetbyId(string id)
        {
            return _context.Pet.Where(p => p.IdPet == id).FirstOrDefault(); ;
        }

        public Pet GetPetbyName(string name)
        {
            return _context.Pet.Where(p => p.PetName == name).FirstOrDefault();
        }

        public Pet GetPetbyPrice(double price)
        {
        
            return _context.Pet.Where(p => p.Price >= price).FirstOrDefault();
        }

        public Pet GetPetbyWeight(double weight)
        {
            return _context.Pet.Where(p => p.Weight == weight).FirstOrDefault();
        }

        public ICollection<Pet> GetPets()
        {
            return _context.Pet.OrderBy(p => p.IdPet).ToList();
        }

        public bool PestExists(string petId)
        {
            return _context.Pet.Any(p => p.IdPet.Contains(petId));
        }
    }
}
