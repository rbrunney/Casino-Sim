using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for roul.xaml
    /// </summary>
    public partial class roul : Window
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

        PlayerInfo playerInfo;

        List<bool> chipsList = new List<bool>();
        public roul()
        {
            InitializeComponent();
            addButtons();
            
            playerInfo = new PlayerInfo();
            lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
        }

        List<Button> buttonList = new();

        private void addButtons()
        {
            buttonList.Add(one);
            buttonList.Add(two);
            buttonList.Add(three);
            buttonList.Add(four);
            buttonList.Add(five);
            buttonList.Add(six);
            buttonList.Add(seven);
            buttonList.Add(eight);
            buttonList.Add(nine);
            buttonList.Add(ten);
            buttonList.Add(eleven);
            buttonList.Add(twelve);
            buttonList.Add(thirteen);
            buttonList.Add(fourteen);
            buttonList.Add(fifteen);
            buttonList.Add(sixteen);
            buttonList.Add(seventeen);
            buttonList.Add(eighteen);
            buttonList.Add(nineteen);
            buttonList.Add(twenty);
            buttonList.Add(twentyOne);
            buttonList.Add(twentyTwo);
            buttonList.Add(twentyThree);
            buttonList.Add(twentyFour);
            buttonList.Add(twentyFive);
            buttonList.Add(twentySix);
            buttonList.Add(twentySeven);
            buttonList.Add(twentyEight);
            buttonList.Add(twentyNine);
            buttonList.Add(thirty);
            buttonList.Add(thirtyOne);
            buttonList.Add(thirtyTwo);
            buttonList.Add(thirtyThree);
            buttonList.Add(thirtyFour);
            buttonList.Add(thirtyFive);
            buttonList.Add(thirtySix);
            buttonList.Add(left12);
            buttonList.Add(middle12);
            buttonList.Add(right12);
            buttonList.Add(firstEighteen);
            buttonList.Add(red);
            buttonList.Add(even);
            buttonList.Add(odd);
            buttonList.Add(black);
            buttonList.Add(lastEigheen);
            buttonList.Add(top);
            buttonList.Add(middle);
            buttonList.Add(bottom);
            buttonList.Add(zero);
            buttonList.Add(zero2);
            buttonList.Add(zero3);
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            File.WriteAllText("playerInfo.txt", $"{playerInfo.BankAmount}:{playerInfo.ChipAmount}");
            this.Hide();
            new Window1().Show();

        }
        public void resetChipsBool()
        {
            for (int i = 0; i < chipsList.Count(); i++)
            {

                chipsList[i] = false;
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip1 = true;
            bet = 1;
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip5 = true;
            bet = 5;
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip10 = true;
            bet = 10;
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip20 = true;
            bet = 20;
        }

        private void Button_Click4(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip50 = true;
            bet = 50;
        }

        private void Button_Click5(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip100 = true;
            bet = 100;
        }

        private void Button_Click6(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip1000 = true;
            bet = 1000;
        }

        private void Button_Click7(object sender, RoutedEventArgs e)
        {
            resetChipsBool();
            chip5000 = true;
            bet = 5000;
        }

        private void Spin(object sender, RoutedEventArgs e)
        {
            int winnings = 0;
            Random random = new();
            int spin = random.Next(0, 36);

            //just numbers
            switch(spin)
            {
                case 0:
                    for(int i = 0; i < Zero.Count; i++)
                    {
                        winnings += Zero.ElementAt(i);
                    }
                    Zero.Clear();
                    break;
                case 1:
                    for(int i = 0; i < One.Count; i++)
                    {
                        winnings += One.ElementAt(i);
                    }
                    One.Clear();
                    break;
                case 2:
                    for(int i = 0; i < Two.Count; i++)
                    {
                        winnings += Two.ElementAt(i);
                    }
                    Two.Clear();
                    break;
                case 3:
                    for(int i = 0; i < Three.Count; i++)
                    {
                        winnings += Three.ElementAt(i);
                    }
                    Three.Clear();
                    break;
                case 4:
                    for(int i = 0; i < Four.Count; i++)
                    {
                        winnings += Four.ElementAt(i);
                    }
                    Four.Clear();
                    break;
                case 5:
                    for(int i = 0; i < Five.Count; i++)
                    {
                        winnings += Five.ElementAt(i);
                    }
                    Five.Clear();
                    break;
                case 6:
                    for(int i = 0; i < Six.Count; i++)
                    {
                        winnings += Six.ElementAt(i);
                    }
                    Six.Clear();
                    break;
                case 7:
                    for(int i = 0; i < Seven.Count; i++)
                    {
                        winnings += Seven[i];
                    }
                    Seven.Clear();
                    break;
                case 8:
                    for(int i = 0; i < Eight.Count; i++)
                    {
                        winnings += Eight[i];
                    }
                    Eight.Clear();
                    break;
                case 9:
                    for(int i = 0; i < Nine.Count; i++)
                    {
                        winnings += Nine[i];
                    }
                    Nine.Clear();
                    break;
                case 10:
                    for(int i = 0; i < Ten.Count; i++)
                    {
                        winnings += Ten[i];
                    }
                    Ten.Clear();
                    break;
                case 11:
                    for(int i = 0; i < Eleven.Count; i++)
                    {
                        winnings += Eleven[i];
                    }
                    Eleven.Clear();
                    break;
                case 12:
                    for(int i = 0; i < Twelve.Count; i++)
                    {
                        winnings += Twelve[i];
                    }
                    Twelve.Clear();
                    break;
                case 13:
                    for(int i = 0; i < Thirteen.Count; i++)
                    {
                        winnings += Thirteen[i];
                    }
                    Thirteen.Clear();
                    break;
                case 14:
                    for(int i = 0; i < Fourteen.Count; i++)
                    {
                        winnings += Fourteen[i];
                    }
                    Fourteen.Clear();
                    break;
                case 15:
                    for(int i = 0; i < Fifteen.Count; i++)
                    {
                        winnings += Fifteen[i];
                    }
                    Fifteen.Clear();
                    break;
                case 16:
                    foreach(int value in Sixteen)
                    {
                        winnings += value;
                    }
                    Sixteen.Clear();
                    break;
                case 17:
                    foreach(int value in Seventeen)
                    {
                        winnings += value;
                    }
                    Seventeen.Clear();
                    break;
                case 18:
                    foreach(int value in Eighteen)
                    {
                        winnings += value;
                    }
                    Eighteen.Clear();
                    break;
                case 19:
                    foreach(int value in Nineteen)
                    {
                        winnings += value;
                    }
                    Nineteen.Clear();
                    break;
                case 20:
                    foreach(int value in Twenty)
                    {
                        winnings += value;
                    }
                    Twenty.Clear();
                    break;
                case 21:
                    foreach(int value in Twentyone)
                    {
                        winnings += value;
                    }
                    Twentyone.Clear();
                    break;
                case 22:
                    foreach(int value in Twentytwo)
                    {
                        winnings += value;
                    }
                    Twentytwo.Clear();
                    break;
                case 23:
                    foreach(int value in Twentythree)
                    {
                        winnings += value;
                    }
                    Twentythree.Clear();
                    break;
                case 24:
                    foreach(int value in Twentyfour)
                    {
                        winnings += value;
                    }
                    Twentyfour.Clear();
                    break;
                case 25:
                    foreach(int value in Twentyfive)
                    {
                        winnings += value;
                    }
                    Twentyfive.Clear();
                    break;
                case 26:
                    foreach(int value in Twentysix)
                    {
                        winnings += value;
                    }
                    Twentysix.Clear();
                    break;
                case 27:
                    foreach(int value in Twentyseven)
                    {
                        winnings += value;
                    }
                    Twentyseven.Clear();
                    break;
                case 28:
                    foreach(int value in Twentyeight)
                    {
                        winnings += value;
                    }
                    Twentyeight.Clear();
                    break;
                case 29:
                    foreach(int value in Twentynine)
                    {
                        winnings += value;
                    }Twentynine.Clear();
                    break;
                case 30:
                    foreach(int value in Thirty)
                    {
                        winnings += value;
                    }
                    Thirty.Clear();
                    break;
                case 31:
                    foreach(int value in Thirtyone)
                    {
                        winnings += value;
                    }
                    Thirtyone.Clear();
                    break;
                case 32:
                    foreach(int value in Thirtytwo)
                    {
                        winnings += value;
                    }
                    Thirtytwo.Clear();
                    break;
                case 33:
                    foreach(int value in Thirtythree)
                    {
                        winnings += value;
                    }
                    Thirtythree.Clear();
                    break;
                case 34:
                    foreach(int value in Thirtyfour)
                    {
                        winnings += value;
                    }
                    Thirtyfour.Clear();
                    break;
                case 35:
                    foreach(int value in Thirtyfive)
                    {
                        winnings += value;
                    }
                    Thirtyfive.Clear();
                    break;
                case 36:
                    foreach(int value  in Thirtysix)
                    {
                        winnings += value;
                    }
                    Thirtysix.Clear();
                    break;
                default:
                    break;
            }
            
            //red and black
            switch(spin)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 12:
                case 14:
                case 16:
                case 18:
                case 19:
                case 21:
                case 23:
                case 27:
                case 25:
                case 30:
                case 32:
                case 34:
                case 36:
                    foreach(int value in RedAll)
                    {
                        winnings += value;
                    }
                    RedAll.Clear();
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                case 11:
                case 13:
                case 15:
                case 17:
                case 20:
                case 24:
                case 22:
                case 26:
                case 28:
                case 29:
                case 31:
                case 33:
                case 35:
                    foreach(int value in BlackAll)
                    {
                        winnings += value;
                    }
                    BlackAll.Clear();
                    break;
                default:
                    break;
            }

            //even/odd
            switch(spin)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 9:
                case 11:
                case 13:
                case 15:
                case 17:
                case 19:
                case 21:
                case 23:
                case 25:
                case 27:
                case 29:
                case 31:
                case 33:
                case 35:
                    foreach(int value in Odd)
                    {
                        winnings += value;
                    }
                    Odd.Clear();
                    break;
                case 2:
                case 4:
                case 6:
                case 8:
                case 10:
                case 12:
                case 14:
                case 16:
                case 18:
                case 20:
                case 22:
                case 24:
                case 26:
                case 28:
                case 30:
                case 32:
                case 34:
                case 36:
                    foreach(int value in Even)
                    {
                        winnings += value;
                    }
                    Even.Clear();
                    break;
                default:
                    break;
            }
        
            //first 18/ last 18
            switch(spin)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                    foreach(int value in First)
                    {
                        winnings += value;
                    }
                    First.Clear();
                    break;
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                    foreach(int value in Last)
                    {
                        winnings += value;
                    }
                    Last.Clear();
            }

            //Columns
            switch(spin)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                case 7:
                case 8:
                case 9:
                case 10:
                case 11:
                case 12:
                    foreach(int value in Left12)
                    {
                        winnings += value;
                    }
                    Left12.Clear();
                    break;
                case 13:
                case 14:
                case 15:
                case 16:
                case 17:
                case 18:
                case 19:
                case 20:
                case 21:
                case 22:
                case 23:
                case 24:
                    foreach(int value in Middle12)
                    {
                        winnings += value;
                    }
                    Middle.Clear();
                    break;
                case 25:
                case 26:
                case 27:
                case 28:
                case 29:
                case 30:
                case 31:
                case 32:
                case 33:
                case 34:
                case 35:
                case 36:
                    foreach(int value in Right12)
                    {
                        winnings += value;
                    }
                    Right12.Clear();
                    break;
                default:
                    break;
            }

            //rows
            switch(spin)
            {
                case 3:
                case 6:
                case 9:
                case 12:
                case 15:
                case 18:
                case 21:
                case 24:
                case 27:
                case 30:
                case 33:
                case 36:
                    foreach(int value in Top)
                    {
                        winnings += value;
                    }
                    Top.Clear();
                    break;
                case 2:
                case 5:
                case 8:
                case 11:
                case 14:
                case 17:
                case 20:
                case 23:
                case 26:
                case 29:
                case 32:
                case 35:
                    foreach(int value in Middle)
                    {
                        winnings += value;
                    }
                    Middle.Clear();
                    break;
                case 1:
                case 4:
                case 7:
                case 10:
                case 13:
                case 16:
                case 19:
                case 22:
                case 25:
                case 28:
                case 31:
                case 34:
                    foreach(int value in Bottom)
                    {
                        winnings += value;
                    }
                    Bottom.Clear();
                    break;
                default:
                    break;
            }

        }

        private void Bet(object sender, RoutedEventArgs e)
        {
            for(int i = 0; i < buttonList.Count; i++)
            {
                if(buttonList[i].Equals((Button)sender))
                {
                    switch(i)
                    {
                        case 0:
                            One.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 1:
                            Two.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 2:
                            Three.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 3:
                            Four.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 4:
                            Five.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 5:
                            Six.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 6:
                            Seven.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 7:
                            Eight.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 8:
                            Nine.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 9:
                            Ten.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 10:
                            Eleven.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 11:
                            Twelve.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 12:
                            Thirteen.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 13:
                            Fourteen.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 14:
                            Fifteen.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 15:
                            Sixteen.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 16:
                            Seventeen.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 17:
                            Eighteen.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 18:
                            Nineteen.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 19:
                            Twenty.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 20:
                            Twentyone.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 21:
                            Twentytwo.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 22:
                            Twentythree.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 23:
                            Twentyfour.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 24:
                            Twentyfive.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 25:
                            Twentysix.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 26:
                            Twentyseven.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 27:
                            Twentyeight.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 28:
                            Twentynine.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 29:
                            Thirty.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 30:
                            Thirtyone.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 31:
                            Thirtytwo.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 32:
                            Thirtythree.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 33:
                            Thirtyfour.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 34:
                            Thirtyfive.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 35:
                            Thirtysix.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 36:
                            Left12.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 37:
                            Middle12.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 38:
                            Right12.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 39:
                            First.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 40:
                            RedAll.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 41:
                            Even.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 42:
                            Odd.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 43:
                            BlackAll.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 44:
                            Last.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 45:
                            Top.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 46:
                            Middle.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 47:
                            Bottom.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 48:
                            Zero.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 49:
                            Zero.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        case 50:
                            Zero.Add(bet);
                            if (playerInfo.ChipAmount < bet)
                            {
                                MessageBox.Show("Hey! you don't have enough chips for this bet, get more money from the bank!");
                            }
                            else
                            {
                                playerInfo.ChipAmount -= bet;
                                lblPlayerChips.Content = $"Chips: ${playerInfo.ChipAmount}";
                            }
                            break;
                        default:
                            Console.WriteLine("I hate my life");
                            break;
                    }
                }
            }
        }

        private Dictionary<string, Dictionary<string, List<int>>> Bets = new();
        private Dictionary<string, List<int>> Black = new();
        private Dictionary<string, List<int>> Red = new();
        private Dictionary<string, List<int>> Green = new();
        private Dictionary<string, List<int>> Special = new();

        List<int> Zero = new();
        List<int> One = new();
        List<int> Two = new();
        List<int> Three = new();
        List<int> Four = new();
        List<int> Five = new();
        List<int> Six = new();
        List<int> Seven = new();
        List<int> Eight = new();
        List<int> Nine = new();
        List<int> Ten = new();
        List<int> Eleven = new();
        List<int> Twelve = new();
        List<int> Thirteen = new();
        List<int> Fourteen = new();
        List<int> Fifteen = new();
        List<int> Sixteen = new();
        List<int> Seventeen = new();
        List<int> Eighteen = new();
        List<int> Nineteen = new();
        List<int> Twenty = new();
        List<int> Twentyone = new();
        List<int> Twentytwo = new();
        List<int> Twentythree = new();
        List<int> Twentyfour = new();
        List<int> Twentyfive = new();
        List<int> Twentysix = new();
        List<int> Twentyseven = new();
        List<int> Twentyeight = new();
        List<int> Twentynine = new();
        List<int> Thirty = new();
        List<int> Thirtyone = new();
        List<int> Thirtytwo = new();
        List<int> Thirtythree = new();
        List<int> Thirtyfour = new();
        List<int> Thirtyfive = new();
        List<int> Thirtysix = new();



        List<int> Top = new();
        List<int> Middle = new();
        List<int> Bottom = new();
        List<int> Left12 = new();
        List<int> Middle12 = new();
        List<int> Right12 = new();
        List<int> Even = new();
        List<int> Odd = new();
        List<int> RedAll = new();
        List<int> BlackAll = new();
        List<int> First = new();
        List<int> Last = new();




        private void GenerateBets()
        {
            Bets.Add("Green", Green);
            Bets.Add("Black", Black);
            Bets.Add("Red", Red);

            Green.Add("zero", Zero);

            Black.Add("two", Two);
            Black.Add("six", Six);
            Black.Add("four", Four);
            Black.Add("eight", Eight);
            Black.Add("ten", Ten);
            Black.Add("eleven", Eleven);
            Black.Add("thirteen", Thirteen);
            Black.Add("fifteen", Fifteen);
            Black.Add("seventeen", Seventeen);
            Black.Add("twenty", Twenty);
            Black.Add("twenty two", Twentytwo);
            Black.Add("twenty four", Twentyfour);
            Black.Add("twenty six", Twentysix);
            Black.Add("twenty eight", Twentyeight);
            Black.Add("twenty nine", Twentynine);
            Black.Add("thirty one", Thirtyone);
            Black.Add("thirty three", Thirtythree);
            Black.Add("thirty five", Thirtyfive);

            Red.Add("one", One);
            Red.Add("three", Three);
            Red.Add("five", Five);
            Red.Add("seven", Seven);
            Red.Add("nine", Nine);
            Red.Add("twelve", Twelve);
            Red.Add("fourteen", Fourteen);
            Red.Add("sixteen", Sixteen);
            Red.Add("eighteen", Eighteen);
            Red.Add("nineteen", Nineteen);
            Red.Add("twenty one", Twentyone);
            Red.Add("twenty three", Twentythree);
            Red.Add("twenty five", Twentyfive);
            Red.Add("twenty seven", Twentyseven);
            Red.Add("thirty", Thirty);
            Red.Add("thirty two", Thirtytwo);
            Red.Add("thirty four", Thirtyfour);
            Red.Add("thirty six", Thirtysix);

            Special.Add("top row", Top);
            Special.Add("middle row",Middle);
            Special.Add("bottom row", Bottom);
            Special.Add("left column", Left12);
            Special.Add("middle column", Middle12);
            Special.Add("right column", Right12);
            Special.Add("even", Even);
            Special.Add("odd", Odd);
            Special.Add("red", RedAll);
            Special.Add("black", BlackAll);
            Special.Add("first 18", First);
            Special.Add("last 18", Last);
        }
    }
}
