using MenuAnimation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
    /// Логика взаимодействия для Interface.xaml
    /// </summary>
    /// 

    public partial class Interfaces : UserControl
    {
        int pnl;
        

        public Interfaces()
        {
            InitializeComponent();
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

      //  MainWindow menu = new MainWindow();

        public object ob;
        Color selectedColor;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            cmbColors.IsEnabled = true;
            LeftPanel.Opacity = 0.4;
            topPanel.Opacity = 0.4;
            BotPanel.Opacity = 0.4;
            (sender as Button).Opacity = 1;
            ForAll.IsChecked = false;
            ob = sender as Button;
            
        }

        private void cmbColors_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selectedColor = (Color)(cmbColors.SelectedItem as PropertyInfo).GetValue(null, null);
            switch (ForAll.IsChecked)
            {
                case false:
                    (ob as Button).Background = new SolidColorBrush(selectedColor);
                    pnl = Convert.ToInt32((ob as Button).Tag);
                    break;
                case true:
                    LeftSideColor.SelectedColor(selectedColor);
                    TopColor.SelectedColor(selectedColor);
                    CenterColor.SelectedColor(selectedColor);
                    LeftPanel.Background = new SolidColorBrush(selectedColor);
                    topPanel.Background = new SolidColorBrush(selectedColor);
                    BotPanel.Background = new SolidColorBrush(selectedColor);
                   
                    break;
            }
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            switch (ForAll.IsChecked)
            {
                case true:
                    LeftPanel.Opacity = 1;
                    topPanel.Opacity = 1;
                    BotPanel.Opacity = 1;
                    LeftPanel.Background = new SolidColorBrush(selectedColor);
                    this.Background = new SolidColorBrush(selectedColor);

                    topPanel.Background = new SolidColorBrush(selectedColor);
                   // menu.StackPanelMenu.Background = new SolidColorBrush(selectedColor);
                    BotPanel.Background = new SolidColorBrush(selectedColor);
                  //  menu.StackPanelMenu.Background = new SolidColorBrush(selectedColor);
                    cmbColors.IsEnabled = true;
                    break;
                case false:
                    LeftPanel.Opacity = 0.4;
                    topPanel.Opacity = 0.4;
                    BotPanel.Opacity = 0.4;
                    break;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            switch (pnl)
            {
                case 0:
                    LeftSideColor.SelectedColor(selectedColor);
                    
                    break;
                case 1:
                    TopColor.SelectedColor(selectedColor);
                    break;
                case 2:
                    CenterColor.SelectedColor(selectedColor);
                    break;
            }
            
            
            //topPanel.Background = menu.GridMain.Background;
            //BotPanel.Background = menu.GridAvtor.Background;
            //menu.StackPanelMenu.Background = LeftPanel.Background;
            //menu.GridMain.Background = BotPanel.Background;
            //menu.GridAvtor.Background = topPanel.Background;
        }
    }
}
