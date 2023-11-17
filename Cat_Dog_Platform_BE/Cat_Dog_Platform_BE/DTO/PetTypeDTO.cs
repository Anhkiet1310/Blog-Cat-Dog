﻿using Cat_Dog_Platform_BE.Entity;

namespace Cat_Dog_Platform_BE.DTO
{
    public class PetTypeDTO
    {
        public PetTypeDTO()
        {
        }

        public int TypeId { get; set; }
        public string TypeName { get; set; } = null!;
        public string? Image { get; set; }

    }
}
