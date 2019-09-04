using System;
using System.Collections.Generic;

namespace BlackJack {
  class Deck {
    public List<Card> cards = new List<Card>();

    public Deck() {
      this.reset();
      
    }

    public Card deal() {
      Card temp = cards[0];
      cards.Remove(cards[0]);
      return temp;
    }

    public void shuffle() {
      Random rand = new Random();
      int deckSize = cards.Count;

      while (deckSize > 1) {  
        deckSize --;  
        int ran = rand.Next(deckSize + 1);  
        Card temp = cards[ran];  
        cards[ran] = cards[deckSize];  
        cards[deckSize] = temp;  
      }  
    }

    public void reset() {
      cards = new List<Card>();
      List<string> values = new List<string>(){"A","2","3","4","5","6","7","8","9","10","Jack","Queen","King"};
      List<string> suits = new List<string>(){"Hearts","Diamonds","Spades","Clubs"};
      int deckSize = 0;

      for(int i = 0; i < suits.Count; i++) {
        for(int j = 0; j < values.Count; j++) {
          if(deckSize != 52) {
            this.cards.Add(new Card(suits[i], values[j]));
          }
          deckSize ++;
        }
      }
    }
  }
}