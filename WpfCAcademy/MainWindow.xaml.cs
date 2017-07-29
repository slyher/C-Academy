using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using WpfCAcademy.Model.BridgeDeck;
using WpfCAcademy.Model.cards;

namespace WpfCAcademy
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BridgeDeck Deck;
        Boolean EnableAdvancedShuffle = false;
        public MainWindow()
        {
            InitializeComponent();
            Deck = new BridgeDeck();
        }

        private void shuffle_Click(object sender, RoutedEventArgs e)
        {
            var players = 4;
            var cardsPerPlayer = 13;
            Deck.Clear();
            Deck.createDefaultDeck();
            if (EnableAdvancedShuffle)
            {
                Deck.shuffleAlternative();
            }
            else
            {
                Deck.shuffle();
            }
            Deck.AddHands(Deck.deal(players, cardsPerPlayer));
            southText.Text = Deck.ConverToString(Deck.Hands.ElementAt(0));
            westText.Text  = Deck.ConverToString(Deck.Hands.ElementAt(1));
            northText.Text = Deck.ConverToString(Deck.Hands.ElementAt(2));
            eastText.Text  = Deck.ConverToString(Deck.Hands.ElementAt(3));
        }

        private void advanceShuffle_Checked(object sender, RoutedEventArgs e)
        {
            this.EnableAdvancedShuffle = !this.EnableAdvancedShuffle;
        }
    }
}
