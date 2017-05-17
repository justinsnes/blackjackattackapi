using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackjackAttack.Models
{
    public class Dealer
    {
        public Dealer() { }
        
        [Key]
        public Guid DealerId { get; set; }
        public List<Card> Hand { get; set; }
    }
}