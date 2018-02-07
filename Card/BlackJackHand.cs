using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardClass
{
    public class BlackJackHand
    {
        private List<Card> hand = new List<Card>(); //Contains the cards in hand
        public BlackJackHand() //Initializes a hand of cards
        {
            hand = new List<Card>();
        }

        public void Add(Card c)  //Adds a card to the hand of the player
        {
            hand.Add(c);
        }

        public void Clear() //Clears out the hand of the user
        {
            hand.Clear();
        }

        public int Score()  //Calculates the score of the hand
        {
            int total = 0;

            foreach (Card card in hand)
            {
                switch (card.getRank()) //Checks for cards in hand, returns value
                {
                    case Card.rankType.Ace:
                        total += 1;
                        break;
                    case Card.rankType.Two:
                        total += 2;
                        break;
                    case Card.rankType.Three:
                        total += 3;
                        break;
                    case Card.rankType.Four:
                        total += 4;
                        break;
                    case Card.rankType.Five:
                        total += 5;
                        break;
                    case Card.rankType.Six:
                        total += 6;
                        break;
                    case Card.rankType.Seven:
                        total += 7;
                        break;
                    case Card.rankType.Eight:
                        total += 8;
                        break;
                    case Card.rankType.Nine:
                        total += 9;
                        break;
                    case Card.rankType.Ten:
                        total += 10;
                        break;
                    case Card.rankType.Jack:
                        total += 10;
                        break;
                    case Card.rankType.Queen:
                        total += 10;
                        break;
                    case Card.rankType.King:
                        total += 10;
                        break;
                }

            }

            return total;
        }

        public void Show()//Shows the score and the cards on the screen.
        {
            
            foreach (Card card in hand)
            {
                Console.WriteLine(card.ToString());
            }

        }
    }
}
