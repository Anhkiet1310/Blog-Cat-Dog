namespace Cat_Dog_Platform_BE.Team2.DogCatPlatform.Repository.DTO
{
    public class PetDTO
    {
        public string IdPet { get; set; } = null!;

        public string? PetName { get; set; }

        public int? PetAge { get; set; }

        public float? Weight { get;set; }

        public float Price{ get; set; } 

        public string? PetImage { get; set; }

    }
}
