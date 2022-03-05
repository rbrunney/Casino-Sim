﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CasinoSim
{
    /// <summary>
    /// Interaction logic for blackJack.xaml
    /// </summary>
    public partial class blackJack : Window
    {
        int bet = 0;
        bool chip1 = false;
        bool chip5 = false;
        bool chip10 = false;
        bool chip20 = false;
        bool chip50 = false;
        bool chip100 = false;
        bool chip1000 = false;
        bool chip5000 = false;
        
        bool playerWin;
        bool dealerWin;
        bool gameDraw;

        List<bool> chipsList = new List<bool>();

        Deck deck;
        Player player = new Player();
        Player dealer = new Player();
        Image img;

        private PlayerInfo playerInfo;
        public blackJack()
        {
            InitializeComponent();
            dealButton.Visibility = Visibility.Visible;
            hitButton.Visibility = Visibility.Hidden;
            standButton.Visibility = Visibility.Hidden;
            bet = 0;
            chipsList.Add(chip1);
            chipsList.Add(chip5);
            chipsList.Add(chip10);
            chipsList.Add(chip20);
            chipsList.Add(chip100);
            chipsList.Add(chip1000);
            chipsList.Add(chip5000);

            Resources["winLabel"] = "";

            playerInfo = new PlayerInfo();
            lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";


            //foreach (Card card in deck.cards)
            //{
            //    addImageToCard(ref card);
            //}

        }
        public void resetChipsBool()
        {
            for (int i = 0; i < chipsList.Count(); i++)
            {

                chipsList[i] = false;
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Window1().Show();
        }


        //make only click from once user bets
        private void dealButton_Click(object sender, RoutedEventArgs e)
        {
            restart();
            player.hand.Add(deck.drawCard());
            player.hand.Add(deck.drawCard());
            dealer.hand.Add(deck.drawCard());
            dealer.hand.Add(deck.drawCard());
            foreach(Card card in player.hand)
            {
                player.value += card.Value;
            }
            foreach (Card card in dealer.hand)
            {
                dealer.value += card.Value;
            }
            playerImage1.Source = player.hand[0].image.Source;
            playerImage2.Source = player.hand[1].image.Source;
            //img.Source = new BitmapImage(new Uri("files/resources/CasinoAssets/BlackJack/cardBack_blue1.png"));
            //dealerImage1.Source = img.Source;
            dealerImage1.Source = new BitmapImage(new Uri($@"pack://application:,,,/files/resources/CasinoAssets/BlackJack/Cards/cardBack_blue1.png"));
            dealerImage2.Source = dealer.hand[1].image.Source;
        }
        
        public void restart()
        {
            Resources["winLabel"] = "";
            player.hand.Clear();
            dealer.hand.Clear();
            player.value = 0;
            dealer.value = 0;
            
            playerImage1.Source = null;
            playerImage2.Source = null;
            playerImage3.Source = null;
            playerImage4.Source = null;
            playerImage5.Source = null;
            
            dealerImage1.Source = null;
            dealerImage2.Source = null;
            dealerImage3.Source = null;
            dealerImage4.Source = null;
            dealerImage5.Source = null;
            
            
            playerWin = false;
            dealerWin = false;
            gameDraw = false;
            
            deck = new Deck(true);
            dealButton.Visibility = Visibility.Hidden;
            hitButton.Visibility = Visibility.Visible;
            standButton.Visibility = Visibility.Visible;
        }

        private void rulesButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello - Rules");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip1 = true;
            bet = 1;

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip5 = true;
            bet = 5;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip10 = true;
            bet = 10;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip20 = true;
            bet = 20;
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip50 = true;
            bet = 50;
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip100 = true;
            bet = 100;
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip1000 = true;
            bet = 1000;
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip5000 = true;
            bet = 5000;
        }
        private void standButton_Click(object sender, RoutedEventArgs e)
        {
            while(dealer.value < 16)
            {
                dealer.hand.Add(deck.drawCard());
                dealer.value = 0;
                foreach (Card card in dealer.hand)
                {
                    dealer.value += card.Value;
                }
                if (dealer.hand.Count == 3)
                {
                    dealerImage3.Source = dealer.hand[2].image.Source;
                }

                if (dealer.hand.Count == 4)
                {
                    dealerImage4.Source = dealer.hand[3].image.Source;
                }

                if (dealer.hand.Count == 5)
                {
                    dealerImage5.Source = dealer.hand[4].image.Source;
                    checkWin();
                }
            }
            checkWin();
        }
        private void hitButton_Click(object sender, RoutedEventArgs e)
        {
            player.value = 0;
            player.hand.Add(deck.drawCard());
            foreach (Card card in player.hand)
            {
                player.value += card.Value;
            }
            if (player.hand.Count == 3)
            {
                playerImage3.Source = player.hand[2].image.Source;
            }

            if (player.hand.Count == 4)
            {
                playerImage4.Source = player.hand[3].image.Source;
            }

            if (player.hand.Count == 5)
            {
                playerImage5.Source = player.hand[4].image.Source;
                checkWin();
            }
            if(player.value >= 21)
            {
                checkWin();
            }
        }

        public void checkWin()
        {
            dealerImage1.Source = dealer.hand[0].image.Source;
            if (player.value == 21)
            {
                playerWin = true;
            }
            else if (player.value > dealer.value && player.value < 21)
            {
                playerWin = true;
            }
            else if (player.value > 21)
            {
                dealerWin = true;
            }
            else if (dealer.value == 21)
            {
                dealerWin = true;
            }
            else if (dealer.value > player.value && dealer.value < 21)
            {
                dealerWin = true;
            }
            else if (dealer.value > 21)
            {
                playerWin = true;
            }
            else if (dealer.value == player.value)
            {
                gameDraw = true;
            }
            else if (dealer.hand.Count == 5)
            {
                playerWin = true;
            }
            else if (player.hand.Count == 5)
            {
                dealerWin = true;
            }
            
            //MessageBox.Show($"Player BlackJack: {playerBlackJack} \n" +
            //    $"Player Win: {playerWin} \n" +
            //    $"Player Bust: {playerBust} \n" +
            //    $"Dealer BlackJack: {dealerBlackJack} \n" +
            //    $"Dealer Win: {dealerWin} \n" +
            //    $"Dealer Bust: {dealerBust} \n" +
            //    $"Player5Cards: {player5Cards} \n" +
            //    $"Dealer5Cards: {dealer5Cards} \n" +
            //    $"Player: {player.value} : {player.handToString()} \n " +
            //    $"Dealer: {dealer.value} : {dealer.handToString()} \n");
            if (playerWin)
            {
                Resources["winLabel"] = $"Player Wins! \n PlayerHand: {player.value} -- DealerHand: {dealer.value}";
            }

            if (dealerWin)
            {
                Resources["winLabel"] = $"Dealer Wins! \n PlayerHand: {player.value} -- DealerHand: {dealer.value}";
            }

            if (gameDraw)
            {
                Resources["winLabel"] = $"Draw! \n PlayerHand: {player.value} -- DealerHand: {dealer.value}";
            }
            dealButton.Visibility = Visibility.Visible;
            hitButton.Visibility = Visibility.Hidden;
            standButton.Visibility = Visibility.Hidden;
        }
    }

    public class Deck
    {
        public bool isBlackJack = false;
        public List<Card> cards = new List<Card>();
        public Deck(bool isBlackJack)
        {
            this.isBlackJack = isBlackJack;
            List<String> suits = new List<String>();
            suits.Add("H");
            suits.Add("C");
            suits.Add("D");
            suits.Add("S");
            List<int> values = new List<int>();
            values.Add(1);
            values.Add(2);
            values.Add(3);
            values.Add(4);
            values.Add(5);
            values.Add(6);
            values.Add(7);
            values.Add(8);
            values.Add(9);
            values.Add(10);
            values.Add(11);
            values.Add(12);
            values.Add(13);
            if(isBlackJack)
            {
                foreach (String suit in suits)
                {
                    foreach (int value in values)
                    {
                        Card card = new Card();
                        card.Suit = suit;
                        card.Value = value;
                        if (card.Value == 1)
                        {
                            card.Name = "A" + suit;
                        }
                        else if (card.Value == 11)
                        {
                            card.Name = "J" + suit;
                            card.Value = 10;
                        }
                        else if (card.Value == 12)
                        {
                            card.Name = "Q" + suit;
                            card.Value = 10;
                        }
                        else if (card.Value == 13)
                        {
                            card.Name = "K" + suit;
                            card.Value = 10;
                        }
                        else
                        {
                            card.Name = value + suit;
                        }
                        cards.Add(card);
                    }
                }
            }
            else
            {
                foreach (String suit in suits)
                {
                    foreach (int value in values)
                    {
                        Card card = new Card();
                        card.Suit = suit;
                        card.Value = value;
                        if (card.Value == 1)
                        {
                            card.Name = "A" + suit;
                        }
                        else if (card.Value == 11)
                        {
                            card.Name = "J" + suit;
                        }
                        else if (card.Value == 12)
                        {
                            card.Name = "Q" + suit;
                        }
                        else if (card.Value == 13)
                        {
                            card.Name = "K" + suit;
                        }
                        else
                        {
                            card.Name = value + suit;
                        }

                        cards.Add(card);
                    }
                }
            }
            
        }

        public Card drawCard()
        {
            Random rand = new Random();
            Card card = cards[rand.Next(cards.Count())];
            addImageToCard(ref card);
            cards.Remove(card);
            return card;
        }

        public void addImageToCard(ref Card card)
        {
            card.image.Source = new BitmapImage(new Uri($@"pack://application:,,,/files/resources/CasinoAssets/BlackJack/Cards/{card.Name}.png"));
            card.image.Height = 65;
            card.image.Width = 46;
        }
    }

    public class Card
    {
        public string Name { get; set; }
        public int Value { get; set; }
        public string Suit { get; set; }
        //To be done later when we have image resources
        //Image image;
        public Image image = new Image();

        public override string ToString()
        {
            return $"{Name}, {Value}, and {Suit} :: ";
        }
    }

    public class Player
    {
        public List<Card> hand = new List<Card>();
        public int value = 0;

        public string handToString()
        {
            string cards = "";
            foreach (Card card in hand)
            {
                cards += $"{card.Name} ";
            }
            return cards;
        }
    }
}
