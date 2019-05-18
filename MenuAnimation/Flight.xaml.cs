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

namespace MenuAnimation
{
    /// <summary>
    /// Логика взаимодействия для Flight.xaml
    /// </summary>
    public partial class Flight : UserControl
    {
        public Flight()
        {
            EqpColor.SelectedColor = new EqpColor.SelectColor(this.ColorLeftChange);
            InitializeComponent();
        }

        void ColorLeftChange(Color Color)
        {
            StackPanelMenu.Background = new SolidColorBrush(Color);
        }

        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexMainMenu = ListViewMenu.SelectedIndex;
            switch (indexMainMenu)
            {
                case 0:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new  Mesta());
                    break;
                case 1:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Polet());
                    break;

                case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Ekipag());
                    break;
                case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Document());
                    break;
                case 4:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Marshrut());
                    break;
                case 5:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Zakl_Poletov());
                    break;
                case 6:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Klient());
                    break;
                case 7:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Vib_Oborud());
                    break;

            }
        }
    }
}
