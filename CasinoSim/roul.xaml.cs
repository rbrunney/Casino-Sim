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
            Random random = new();
            int spin = random.Next(0, 36);
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
