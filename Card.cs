namespace BlackJack {
  class Card {
    public string suit;
    public string value;
    public Card(string s, string v) {
      this.suit = s;
      this.value = v;
    }

    public string Show() {
      string card = $"{this.value} of {this.suit}";     
      return card;
    }
  }
}