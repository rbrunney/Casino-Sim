using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CasinoSim
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PlayerInfo player = new PlayerInfo();
        }

        private void moreButton_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Window1().Show();
        }

        private void exitButton_Click(object sender, RoutedEventArgs e)
        {
           Application.Current.Shutdown();
        }

        private void MoreButton_OnClick(object sender, RoutedEventArgs e)
        {
            

            MessageBox.Show("CREATORS-- \n" +
                            "Robert Brunney \n" +
                            "Armando Ramirez Canas \n" +
                            "Brayden Wong-Lee \n" +
                            "Alex Turro \n" +
                            "Liam Douglas \n" +
                            "Aidan Gull \n \n" +
                            "RESOURCES-- \n" +
                            "Language- C#\n" +
                            "Framework- WPF \n" +
                            "IDEs- Visual Studio Enterprise, IntelliJ Rider \n \n" +
                            "ASSETS-- \n" +
                            "Bret Wardle \n \n" +
                            "THANK YOU! \n" +
                            "We will be working on poker and slots later on so stay tuned for future updates!",
                "Credits",
                MessageBoxButton.OK,
                MessageBoxImage.Information);

        }
    }
}
