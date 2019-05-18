using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
    /// Логика взаимодействия для Adres.xaml
    /// </summary>
    public partial class Adres : UserControl
    {
        public Adres()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Thread thread = new Thread(AdresLoad);
            thread.Start();
        }

        public void AdresLoad()
        {
            try
            {
                Action action = () =>
                {
                    try
                    {
                        DataBaseTables dataComb = new DataBaseTables();
                        dataComb.dtAdresSklada.Clear();
                        dataComb.dtAdresSkladaFill();
                        DataTable data = new DataTable();
                        data = dataComb.dtAdresSklada;
                        TableSDannimi.ItemsSource = data.DefaultView;
                        dataComb.dependency.OnChange += Skladonchange;
                        Registry_Class.sqlConnection.Close();

                    }
                    catch
                    {

                    }

                };
                Dispatcher.Invoke(action);
            }
            catch { }
        }

        private void Skladonchange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Info != SqlNotificationInfo.Invalid)
                AdresLoad();
        }
    }
}
