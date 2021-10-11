using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupAssignment2
{
    class DeckOfCards
    {
        const int MaxNrOfCards = 52;
        
        PlayingCard[] cards = new PlayingCard[MaxNrOfCards];

        public PlayingCard this[int idx]
        {
            get
            {
                
                return cards[idx];

            }
        }

        /// <summary>
        /// Number of Cards in the deck
        /// </summary>
        public int Count => cards.Length;

        /// <summary>
        /// Overriden and used by for example Console.WriteLine()
        /// </summary>
        /// <returns>string that represents the complete deck of cards</returns>
        public override string ToString()
        {
            string sRet = "";
            for (int i = 0; i < MaxNrOfCards; i++) 
            {
                sRet += cards[i].ToString() + "\n";
            }
            return sRet;
        }

        /// <summary>
        /// Shuffles the deck of cards
        /// </summary>
        public void Shuffle()
        {
           var rnd = new Random();
          
            
            for (int unSorted = 0; unSorted < cards.Length; unSorted++)
            {
                var tmp = cards[unSorted]; // saves the first element in tmp-variabel and continuie to 52
                var index = rnd.Next(0, unSorted + 1); // Find the index position and add 
                cards[unSorted] = cards[index]; // put in the value in a position 
                cards[index] = tmp; // and put new tmp 

            }
            //rnd is now a random generator - see .NET documentation

            //YOUR CODE
            //to shuffle the deck.
            //Hint: pick two cards in the deck randomly and swap them. Do this 1000 times
        }

        /// <summary>
        /// Initialize a fresh deck consisting of 52 cards
        /// </summary>
        public void FreshDeck()
        {
            int cardNr = 0;
            for (PlayingCardColor color = PlayingCardColor.Clubs; color <=PlayingCardColor.Spades; color ++) //Create a new deck with all color from clubs-spades
            {
                for(PlayingCardValue value = PlayingCardValue.Two; value <= PlayingCardValue.Ace; value++) //Create a new deck with all values from 2 to ace
                {
                    cards[cardNr] = new PlayingCard { Color = color, Value = value }; //Saving the cards in color and value
                    
                    
                    cardNr++; // do this for every card
                }
                
            }

            //YOUR CODE
            //to initialize a fresh deck of cards
        }

        /// <summary>
        /// Removes the top card in the deck and 
        /// </summary>
        /// <returns>The card removed from the deck</returns>
        public PlayingCard GetTopCard()
        {
            //YOUR CODE
            //to return the Top card of the deck and reduce the nr of cards in the deck
            return null;
        }

        public DeckOfCards ()
        {
            FreshDeck(); // put freshDeck here to get the cards

            //YOUR CODE
            //to write a constructor that generates a fresh deck of cards
        }
    }
}
