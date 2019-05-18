using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryForSQLCon;

namespace MenuAnimation
{
    class DataBaseTables
    {
        Registry_Class registry = new Registry_Class();
        public SqlCommand command = new SqlCommand("", Registry_Class.sqlConnection);
        public event Action<DataTable> dtFillFull;
        public DataTable dtAdresSklada = new DataTable("Dolj");
        public SqlDependency dependency = new SqlDependency();

        public string qrAdresSklada = "SELECT ID_AdresSk, Adres_Naim, Kol_Vo_Yach FROM dbo.AdresSklada where [Adres_Logical_Delete] = 0";

        private void dtFill(DataTable table, string query)
        {
            try
            {
                command.Notification = null;
                command.CommandText = query;
                dependency.AddCommandDependency(command);
                SqlDependency.Start(Registry_Class.sqlConnection.ConnectionString);
                Registry_Class.sqlConnection.Open();
                table.Load(command.ExecuteReader());
            }
            catch (StackOverflowException ex)
            {
                Registry_Class.error_message += "\n"
                    + DateTime.Now.ToLongDateString() + ex.Message;
            }
            finally
            {
                Registry_Class.sqlConnection.Close();
            }
        }

        public void dtAdresSkladaFill()
        {
            dtFill(dtAdresSklada, qrAdresSklada);
        }

    }
}
