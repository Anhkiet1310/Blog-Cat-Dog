using Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.Model;

namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Service.Interface
{
    public interface IPetService
    {
        ICollection<Pet> GetPets();

        Pet GetPetbyId(string id);

        Pet GetPetbyName(string name);

        Pet GetPetbyPrice(double price);

        Pet GetPetbyWeight(double weight);

        bool PestExists(string petId);




    }
}
