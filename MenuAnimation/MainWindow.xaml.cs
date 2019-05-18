using MenuAnimation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
using LibraryForSQLCon;


namespace MenuAnimation
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        DataBase_Configuration data = new DataBase_Configuration();
        Vhod vhod = new Vhod();
        public MainWindow()
        {
            LeftSideColor.SelectedColor = new LeftSideColor.SelectColor(this.ColorLeftChange);
            TopColor.SelectedColor = new TopColor.SelectColor(this.ColorTopChange);
            CenterColor.SelectedColor = new CenterColor.SelectColor(this.ColorCenterChange);
            InitializeComponent();
            data.conState += constate;
            Thread thread = new Thread(data.Connection_check);
            thread.Start();
            Thread.Sleep(100);
            WindowState = WindowState.Maximized;
            GridAvtor.Children.Clear();
            GridAvtor.Children.Add(vhod);
            vhod.Pass.IsEnabled = false;
            vhod.Login.IsEnabled = false;
            vhod.Auth.IsEnabled = false;
            vhod.Vk.IsEnabled = false;
            vhod.Reg.IsEnabled = false;
        }

        void ColorLeftChange(Color Color)
        {
            StackPanelMenu.Background = new SolidColorBrush(Color); 
           
        }

        void ColorTopChange(Color Color)
        {
            TopPanel.Background = new SolidColorBrush(Color);
        }

        void ColorCenterChange(Color Color)
        {
            GridAvtor.Background = new SolidColorBrush(Color);
        }

        private void ButtonClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void ButtonOpenMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Collapsed;
            ButtonCloseMenu.Visibility = Visibility.Visible;
        }

        private void ButtonCloseMenu_Click(object sender, RoutedEventArgs e)
        {
            ButtonOpenMenu.Visibility = Visibility.Visible;
            ButtonCloseMenu.Visibility = Visibility.Collapsed;
        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            int indexMainMenu = ListViewMenu.SelectedIndex;
            switch (indexMainMenu)
            {
                case 0:
                    GridAvtor.Children.Clear();
                    GridAvtor.Children.Add(new Account());
                    break;
                case 1:
                    GridAvtor.Children.Clear();
                    GridAvtor.Children.Add(new Flight());
                    EqpColor.SelectedColor(((SolidColorBrush)StackPanelMenu.Background).Color);
                    break;

                case 2:
                    GridAvtor.Children.Clear();
                    GridAvtor.Children.Add(new Equipment());
                    EqpColor.SelectedColor(((SolidColorBrush)StackPanelMenu.Background).Color);
                    break;
                case 3:
                    GridAvtor.Children.Clear();
                    GridAvtor.Children.Add(new Personal());
                    EqpColor.SelectedColor(((SolidColorBrush)StackPanelMenu.Background).Color);
                    break;
                case 4:
                    ConfCon conf = new ConfCon();
                    conf.Show();
                    conf.TopMost = true;
                    break;
                    
            }
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GridAvtor.Children.Clear();
            GridAvtor.Children.Add(new Interfaces());
        }

        private void ListViewItem4_Selected(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            GridAvtor.Children.Clear();
            GridAvtor.Children.Add(new Interfaces());
        }

        private void constate(bool value)
        {
            Action action = () =>
            {
                switch (value)
                {
                    case (true):
                        MessageBox.Show(Registry_Class.DS + " - " + Registry_Class.IC);
                        vhod.Pass.IsEnabled = true;
                        vhod.Login.IsEnabled = true;
                        vhod.Auth.IsEnabled = true;
                        vhod.Vk.IsEnabled = true;
                        vhod.Reg.IsEnabled = true;
                        break;
                    case (false):
                        ConfCon conection = new ConfCon();
                        conection.Show();
                        this.Hide();
                        break;
                }
            };
            Dispatcher.Invoke(action);
        }

        private void ListViewItem4_Selected_1(object sender, RoutedEventArgs e)
        {

        }
    }
}



















//GridAvtor.Children.Add(new Obuch());