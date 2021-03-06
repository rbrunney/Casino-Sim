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
    /// Interaction logic for Bank.xaml
    /// </summary>
    public partial class Bank : Window
    {
        
        int chips = 0;
        int bank = 0;
        string labelchip;
        string labelbank;
        private bool insufficient;

        PlayerInfo playerInfo;
     
        public Bank()
        {
            InitializeComponent();
            playerInfo = new PlayerInfo();
            labelchip = chipsBal.Content.ToString();
            labelbank = bankBal.Content.ToString() ;

            chips = playerInfo.ChipAmount;
            bank = playerInfo.BankAmount;

            chipsBal.Content += " "+ playerInfo.ChipAmount;
            bankBal.Content += " " + playerInfo.BankAmount;
           
        }
        //back to game selection
        private void backButton_Click(object sender, RoutedEventArgs e)
        {
             
            this.Hide();
            //new GameSelection().Show();
            new Window1().Show();
        }

        //deposit to the bank
        private void moreButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            insufficient = false;
            int chipsConvertingtoCash = -1;
            try
            {
               chipsConvertingtoCash = int.Parse(chipsDeposit.Text);
            }
            catch (Exception) {
                MessageBox.Show("Use only numbers no commmas");
            }
            if (chipsConvertingtoCash > chips || chipsConvertingtoCash < 0) {
                MessageBox.Show("Not enough funds");
                insufficient = true;
            }

            if (!insufficient)
            {
                bank = bank + chipsConvertingtoCash;
                chips = chips - chipsConvertingtoCash;

                if (bank < 0)
                {
                    bankBal.Foreground = System.Windows.Media.Brushes.Red;
                }
                else
                {
                    bankBal.Foreground = System.Windows.Media.Brushes.White;
                }
                chipsBal.Content = labelchip+" " + chips;
                bankBal.Content = labelbank + " " + bank;

                playerInfo.BankAmount = bank;
                playerInfo.ChipAmount = chips;
                File.WriteAllText("playerInfo.txt", $"{bank}:{chips}");

                MessageBox.Show("Deposit complete");
            }
        }
        //withdraw to the game
        private void moreButton_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int cashConvertingtoChips = -1;
            try
            {
                cashConvertingtoChips = int.Parse(chipsWithdraw.Text.ToString().Trim());
            }
            catch (Exception )
            {
                MessageBox.Show("Use only numbers no commmas");
            }
            if (cashConvertingtoChips != -1)
            {
                bank = bank - cashConvertingtoChips;
                chips = chips + cashConvertingtoChips;



                chipsBal.Content = labelchip + " " + chips;
                if (bank < 0)
                {
                    bankBal.Foreground = System.Windows.Media.Brushes.Red;
                }
                else {
                    bankBal.Foreground = System.Windows.Media.Brushes.White;
                }
                bankBal.Content = labelbank + " " + bank;

                playerInfo.BankAmount = bank;
                playerInfo.ChipAmount = chips;
                File.WriteAllText("playerInfo.txt", $"{bank}:{chips}");
                MessageBox.Show(" Withdraw complete");

            }
           
        }

       
    }
}