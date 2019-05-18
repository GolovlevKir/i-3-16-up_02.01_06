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
    /// Логика взаимодействия для Obuch.xaml
    /// </summary>
    public partial class Obuch : UserControl
    {
        public Obuch()
        {
            InitializeComponent();
        }
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int indexMainMenu = ListViewMenu.SelectedIndex;
            switch (indexMainMenu)
            {
                case 0:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Rez_test());
                    break;
                case 1:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Plan_Test());
                    break;

                case 2:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Test());
                    break;
                case 3:
                    GridMain.Children.Clear();
                    GridMain.Children.Add(new Med_Zakl());
                    break;
            }
        }
    }
}
