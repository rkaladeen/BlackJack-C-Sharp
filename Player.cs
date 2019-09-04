using System.Collections.Generic;

namespace BlackJack {
  class Player {
    public string Name;
    public List<Card> Hand {get;} = new List<Card>();
    public Player(string name) {
      this.Name = name;
    }

    public Card draw(Card drawn) {
      Hand.Add(drawn);
      return drawn;
    }

    public Card discard(int ind) {
      Card temp = Hand[ind];
      Hand.Remove(Hand[ind]);
      return temp;
    }

    public List<string> showHand() {
      List<string> currentHand = new List<string>();
      foreach(Card card in Hand) {
        currentHand.Add(card.Show());
      }
      return currentHand;
    }
  }
}