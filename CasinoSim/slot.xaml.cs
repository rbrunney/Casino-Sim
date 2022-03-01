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
using System.Windows.Shapes;

namespace CasinoSim
{
    /// <summary>
    /// Interaction logic for slot.xaml
    /// </summary>
    public partial class slot : Window
    {
        public slot()
        {
            InitializeComponent();
            //InsertDictionary();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            new Window1().Show();
        }
        private Dictionary<string, List<BitmapImage>> Slots = new();
        private List<BitmapImage> leftColumn = new();
        private List<BitmapImage> rightColumn = new();
        private List<BitmapImage> middleColumn = new();

        private void spin(object sender, RoutedEventArgs e)
        {
            Slots.Add("Left Column", leftColumn);
            Slots.Add("Middle Column", middleColumn);
            Slots.Add("Right Column", rightColumn);

            PopulateLists();
        }

        private void PopulateLists()
        {
            BitmapImage cherry = new(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Slots/Wheel - Cherry.png"));
            BitmapImage seven = new(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Slots/Wheel - Seven.png"));
            BitmapImage bars = new(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Slots/Wheel - Bars.png"));
            BitmapImage bells = new(new Uri(@"pack://application:,,,/files/resources/CasinoAssets/Slots/Wheel - Bell.png"));

            leftColumn.Add(cherry);
            leftColumn.Add(seven);
            leftColumn.Add(bars);
            leftColumn.Add(cherry);
            leftColumn.Add(cherry);
            leftColumn.Add(bars);
            leftColumn.Add(bells);
            leftColumn.Add(cherry);
            leftColumn.Add(bells);
            leftColumn.Add(bells);

            middleColumn.Add(bells);
            middleColumn.Add(cherry);
            middleColumn.Add(bars);
            middleColumn.Add(bells);
            middleColumn.Add(cherry);
            middleColumn.Add(bars);
            middleColumn.Add(bells);
            middleColumn.Add(cherry);
            middleColumn.Add(cherry);
            middleColumn.Add(seven);

            rightColumn.Add(bars);
            rightColumn.Add(cherry);
            rightColumn.Add(seven);
            rightColumn.Add(bells);
            rightColumn.Add(cherry);
            rightColumn.Add(bells);
            rightColumn.Add(bars);
            rightColumn.Add(cherry);
            rightColumn.Add(cherry);
            rightColumn.Add(bells);
        }

        private void Spin(object sender, RoutedEventArgs e)
        {
            Random random = new();
            Image leftImage = new();
            Image rightImage = new();
            Image middleImage = new();
            for(int i = 0; i < Slots.Count; i++)
            {
                switch(i)
                {
                    case 0:
                        int number = random.Next(0, 9);
                        leftImage.Source = Slots.ElementAt(i).Value[number];
                        //left.Content = leftImage;
                        break;
                    case 1:
                        number = random.Next(0, 9);
                        middleImage.Source = Slots.ElementAt(i).Value[number];
                        //middle.Content = middleImage;
                        break;
                    case 2:
                        number = random.Next(0, 9);
                        rightImage.Source = Slots.ElementAt(i).Value[number];
                        //right.Content = rightImage;
                        break;
                    default:
                        break;
                }
            }
        }

        private void rulesButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
