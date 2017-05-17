using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlackjackAttack.Models
{
    public class Deck
    {
        public Deck() {}

        public List<Card> StandardCards = new List<Card>()
        {
            new Card() { Suit = "Diamond", Rank = "Two", ShortRank = "2", Value = 2 },
            new Card() { Suit = "Diamond", Rank = "Three", ShortRank = "3", Value = 3 },
            new Card() { Suit = "Diamond", Rank = "Four", ShortRank = "4", Value = 4 },
            new Card() { Suit = "Diamond", Rank = "Five", ShortRank = "5", Value = 5 },
            new Card() { Suit = "Diamond", Rank = "Six", ShortRank = "6", Value = 6 },
            new Card() { Suit = "Diamond", Rank = "Seven", ShortRank = "7", Value = 7 },
            new Card() { Suit = "Diamond", Rank = "Eight", ShortRank = "8", Value = 8 },
            new Card() { Suit = "Diamond", Rank = "Nine", ShortRank = "9", Value = 9 },
            new Card() { Suit = "Diamond", Rank = "Ten", ShortRank = "T", Value = 10 },
            new Card() { Suit = "Diamond", Rank = "Jack", ShortRank = "J", Value = 10 },
            new Card() { Suit = "Diamond", Rank = "Queen", ShortRank = "Q", Value = 10 },
            new Card() { Suit = "Diamond", Rank = "King", ShortRank = "K", Value = 10 },
            new Card() { Suit = "Diamond", Rank = "Ace", ShortRank = "A", Value = 11 },
            new Card() { Suit = "Club", Rank = "Two", ShortRank = "2", Value = 2 },
            new Card() { Suit = "Club", Rank = "Three", ShortRank = "3", Value = 3 },
            new Card() { Suit = "Club", Rank = "Four", ShortRank = "4", Value = 4 },
            new Card() { Suit = "Club", Rank = "Five", ShortRank = "5", Value = 5 },
            new Card() { Suit = "Club", Rank = "Six", ShortRank = "6", Value = 6 },
            new Card() { Suit = "Club", Rank = "Seven", ShortRank = "7", Value = 7 },
            new Card() { Suit = "Club", Rank = "Eight", ShortRank = "8", Value = 8 },
            new Card() { Suit = "Club", Rank = "Nine", ShortRank = "9", Value = 9 },
            new Card() { Suit = "Club", Rank = "Ten", ShortRank = "T", Value = 10 },
            new Card() { Suit = "Club", Rank = "Jack", ShortRank = "J", Value = 10 },
            new Card() { Suit = "Club", Rank = "Queen", ShortRank = "Q", Value = 10 },
            new Card() { Suit = "Club", Rank = "King", ShortRank = "K", Value = 10 },
            new Card() { Suit = "Club", Rank = "Ace", ShortRank = "A", Value = 11 },
            new Card() { Suit = "Heart", Rank = "Two", ShortRank = "2", Value = 2 },
            new Card() { Suit = "Heart", Rank = "Three", ShortRank = "3", Value = 3 },
            new Card() { Suit = "Heart", Rank = "Four", ShortRank = "4", Value = 4 },
            new Card() { Suit = "Heart", Rank = "Five", ShortRank = "5", Value = 5 },
            new Card() { Suit = "Heart", Rank = "Six", ShortRank = "6", Value = 6 },
            new Card() { Suit = "Heart", Rank = "Seven", ShortRank = "7", Value = 7 },
            new Card() { Suit = "Heart", Rank = "Eight", ShortRank = "8", Value = 8 },
            new Card() { Suit = "Heart", Rank = "Nine", ShortRank = "9", Value = 9 },
            new Card() { Suit = "Heart", Rank = "Ten", ShortRank = "T", Value = 10 },
            new Card() { Suit = "Heart", Rank = "Jack", ShortRank = "J", Value = 10 },
            new Card() { Suit = "Heart", Rank = "Queen", ShortRank = "Q", Value = 10 },
            new Card() { Suit = "Heart", Rank = "King", ShortRank = "K", Value = 10 },
            new Card() { Suit = "Heart", Rank = "Ace", ShortRank = "A", Value = 11 },
            new Card() { Suit = "Spade", Rank = "Two", ShortRank = "2", Value = 2 },
            new Card() { Suit = "Spade", Rank = "Three", ShortRank = "3", Value = 3 },
            new Card() { Suit = "Spade", Rank = "Four", ShortRank = "4", Value = 4 },
            new Card() { Suit = "Spade", Rank = "Five", ShortRank = "5", Value = 5 },
            new Card() { Suit = "Spade", Rank = "Six", ShortRank = "6", Value = 6 },
            new Card() { Suit = "Spade", Rank = "Seven", ShortRank = "7", Value = 7 },
            new Card() { Suit = "Spade", Rank = "Eight", ShortRank = "8", Value = 8 },
            new Card() { Suit = "Spade", Rank = "Nine", ShortRank = "9", Value = 9 },
            new Card() { Suit = "Spade", Rank = "Ten", ShortRank = "T", Value = 10 },
            new Card() { Suit = "Spade", Rank = "Jack", ShortRank = "J", Value = 10 },
            new Card() { Suit = "Spade", Rank = "Queen", ShortRank = "Q", Value = 10 },
            new Card() { Suit = "Spade", Rank = "King", ShortRank = "K", Value = 10 },
            new Card() { Suit = "Spade", Rank = "Ace", ShortRank = "A", Value = 11 }
        };
    }

}