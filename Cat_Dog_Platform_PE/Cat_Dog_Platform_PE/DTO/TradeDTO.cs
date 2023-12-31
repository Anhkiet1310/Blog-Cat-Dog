﻿using Cat_Dog_Platform_PE.Entity;

namespace Cat_Dog_Platform_PE.DTO
{
    public class TradeDTO
    {
        public string? TradeId { get; set; } = null!;
        public string Content { get; set; } = null!;
        public bool? IsTrade { get; set; }
        public bool? IsSecure { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? AccountId { get; set; }
        public decimal? Price { get; set; }
        public string? Title { get; set; }

        public virtual AccountDTO? Account { get; set; }
        public virtual ICollection<TradeCommentDTO>? TradeComments { get; set; }
    }
}
