using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackjackAttack.Models
{
    public class Shoe
    {
        public Shoe() { }
        public Shoe(int numOfDecks)
        {
            NumberOfDecks = numOfDecks;
            Cards = new List<Card>();
            SetupShoe();
        }
        
        // EF7 does not support complex types so we need to actually create a table representing shoes in game.
        [Key]
        public Guid ShoeId { get; set; }
        public int NumberOfDecks { get; set; }
        public virtual List<Card> Cards { get; set; }

        
        public void SetupShoe()
        {
            Cards.Clear();
            
            for (var i = 0; i < NumberOfDecks; i++)
            {
                var deck = new Deck();
                Cards.AddRange(deck.StandardCards);
            }

            Shuffle();
        }

        // Fisher-Yates shuffle
        private void Shuffle()
        {
            Random rng = new Random();

            int n = Cards.Count;  
            while (n > 1) {  
                n--;  
                int k = rng.Next(n + 1);  
                Card value = Cards[k];  
                Cards[k] = Cards[n];  
                Cards[n] = value;  
            }  
        }

    }
}