using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackjackAttack.Models
{
    public class Table
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Key { get; set; }
        public string Name { get; set; }
        public decimal MinimumBet { get; set; }
        public decimal MaximumBet { get; set; }
        public int DecksInShoe { get; set; }
        public int DecksToPlay { get; set; }

        public Guid CurrentShoeId { get; set; }
        public virtual Shoe CurrentShoe { get; set; }

        public Guid DealerId { get; set; }
        public virtual Dealer Dealer { get; set; }

        //public virtual List<Player> Players { get; set; }
    }
}