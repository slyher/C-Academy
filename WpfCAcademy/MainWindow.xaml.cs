using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using WpfCAcademy.Model.cards;

namespace WpfCAcademy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        cards Deck;
        public MainWindow()
        {
            InitializeComponent();
            this.Deck = new cards();
        }

        private void shuffle_Click(object sender, RoutedEventArgs e)
        {
            var players = 4;
            var cardsPerPlayer = 13;
            Dictionary<int, List<card>> data = new Dictionary<int, List<card>>();
            Deck.Clear();
            this.Deck.createDefaultDeck();
            this.Deck.shuffle();
            data = this.Deck.deal(players, cardsPerPlayer);
            southText.Text = this.Deck.ConverToString(data.ElementAt(0).Value);
            westText.Text  = this.Deck.ConverToString(data.ElementAt(1).Value);
            northText.Text = this.Deck.ConverToString(data.ElementAt(2).Value);
            eastText.Text  = this.Deck.ConverToString(data.ElementAt(3).Value);
        }

        
    }
}
