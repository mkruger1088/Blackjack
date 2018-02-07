using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cardClass
{
    public class Deck
    {
        private Card[] Cards = new Card[52]; //Represents the cards in the deck
        private bool[] Drawn = new bool[52]; //Represents the drawn cards in the deck
        

        public Deck() //Initializes the deck of cards
        {
            Random rnd = new Random();

            Card[] Cards = new Card[52];
            bool[] Drawn = new bool[52];

            for (int i = 0; i < 52; i++)
            {
                int rankNum = rnd.Next(1, 14);
                int suitNum = rnd.Next(1, 4);
                Cards[i] = new Card();
                Drawn[i] = new bool();
                Cards[i].setRank((Card.rankType)rankNum);
                Cards[i].setSuit((Card.suitType)suitNum);
                Drawn[i] = false;
                switch (Cards[i].getRank())
                {
                    case Card.rankType.Ace:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-A.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-A.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-A.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-A.png");
                                break;
                        }//End Switch-Suit Ace
                        break;
                    case Card.rankType.Two:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-2.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-2.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-2.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-2.png");
                                break;
                        }//End Switch-Suit Two
                        break;
                    case Card.rankType.Three:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-3.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-3.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-3.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-3.png");
                                break;
                        }//End Switch-Suit Three
                        break;
                    case Card.rankType.Four:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-4.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-4.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-4.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-4.png");
                                break;
                        }//End Switch-Suit Four
                        break;
                    case Card.rankType.Five:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-5.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-5.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-5.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-5.png");
                                break;
                        }//End Switch-Suit Five
                        break;
                    case Card.rankType.Six:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-6.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-6.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-6.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-6.png");
                                break;
                        }//End Switch-Suit Six
                        break;
                    case Card.rankType.Seven:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-7.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-7.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-7.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-7.png");
                                break;
                        }//End Switch-Suit Seven
                        break;
                    case Card.rankType.Eight:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-8.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-8.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-8.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-8.png");
                                break;
                        }//End Switch-Suit Eight
                        break;
                    case Card.rankType.Nine:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-9.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-9.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-9.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-9.png");
                                break;
                        }//End Switch-Suit Nine
                        break;
                    case Card.rankType.Ten:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-10.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-10.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-10.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-10.png");
                                break;
                        }//End Switch-Suit Ten
                        break;
                    case Card.rankType.Jack:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-J.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-J.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-J.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-J.png");
                                break;
                        }//End Switch-Suit Jack
                        break;
                    case Card.rankType.Queen:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-Q.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-Q.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-Q.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-Q.png");
                                break;
                        }//End Switch-Suit Queen
                        break;
                    case Card.rankType.King:
                        switch (Cards[i].getSuit())
                        {
                            case Card.suitType.Club:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Club-K.png");
                                break;
                            case Card.suitType.Spade:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Spade-K.png");
                                break;
                            case Card.suitType.Diamond:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Diamond-K.png");
                                break;
                            case Card.suitType.Heart:
                                Cards[i].Pic = CardPics.CardPics.GetBitmapImageResource("CardPics.CardPics.Heart-K.png");
                                break;
                        }//End Switch-Suit King
                        break;

                }//End Switch-Rank
            }//End for-loop
        }

        public void Shuffle() //Sets the Drawn cards to false, or, not drawn
        {
            Random rnd = new Random();

            for (int i = 0; i < 52; i++)
            {
                Drawn[i] = false;
                int rankNum = rnd.Next(1, 14);
                int suitNum = rnd.Next(1, 4);
                Cards[i].setRank((Card.rankType)rankNum);
                Cards[i].setSuit((Card.suitType)suitNum);
            }
        }

        public Card Draw() //Draws a random card
        {
            Random rnd = new Random();
            int num = rnd.Next(52);

            while (Drawn[num] == true)
            {
                num = rnd.Next(52);
            }

            return Cards[num];
        }
    }
}
