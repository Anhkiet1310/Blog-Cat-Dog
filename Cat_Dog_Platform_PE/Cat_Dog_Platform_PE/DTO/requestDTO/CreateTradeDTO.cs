﻿namespace Cat_Dog_Platform_PE.DTO.requestDTO
{
    public class CreateTradeDTO
    {
        public string Content { get; set; } = null!;
        public string? AccountId { get; set; }
        public decimal? Price { get; set; }
        public string? Title { get; set; }
    }
}
