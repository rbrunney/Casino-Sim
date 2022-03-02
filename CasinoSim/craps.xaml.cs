using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace CasinoSim
{
    /// <summary>
    /// Interaction logic for craps.xaml
    /// </summary>
    /// 

    //compares two bitmap images and returns true or false
    public static class BitmapImageExtensions
    {
        public static bool IsEqual(this BitmapImage image1, BitmapImage image2)
        {
            if (image1 == null || image2 == null)
            {
                return false;
            }
            return image1.ToBytes().SequenceEqual(image2.ToBytes());
        }

        public static byte[] ToBytes(this BitmapImage image)
        {
            byte[] data = new byte[] { };
            if (image != null)
            {
                try
                {
                    var encoder = new BmpBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(image));
                    using (MemoryStream ms = new MemoryStream())
                    {
                        encoder.Save(ms);
                        data = ms.ToArray();
                    }
                    return data;
                }
                catch (Exception ex)
                {
                }
            }
            return data;
        }
    }
    public partial class Craps : Window
    {
        public Craps()
        {
            InitializeComponent();
            insertLists();
        }
        public int point = 0;
        //goes back to game selection
        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            new Window1().Show();
        }

        //returns the entire BitmapImage array of dice images
        private BitmapImage[] getDiceList()
        {
            BitmapImage[] imageList = new BitmapImage[6];
            imageList[0] = addImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Craps/Dice1.png"));
            imageList[1] = addImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Craps/Dice2.png"));
            imageList[2] = addImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Craps/Dice3.png"));
            imageList[3] = addImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Craps/Dice4.png"));
            imageList[4] = addImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Craps/Dice5.png"));
            imageList[5] = addImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Craps/Dice6.png"));

            return imageList;
        }
        

        private List<Button> getSingleRollBets()
        {
            List<Button> betList = new List<Button>();
            betList.Add(btnSingleCraps);
            betList.Add(btnTwoSingleRoll);
            betList.Add(btnThreeSingleRoll);
            betList.Add(btnSingleRollSeven);
            betList.Add(btnElevenSingleRoll);
            betList.Add(btnTwelveSingleRoll);
            betList.Add(btnHardwayFour7to1);
            betList.Add(btnHardwaySix9to1);
            betList.Add(btnHardwayeight9to1);
            betList.Add(btnHardwayten7to1);
            betList.Add(btnField);
            
            return betList;
        }

        private List<Grid> getSingleRollBetGrids() 
        {
            List<Grid> gridList = new List<Grid>();
            gridList.Add(btnSingleRollThreeChips);
            gridList.Add(btnSingleRollTwoChips);
            gridList.Add(btnSingleRollElevenChips);
            gridList.Add(btnSingleRollTwelveChips);
            gridList.Add(btnSingleRollSevenChips);
            gridList.Add(btnSingleCrapsChips);
            gridList.Add(btnSingleRollElevenChips);
            gridList.Add(btnHardwayFourChips);
            gridList.Add(btnHardwayEightChips);
            gridList.Add(btnHardwaySixChips);
            gridList.Add(btnHardwayTenChips);
            gridList.Add(btnFieldChips);

            return gridList;
        }

        private List<Grid> getMultiRollBetGrids()
        {
            List<Grid> gridList = new List<Grid>();

            gridList.Add(btnMultiRollFourChips);
            gridList.Add(btnMultiRollFiveChips);
            gridList.Add(btnMultiRollSixChips);
            gridList.Add(btnMultiRollEightChips);
            gridList.Add(btnMultiRollNineChips);
            gridList.Add(btnMultiRollTenChips);
            gridList.Add(btnDontPassLineChips);
            gridList.Add(btnPassLineChips);

            return gridList;
        }

        private List<Button> getMultiRollBets()
        {
            List<Button> betList = new List<Button>();
            betList.Add(btnDontPassBar);
            betList.Add(btnPassLine);
            betList.Add(btnMultiRollFour);
            betList.Add(btnMultiRollFive);
            betList.Add(btnMultiRollSix);
            betList.Add(btnMultiRollEight);
            betList.Add(btnMultiRollNine);
            betList.Add(btnMultiRollTen);

            return betList;
        }
        //returns the value of both dice images displayed on the screen after the dice roll
        private int getValueRoll(Image dice, Image dice2)
        {
            int val1 = 0, val2 = 0;
            int value = 0;
            BitmapImage[] list = { (BitmapImage)dice.Source, (BitmapImage)dice2.Source };

            for (int i = 0; i < list.Length; i++)
            {
                for (int j = 0; j < getDiceList().Length; j++)
                {
                    switch (j)
                    {
                        case 0:
                            if (i == 0)
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val1 = j + 1;
                                }
                            }
                            else
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val2 = j + 1;
                                }
                            }
                            break;
                        case 1:
                            if (i == 0)
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val1 = j + 1;
                                }
                            }
                            else
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val2 = j + 1;
                                }
                            }
                            break;
                        case 2:
                            if (i == 0)
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val1 = j + 1;
                                }
                            }
                            else
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val2 = j + 1;
                                }
                            }
                            break;
                        case 3:
                            if (i == 0)
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val1 = j + 1;
                                }
                            }
                            else
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val2 = j + 1;
                                }
                            }
                            break;
                        case 4:
                            if (i == 0)
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val1 = j + 1;
                                }
                            }
                            else
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val2 = j + 1;
                                }
                            }
                            break;
                        case 5:
                            if (i == 0)
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val1 = j + 1;
                                }
                            }
                            else
                            {
                                if (list[i].IsEqual(getDiceList()[j]))
                                {
                                    val2 = j + 1;
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }
                if (val1 != 0 && val2 != 0)
                {
                    value = val1 + val2;
                    break;
                }
            }
            return value;
        }

        private Button[] getChipList()
        {
            Button[] buttonList = new Button[8];
            buttonList[0] = btnChip1;
            buttonList[1] = btnChip5;
            buttonList[2] = btnChip10;
            buttonList[3] = btnChip50;
            buttonList[4] = btnChip100;
            buttonList[5] = btnChip500;
            buttonList[6] = btnChip1000;
            buttonList[7] = btnChip5000;

            return buttonList;
        }

        //chip that is selected when the button is clicked
        private List<BitmapImage> chipImage = new List<BitmapImage>();
        //chip value for the selected chip
        private List<int> chipValue = new List<int>();

        private BitmapImage addImage(Uri url)
        {
            BitmapImage dice = new BitmapImage(url);
            return dice;
        }
        private void RollButton_Click(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            int roll1 = random.Next(1, 7);
            int roll2 = random.Next(1, 7);
            int[] rolls = { roll1, roll2 };
            for (int i = 0; i < rolls.Length; i++)
            {
                switch (rolls[i])
                {
                    case 1:
                        if (i == 0)
                        {
                            imgDiceOne.Source = getDiceList()[0];
                        }
                        else
                        {
                            imgDiceTwo.Source = getDiceList()[0];
                        }
                        break;
                    case 2:
                        if (i == 0)
                        {
                            imgDiceOne.Source = getDiceList()[1];
                        }
                        else
                        {
                            imgDiceTwo.Source = getDiceList()[1];
                        }
                        break;
                    case 3:
                        if (i == 0)
                        {
                            imgDiceOne.Source = getDiceList()[2];
                        }
                        else
                        {
                            imgDiceTwo.Source = getDiceList()[2];
                        }
                        break;
                    case 4:
                        if (i == 0)
                        {
                            imgDiceOne.Source = getDiceList()[3];
                        }
                        else
                        {
                            imgDiceTwo.Source = getDiceList()[3];
                        }
                        break;
                    case 5:
                        if (i == 0)
                        {
                            imgDiceOne.Source = getDiceList()[4];
                        }
                        else
                        {
                            imgDiceTwo.Source = getDiceList()[4];
                        }
                        break;
                    case 6:
                        if (i == 0)
                        {
                            imgDiceOne.Source = getDiceList()[5];
                        }
                        else
                        {
                            imgDiceTwo.Source = getDiceList()[5];
                        }
                        break;
                    default:
                        break;
                }
            }
            int value = getValueRoll(imgDiceOne, imgDiceTwo);

            //asdf.Content = singleRollBets(value);
            singleRollBets(value);
            multiRollBets(value);
        }

        private string[] singleRollList = {"Single Two", "SIngle Craps", "Single Three", "Hard Four", "Hard Six", "Hard Eight", "Hard Ten", "Single Seven", "Field" };
        private int winnings = 0;
        //Clears all single Bets from the field
        private void removeSingleBets()
        {
            for(int i = 0; i < bets.Count; i++)
            {
                for(int j = 0; j < singleRollList.Length; j++)
                {
                    if(bets.ElementAt(i).Key.Equals(singleRollList[j]))
                    {
                        bets.ElementAt(i).Value.Clear();
                    }
                }
            }

            foreach (Grid grid in getSingleRollBetGrids())
            {
                grid.Children.Clear();
            }
        }
        private int singleRollBets(int value)
        {
            BitmapImage dice1 = (BitmapImage)imgDiceOne.Source;
            BitmapImage dice2 = (BitmapImage)imgDiceTwo.Source;
            switch(value)
            {
                case 2:
                    if(getBetListValues("Single Two") != 0)
                    {
                        winnings += getBetListValues("Single Two") + (30 * getBetListValues("Single Two"));

                    }
                    if(getBetListValues("Single Craps") != 0)
                    {
                        winnings += getBetListValues("Single Craps") + (7 * getBetListValues("Single Craps"));
                    }
                    if(getBetListValues("Field") != 0)
                    {
                        winnings += getBetListValues("Field") + (2 * getBetListValues("Field"));
                    }

                    break;
                case 3:
                    if(getBetListValues("Single Three") != 0)
                    {
                        winnings += getBetListValues("Single Three") + (15 * getBetListValues("Single Three"));
                    }
                    if(getBetListValues("Single Craps") != 0)
                    {
                        winnings += getBetListValues("Single Craps") + (7 * getBetListValues("Single Craps"));
                    }
                    if(getBetListValues("Field") != 0)
                    {
                        winnings += (2 * getBetListValues("Field"));
                    }
                    break;
                case 4:
                    if(dice1.IsEqual(getDiceList()[1]) && dice2.IsEqual(getDiceList()[1]))
                    {
                        winnings += getBetListValues("Hard Four") + (7 * getBetListValues("Hard Four"));
                    }
                    if(getBetListValues("Field") != 0)
                    {
                        winnings += 2 * getBetListValues("Field");
                    }
                    break;
                case 6:
                    if(dice1.IsEqual(getDiceList()[2]) && dice2.IsEqual(getDiceList()[2]))
                    {
                        winnings += getBetListValues("Hard Six") + (9 * getBetListValues("Hard Six"));
                    }
                    break;
                case 7:
                    if(getBetListValues("Single Seven") != 0)
                    {
                        winnings += getBetListValues("Single Seven") + (4 * getBetListValues("Single Seven"));
                    }
                    break;
                case 8:
                    if(dice1.IsEqual(getDiceList()[3]) && dice2.IsEqual(getDiceList()[3]))
                    {
                        winnings += getBetListValues("Hard Eight") + (9 * getBetListValues("Hard Eight"));
                    }
                    break;
                case 9:
                    if(getBetListValues("Field") != 0)
                    {
                        winnings += (2 * getBetListValues("Field"));
                    }
                    break;
                case 10:
                    if(dice1.IsEqual(getDiceList()[4]) && dice2.IsEqual(getDiceList()[4]))
                    {
                        winnings += getBetListValues("Hard Ten") + (7 * getBetListValues("Hard Ten"));
                    }
                    if(getBetListValues("Field") != 0)
                    {
                        winnings += 2 * getBetListValues("Field");
                    }
                    break;
                case 11:
                    if(getBetListValues("Single Eleven") != 0)
                    {
                        winnings += getBetListValues("Single Eleven") + (15 * getBetListValues("Single Eleven"));
                    }
                    if(getBetListValues("Single Craps") != 0)
                    {
                        winnings += getBetListValues("Single Craps") + (7 * getBetListValues("Single Craps"));
                    }
                    if(getBetListValues("Field") != 0)
                    {
                        winnings += 2 * getBetListValues("Field");
                    }
                    break;
                case 12:
                    if(getBetListValues("Single Twelve") != 0)
                    {
                        winnings += getBetListValues("Single Twelve") + (30 * getBetListValues("Single Twelve"));
                    }
                    if(getBetListValues("Single Craps") != 0)
                    {
                        winnings += getBetListValues("Single Craps") + (7 * getBetListValues("Single Craps"));
                    }
                    if(getBetListValues("Field") != 0)
                    {
                        winnings += getBetListValues("Field") + (3 * getBetListValues("Field"));
                    }
                    break;
                default:
                    break;
            }
            removeSingleBets();
            return winnings;
        }

        private void BtnChip_Click(object sender, RoutedEventArgs e)
        {
            chipImage.Clear();
            chipValue.Clear();
            for(int i = 0; i < getChipList().Length; i++)
            {
                if(getChipList()[i].Equals((Button)sender))
                {
                    switch (i)
                    {
                        case 0:
                            BitmapImage image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip1.png"));
                            chipImage.Add(image);
                            chipValue.Add(1);
                            break;
                        case 1:
                            image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip5.png"));
                            chipImage.Add(image);
                            chipValue.Add(5);
                            break;
                        case 2:
                            image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip10.png"));
                            chipImage.Add(image);
                            chipValue.Add(10);
                            break;
                        case 3:
                            image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip50.png"));
                            chipImage.Add(image);
                            chipValue.Add(50);
                            break;
                        case 4:
                            image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip100.png"));
                            chipImage.Add(image);
                            chipValue.Add(100);
                            break;
                        case 5:
                            image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip500.png"));
                            chipImage.Add(image);
                            chipValue.Add(500);
                            break;
                        case 6:
                            image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip1000.png"));
                            chipImage.Add(image);
                            chipValue.Add(1000);
                            break;
                        case 7:
                            image = new BitmapImage(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip5000.png"));
                            chipImage.Add(image);
                            chipValue.Add(5000);
                            break;
                        default:
                            break;
                    }
                }
            }
        }
        
        //Lists that store all bets for single fields
        private List<int> singleCraps = new List<int>();
        private List<int> singleTwo = new List<int>();
        private List<int> singleThree = new List<int>();
        private List<int> singleSeven = new List<int>();
        private List<int> singleEleven = new List<int>();
        private List<int> singleTwelve = new List<int>();
        private List<int> hardFour = new List<int>();
        private List<int> hardSix = new List<int>();
        private List<int> hardEight = new List<int>();
        private List<int> hardTen = new List<int>();
        private List<int> fieldBets = new List<int>();

        private Image addImageToBet(int chipValue, Grid grid)
        {
            Image chipImg = new Image();
            chipImg.Source = new BitmapImage(new Uri($@"pack://application:,,,/files/resources/CasinoAssets/UI/Chip{chipValue}.png"));
            chipImg.Height = 15;
            chipImg.Width = 15;
            chipImg.SetValue(Grid.ColumnProperty, grid.Children.Count);
            return chipImg;
        }
        private void SingleRollBet_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for(int i = 0; i < getSingleRollBets().Count; i++)
                {
                    if(getSingleRollBets()[i].Equals((Button)sender))
                    {
                        switch(i)
                        {
                            case 0:
                                singleCraps.Add(chipValue[0]);
                                btnSingleCraps.Opacity = 1;
                                btnSingleCrapsChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnSingleCrapsChips.Children.Add(addImageToBet(chipValue[0], btnSingleCrapsChips));
                                break;
                            case 1:
                                singleTwo.Add(chipValue[0]);
                                btnTwoSingleRoll.Opacity = 1;
                                btnSingleRollTwoChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnSingleRollTwoChips.Children.Add(addImageToBet(chipValue[0], btnSingleRollTwoChips));
                                break;
                            case 2:
                                singleThree.Add(chipValue[0]);
                                btnThreeSingleRoll.Opacity = 1;
                                btnSingleRollThreeChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnSingleRollThreeChips.Children.Add(addImageToBet(chipValue[0], btnSingleRollThreeChips));
                                break;
                            case 3:
                                singleSeven.Add(chipValue[0]);
                                btnSingleRollSeven.Opacity = 1;
                                btnSingleRollSevenChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnSingleRollSevenChips.Children.Add(addImageToBet(chipValue[0], btnSingleRollSevenChips));
                                break;
                            case 4:
                                singleEleven.Add(chipValue[0]);
                                btnElevenSingleRoll.Opacity = 1;
                                btnSingleRollElevenChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnSingleRollElevenChips.Children.Add(addImageToBet(chipValue[0], btnSingleRollElevenChips));
                                break;
                            case 5:
                                singleTwelve.Add(chipValue[0]);
                                btnTwelveSingleRoll.Opacity = 1;
                                btnSingleRollTwelveChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnSingleRollTwelveChips.Children.Add(addImageToBet(chipValue[0], btnSingleRollTwelveChips));
                                break;
                            case 6:
                                hardFour.Add(chipValue[0]);
                                btnHardwayFour7to1.Opacity = 1;
                                btnHardwayFourChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnHardwayFourChips.Children.Add(addImageToBet(chipValue[0], btnHardwayFourChips));
                                break;
                            case 7:
                                hardSix.Add(chipValue[0]);
                                btnHardwaySix9to1.Opacity = 1;
                                btnHardwaySixChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnHardwaySixChips.Children.Add(addImageToBet(chipValue[0], btnHardwaySixChips));
                                break;
                            case 8:
                                hardEight.Add(chipValue[0]);
                                btnHardwayeight9to1.Opacity = 1;
                                btnHardwayEightChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnHardwayEightChips.Children.Add(addImageToBet(chipValue[0], btnHardwayEightChips));
                                break;
                            case 9:
                                hardTen.Add(chipValue[0]);
                                btnHardwayten7to1.Opacity = 1;
                                btnHardwayTenChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnHardwayTenChips.Children.Add(addImageToBet(chipValue[0], btnHardwayTenChips));
                                break;
                            case 10:
                                fieldBets.Add(chipValue[0]);
                                btnField.Opacity = 1;
                                btnFieldChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnFieldChips.Children.Add(addImageToBet(chipValue[0], btnFieldChips));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a chip before betting!");
            }

        }

        //Lists that store all bets for multifields
        private List<int> dontPassBets = new List<int>();
        private List<int> passLineBets = new List<int>();
        private List<int> fourBets = new List<int>();
        private List<int> fiveBets = new List<int>();
        private List<int> sixBets = new List<int>();
        private List<int> eightBets = new List<int>();
        private List<int> nineBets = new List<int>();
        private List<int> tenBets = new List<int>();

        private Dictionary<string, List<int>> bets = new Dictionary<string, List<int>>();
        private void insertLists()
        {
            bets.Add("Single Craps", singleCraps);
            bets.Add("Single Two", singleTwo);
            bets.Add("Single Three", singleThree);
            bets.Add("Single Seven", singleSeven);
            bets.Add("Single Eleven", singleEleven);
            bets.Add("Single Twelve", singleTwelve);
            bets.Add("Hard Four", hardFour);
            bets.Add("Hard Six", hardSix);
            bets.Add("Hard Eight", hardEight);
            bets.Add("Hard Ten", hardTen);
            bets.Add("Don't Pass Line", dontPassBets);
            bets.Add("Pass Line", passLineBets);
            bets.Add("Field", fieldBets);
            bets.Add("Four", fourBets);
            bets.Add("Five", fiveBets);
            bets.Add("Six", sixBets);
            bets.Add("Eight", eightBets);
            bets.Add("Nine", nineBets);
            bets.Add("Ten", tenBets);
        }

        private int getBetListValues(string key)
        {
            int value = 0;
            for(int i = 0; i < bets.Count; i++)
            {
                if(bets.ElementAt(i).Key.Equals(key))
                {
                    for(int j = 0; j < bets.ElementAt(i).Value.Count; j++)
                    {
                        value += bets.ElementAt(i).Value[j];
                    }
                }
            }
            return value;
        }

        private void BtnMultiRoll_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for(int i = 0; i < getMultiRollBets().Count; i++)
                {
                    if(getMultiRollBets()[i] == (Button)sender)
                    {
                        switch(i)
                        {
                            case 0:
                                dontPassBets.Add(chipValue[0]);
                                btnDontPassBar.Opacity = 1;
                                btnDontPassLineChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnDontPassLineChips.Children.Add(addImageToBet(chipValue[0], btnDontPassLineChips));
                                break;
                            case 1:
                                passLineBets.Add(chipValue[0]);
                                btnPassLine.Opacity = 1;
                                btnPassLineChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnPassLineChips.Children.Add(addImageToBet(chipValue[0], btnPassLineChips));
                                break;
                            case 2:
                                fourBets.Add(chipValue[0]);
                                btnMultiRollFour.Opacity = 1;
                                btnMultiRollFourChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnMultiRollFourChips.Children.Add(addImageToBet(chipValue[0], btnMultiRollFourChips));
                                break;
                            case 3:
                                fiveBets.Add(chipValue[0]);
                                btnMultiRollFive.Opacity = 1;
                                btnMultiRollFiveChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnMultiRollFiveChips.Children.Add(addImageToBet(chipValue[0], btnMultiRollFiveChips));
                                break;
                            case 4:
                                sixBets.Add(chipValue[0]);
                                btnMultiRollSix.Opacity = 1;
                                btnMultiRollSixChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnMultiRollSixChips.Children.Add(addImageToBet(chipValue[0], btnMultiRollSixChips));
                                break;
                            case 5:
                                eightBets.Add(chipValue[0]);
                                btnMultiRollEight.Opacity = 1;
                                btnMultiRollEightChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnMultiRollEightChips.Children.Add(addImageToBet(chipValue[0], btnMultiRollEightChips));
                                break;
                            case 6:
                                nineBets.Add(chipValue[0]);
                                btnMultiRollNine.Opacity = 1;
                                btnMultiRollNineChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnMultiRollNineChips.Children.Add(addImageToBet(chipValue[0], btnMultiRollNineChips));
                                break;
                            case 7:
                                tenBets.Add(chipValue[0]);
                                btnMultiRollTen.Opacity = 1;
                                btnMultiRollTenChips.ColumnDefinitions.Add(new ColumnDefinition());
                                btnMultiRollTenChips.Children.Add(addImageToBet(chipValue[0], btnMultiRollTenChips));
                                break;
                            default:
                                break;
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Please select a chip before betting!");
            }
        }

        //mutliroll bullshit



        private void removeMultiRollList(string key)
        {
            for(int i = 0; i < bets.Count; i++)
            {
                if(bets.ElementAt(i).Key.Equals(key))
                {
                    bets.ElementAt(i).Value.Clear();
                }
            }

            switch (key) {
                case "Four":
                    MessageBox.Show("What the nut four");
                    break;
                case "Five":
                    MessageBox.Show("What the nut five");
                    break;
                case "Six":
                    MessageBox.Show("What the nut six");
                    break;
                case "Eight":
                    MessageBox.Show("What the nut eight");
                    break;
                case "Nine":
                    MessageBox.Show("What the nut nine");
                    break;
                case "Ten":
                    MessageBox.Show("What the nut ten");
                    break;

            }
        }

        private void removeAllMultiRollList()
        {
            foreach(KeyValuePair<string, List<int>> kvp in bets)
            {
                kvp.Value.Clear();
            }

            foreach (Grid grid in getMultiRollBetGrids())
            {
                grid.Children.Clear();
            }
        }
        
        private void multiRollBets(int value)
        {
            if(point == 0 && !(value == 7 || value == 11 || value == 2 || value == 3 || value == 12))
            {
                point = value;
                asdf.Content = point;
                
            }else if(point == 0 && (value == 2 || value == 3 || value == 12))
            {
                if(getBetListValues("Don't Pass Line") != 0)
                {
                    winnings += 2 * getBetListValues("Don't Pass Line");
                }
                removeAllMultiRollList();

                point = 0;
            } else if(point == 0 && (value == 7 || value == 11))
            {
                if(getBetListValues("Pass Line") != 0)
                {
                    winnings += 2 * getBetListValues("Pass Line");
                }
                removeAllMultiRollList();
                point = 0;
            } else if(point != 0 && value == 7)
            {
                removeAllMultiRollList();
                point = 0;
                if(getBetListValues("Don't Pass Line") != 0)
                {
                    winnings += 2 * getBetListValues("Don't Pass Line");
                    removeMultiRollList("Dont' Pass Line");
                }
            } else
            {
                if(value == point)
                {
                    point = 0;
                    if(getBetListValues("Pass Line") != 0)
                    {
                        winnings += 2 * getBetListValues("Pass Line");   
                    }
                    removeAllMultiRollList();
                } else if(value == 7)
                {
                    if(getBetListValues("Don't Pass Line") != 0)
                    {
                        winnings += 2 * getBetListValues("Don't Pass Line");
                    }
                    removeAllMultiRollList();
                    point = 0;
                } else
                {
                    switch(value)
                    {
                        case 4:

                            if(getBetListValues("Four") != 0)
                            {
                                winnings += 2 * getBetListValues("Four");
                                removeMultiRollList("Four");

                            }
                            if(point == value)
                            {
                                if(getBetListValues("Pass Line") != 0)
                                {
                                    winnings += 2 * getBetListValues("Pass Line");
                                }
                                removeAllMultiRollList();
                                point = 0;
                            }
                            break;
                        case 5:

                            if(getBetListValues("Five") != 0)
                            {
                                winnings += 2 * getBetListValues("Five");
                                removeMultiRollList("Five");

                            }
                            if(point == value)
                            {
                                if(getBetListValues("Pass Line") != 0)
                                {
                                    winnings += 2 * getBetListValues("Pass Line");
                                }
                                removeAllMultiRollList();
                                point = 0;
                            }
                            break;
                        case 6:
                            if(getBetListValues("Six") != 0)
                            {
                                winnings += 2 * getBetListValues("Six");
                                removeMultiRollList("Six");

                            }
                            if(point == value)
                            {
                                if(getBetListValues("Pass Line") != 0)
                                {
                                    winnings += 2 * getBetListValues("Pass Line");
                                }
                                removeAllMultiRollList();
                                point = 0;
                            }
                            break;
                        case 8:
                            if(getBetListValues("Eight") != 0)
                            {
                                winnings += 2 * getBetListValues("Eight");
                                removeMultiRollList("Eight");

                            }
                            if(point == value)
                            {
                                if(getBetListValues("Pass Line") != 0)
                                {
                                    winnings += 2 * getBetListValues("Pass Line");
                                }
                                removeAllMultiRollList();
                                point = 0;
                            }
                            break;
                        case 9:
                            if(getBetListValues("Nine") != 0)
                            {
                                winnings += 2 * getBetListValues("Nine");
                                removeMultiRollList("Nine");

                            }
                            if(point == value)
                            {
                                if(getBetListValues("Pass Line") != 0)
                                {
                                    winnings += 2 * getBetListValues("Pass Line");
                                }
                                removeAllMultiRollList();
                                point = 0;
                            }
                            break;
                        case 10:
                            if(getBetListValues("Ten") != 0)
                            {
                                winnings += 2 * getBetListValues("Ten");
                                removeMultiRollList("Ten");

                            }
                            if(point == value)
                            {
                                if(getBetListValues("Pass Line") != 0)
                                {
                                    winnings += 2 * getBetListValues("Pass Line");
                                }
                                removeAllMultiRollList();
                                point = 0;
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}