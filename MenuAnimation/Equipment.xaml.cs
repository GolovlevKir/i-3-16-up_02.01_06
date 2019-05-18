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
    /// Логика взаимодействия для Filight.xaml
    /// </summary>
    public partial class Equipment : UserControl
    {
        public Equipment()
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
                    GridMain.Children.Add(new Oborud());
                    break;
                case 1:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Sklad());
                    break;
                case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Naznach_Oborud());
                    break;
                case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Korabli());
                    break;
                case 4:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Adres());
                    break;
            }

        }

    }
}