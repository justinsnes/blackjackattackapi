using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackjackAttack.Models
{
    public class Card
    {
        public Card() { }
        
        // EF7 does not support complex types so we need to actually create a table representing cards.
        [Key]
        public Guid CardId { get; set; }
        public string Suit { set; get; }
        public string Rank { get;set; }
        public string ShortRank { get; set; }
        public int Value { set; get; }
    }
}